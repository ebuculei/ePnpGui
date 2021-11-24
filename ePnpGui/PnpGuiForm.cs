using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ePnpGui.Lang;
using ePnpGui.Properties;
using ePnpGui.Utils;

namespace ePnpGui
{
    public partial class PnpGuiForm : Form
    {
        private IDriverStore driverStore;
        private Color savedBackColor;
        private Color savedForeColor;
        private OperationContext context = new OperationContext();

        private static readonly List<CultureInfo> SupportedLanguage = GetSupportedLanguage();

        public PnpGuiForm()
        {
            if (!IsOSSupported())
            {
                MessageBox.Show(
                    Language.Message_Requires_Later_OS,
                    Language.Product_Name,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Application.Exit();
            }

            if (!isRunAsAdministrator)
            {
                RunAsAdministrator();
            }

            var lang = Settings.Default.Language;
            if (lang != null && !CultureInfo.InvariantCulture.Equals(lang))
            {
                Thread.CurrentThread.CurrentCulture = lang;
                Thread.CurrentThread.CurrentUICulture = lang;
            }

            this.InitializeComponent();

            this.Icon = ExtractAssociatedIcon(Application.ExecutablePath);

            this.lstDriverStoreEntries.PrimarySortColumn = this.driverClassColumn;
            this.lstDriverStoreEntries.PrimarySortOrder = SortOrder.Ascending;
            this.lstDriverStoreEntries.SecondarySortColumn = this.driverDateColumn;
            this.lstDriverStoreEntries.SecondarySortOrder = SortOrder.Descending;
            this.lstDriverStoreEntries.CheckBoxes = isRunAsAdministrator;

            this.SetupListViewColumns();

            Trace.TraceInformation("---------------------------------------------------------------");
            Trace.TraceInformation($"{Application.ProductName} started");

            this.UpdateDriverStore(new PnpUtil());
        }

        private void UpdateDriverStore(IDriverStore driverStore)
        {
            this.driverStore = driverStore;

            switch (driverStore.Type)
            {
                case DriverStoreType.Online:
                    {
                        this.Text = Language.Product_Name;
                        this.btnInstall.Enabled = true;
                        if (this.lstDriverStoreEntries.CheckedObjects != null
                            && this.lstDriverStoreEntries.CheckedObjects.Count != 0)
                        {
                            this.btnDeleteForce.Enabled = true;
                            this.deleteForceToolStripMenuItem.Enabled = true;
                        }
                        else {
                            this.btnDeleteForce.Enabled = false;
                            this.deleteForceToolStripMenuItem.Enabled = false;
                        }
                        this.deviceNameColumn.IsVisible = true;
                        break;
                    }

                case DriverStoreType.Offline:
                    {
                        this.Text = Language.Product_Name;
                        this.btnInstall.Enabled = false;
                        this.btnDeleteForce.Enabled = false;
                        this.deleteForceToolStripMenuItem.Enabled = false;
                        this.deviceNameColumn.IsVisible = false;
                        break;
                    }
            }
        }

        private void SetupListViewColumns()
        {
            this.driverSizeColumn.AspectToStringConverter = size => DriverStoreEntry.GetBytesReadable((long)size);

            this.driverOemInfColumn.GroupKeyGetter = rowObject => ((DriverStoreEntry)rowObject).OemId / 10;
            this.driverOemInfColumn.GroupKeyToTitleConverter = groupKey =>
            {
                int? valueBase = (groupKey as int?) * 10;

                return valueBase == null
                    ? null
                    : $"oem {valueBase} - {valueBase + 9}";
            };

            this.driverVersionColumn.GroupKeyGetter = rowObject =>
            {
                DriverStoreEntry driver = (DriverStoreEntry)rowObject;
                return new Version(driver.DriverVersion.Major, driver.DriverVersion.Minor);
            };

            this.driverDateColumn.GroupKeyGetter = rowObject =>
            {
                DriverStoreEntry driver = (DriverStoreEntry)rowObject;
                return new DateTime(driver.DriverDate.Year, driver.DriverDate.Month, 1);
            };

            this.driverDateColumn.GroupKeyToTitleConverter = groupKey => ((DateTime)groupKey).ToString("yyyy-MM");

            this.driverSizeColumn.GroupKeyGetter =
                rowObject => DriverStoreEntry.GetSizeRange(((DriverStoreEntry)rowObject).DriverSize);

            this.driverSizeColumn.GroupKeyToTitleConverter =
                groupKey => DriverStoreEntry.GetSizeRangeName((long)groupKey);
        }

        /// <summary>
        /// Returns an icon representation of an image contained in the specified file.
        /// This function is identical to System.Drawing.Icon.ExtractAssociatedIcon, except this version works.
        /// </summary>
        /// <param name="filePath">The path to the file that contains an image.</param>
        /// <returns>The System.Drawing.Icon representation of the image contained in the specified file.</returns>
        /// <exception cref="System.ArgumentException">filePath does not indicate a valid file.</exception>
        public static Icon ExtractAssociatedIcon(string filePath)
        {
            int index = 0;

            Uri uri;

            if (filePath == null)
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            try
            {
                uri = new Uri(filePath);
            }
            catch (UriFormatException)
            {
                filePath = Path.GetFullPath(filePath);
                uri = new Uri(filePath);
            }

            if (uri.IsFile)
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException(filePath);
                }

                StringBuilder iconPath = new StringBuilder(filePath, 260);

                IntPtr handle = SafeNativeMethods.ExtractAssociatedIcon(
                    new HandleRef(null, IntPtr.Zero),
                    iconPath,
                    ref index);

                if (handle != IntPtr.Zero)
                {
                    return Icon.FromHandle(handle);
                }
            }

            return null;
        }

        public static List<CultureInfo> GetSupportedLanguage()
        {
            List<CultureInfo> supportedLanguage = new List<CultureInfo>
            {
                new CultureInfo("en")
            };

            Assembly assembly = Assembly.GetExecutingAssembly();
            string currentFolder = Path.GetDirectoryName(assembly.Location);
            DirectoryInfo dir = new DirectoryInfo(currentFolder);

            foreach (var file in dir.EnumerateFiles($"{assembly.EntryPoint.DeclaringType.Namespace}.resources.dll", SearchOption.AllDirectories))
            {
                string folderName = file.Directory.Name;
                try
                {
                    supportedLanguage.Add(new CultureInfo(folderName));
                }
                catch (CultureNotFoundException)
                {
                }
            }

            return supportedLanguage;
        }

        private void PnpGuiForm_Shown(object sender, EventArgs e)
        {
            this.savedBackColor = this.lblStatus.BackColor;
            this.savedForeColor = this.lblStatus.ForeColor;

            if (!isRunAsAdministrator)
            {
                this.Text += " " + Language.Product_Name_Additional_ReadOnly;
                this.ShowStatus(Status.Warning, Language.Label_RunAsAdmin);
                this.btnAdd.Enabled = false;
                this.btnInstall.Enabled = false;
                this.btnDelete.Enabled = false;
                this.deleteToolStripMenuItem.Enabled = false;
                this.btnDeleteForce.Enabled = false;
                this.deleteForceToolStripMenuItem.Enabled = false;
                this.btnSelectOld.Enabled = false;
                this.deselectAllDriversToolStripMenuItem.Enabled = false;
            }

            this.PopulateUIWithDriverStoreEntries();
        }

        private void PnpGuiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trace.TraceInformation($"Shutting down - reason {e.CloseReason}");
        }

        private void DeleteDriverStoreEntries2(List<DriverStoreEntry> driverStoreEntries, bool force)
        {
            string msgWarning;

            if (driverStoreEntries?.Count > 0)
            {
                if (driverStoreEntries.Count == 1)
                {
                    msgWarning = string.Format(
                        Language.Message_Delete_Single_Package,
                        force ? Language.Message_Force_Delete : Language.Message_Delete,
                        driverStoreEntries[0].DriverInfName,
                        driverStoreEntries[0].DriverPublishedName);
                }
                else
                {
                    msgWarning = string.Format(
                        Language.Message_Delete_Multiple_Packages,
                        force ? Language.Message_Force_Delete : Language.Message_Delete,
                        driverStoreEntries.Count);
                }

                msgWarning += Environment.NewLine + Language.Message_Sure;

                if (DialogResult.OK == MessageBox.Show(
                    msgWarning,
                    Language.Message_Title_Warning,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning))
                {
                    this.DeleteDriverPackages2(driverStoreEntries, force);
                }
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((Action)(() => this.ShowOperationInProgress(true)));
            OperationContext localContext = (OperationContext)e.Argument;

            switch (localContext.Code)
            {
                case OperationCode.EnumerateStore:
                    localContext.ResultData = this.driverStore.EnumeratePackages();
                    break;

                case OperationCode.DeleteDriver:
                    this.DeleteDriver(ref localContext, false);
                    break;

                case OperationCode.ForceDeleteDriver:
                    this.DeleteDriver(ref localContext, true);
                    break;

                case OperationCode.AddDriver:
                    localContext.ResultStatus = this.driverStore.AddDriver(localContext.InfPath, false);
                    break;

                case OperationCode.AddInstallDriver:
                    localContext.ResultStatus = this.driverStore.AddDriver(localContext.InfPath, true);
                    break;

                case OperationCode.Dummy:
                    throw new Exception("Invalid argument rcvd by bgroundWorker");
            }

            e.Result = localContext;
        }

        private void DeleteDriver(ref OperationContext localContext, bool force)
        {
            if (localContext.DriverStoreEntries != null)
            {
                bool totalResult = true;
                StringBuilder sb = new StringBuilder();

                if (localContext.DriverStoreEntries.Count == 1)
                {
                    localContext.ResultStatus = this.driverStore.DeleteDriver(localContext.DriverStoreEntries[0], force);
                }
                else
                {
                    foreach (DriverStoreEntry dse in localContext.DriverStoreEntries)
                    {
                        bool result = this.driverStore.DeleteDriver(dse, force);
                        string resultTxt = string.Format(
                            Language.Message_Delete_Result,
                            dse.DriverInfName,
                            dse.DriverPublishedName,
                            result ? Language.Message_Success : Language.Message_Failed);

                        Trace.TraceInformation(resultTxt);

                        sb.AppendLine(resultTxt);
                        totalResult &= result;
                    }

                    localContext.ResultStatus = totalResult;
                    localContext.ResultData = sb.ToString();
                }
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ShowOperationInProgress(false);

            if (e.Error != null)
            {
                this.ShowStatus(Status.Error, e.Error.Message, e.Error.ToString(), true);
            }
            else
            {
                OperationContext localContext = (OperationContext)e.Result;
                string result;

                switch (localContext.Code)
                {
                    case OperationCode.EnumerateStore:
                        this.lstDriverStoreEntries.SetObjects(localContext.ResultData as List<DriverStoreEntry>);
                        this.UpdateColumnSize();
                        break;

                    case OperationCode.ForceDeleteDriver:
                    case OperationCode.DeleteDriver:
                        if (localContext.ResultStatus)
                        {
                            if (localContext.DriverStoreEntries.Count == 1)
                            {
                                result = string.Format(
                                    Language.Message_Delete_Package,
                                    localContext.DriverStoreEntries[0].DriverInfName,
                                    localContext.DriverStoreEntries[0].DriverPublishedName);
                            }
                            else
                            {
                                result = string.Format(
                                    Language.Message_Delete_Packages,
                                    localContext.DriverStoreEntries.Count.ToString());
                            }

                            // refresh the UI
                            this.PopulateUIWithDriverStoreEntries();

                            this.ShowStatus(Status.Success, result);
                        }
                        else
                        {
                            string driverDeleteTip = localContext.Code == OperationCode.DeleteDriver
                                ? " " + Language.Tip_Driver_In_Use
                                : string.Empty;

                            string fullResult = null;

                            if (localContext.DriverStoreEntries.Count == 1)
                            {
                                result = string.Format(
                                    Language.Message_Delete_Package_Error,
                                    localContext.DriverStoreEntries[0].DriverInfName,
                                    localContext.DriverStoreEntries[0].DriverPublishedName,
                                    driverDeleteTip);
                            }
                            else
                            {
                                result = string.Format(Language.Message_Delete_Packages_Error, driverDeleteTip);
                                fullResult = $"{result}{Environment.NewLine}{localContext.ResultData as string}";

                                // refresh the UI
                                this.PopulateUIWithDriverStoreEntries();
                            }

                            this.ShowStatus(Status.Error, result, fullResult, true);
                        }

                        //this.cbForceDeletion.Checked = false;

                        break;

                    case OperationCode.AddDriver:
                    case OperationCode.AddInstallDriver:
                        if (localContext.ResultStatus)
                        {
                            result = string.Format(
                                Language.Message_Driver_Added,
                                localContext.Code == OperationCode.AddInstallDriver
                                    ? Language.Message_Driver_And_Installed
                                    : "",
                                localContext.InfPath);

                            // refresh the UI
                            this.PopulateUIWithDriverStoreEntries();
                            this.ShowStatus(Status.Success, result);
                        }
                        else
                        {
                            result = string.Format(
                                Language.Message_Driver_Added_Error,
                                localContext.Code == OperationCode.AddInstallDriver
                                    ? Language.Message_Driver_And_Installed
                                    : "",
                                localContext.InfPath);

                            this.ShowStatus(Status.Error, result, usePopup: true);
                        }

                        //this.cbAddInstall.Checked = false;
                        break;
                }
            }

        }

        private static void ShowAboutBox()
        {
            using (AboutBox ab = new AboutBox())
            {
                ab.ShowDialog();
            }
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            // Check if there are any entries
            if (this.lstDriverStoreEntries.Objects != null)
            {
                this.ctxMenuSelectAll.Enabled = isRunAsAdministrator;
                this.ctxMenuSelectOldDrivers.Enabled = isRunAsAdministrator;

                if (this.lstDriverStoreEntries.CheckedObjects?.Count > 0)
                {
                    this.ctxMenuSelectAll.Text = Language.Context_Deselect_All;
                }
                else
                {
                    this.ctxMenuSelectAll.Text = Language.Context_Select_All;
                }

                if (this.lstDriverStoreEntries.SelectedObjects?.Count > 0)
                {
                    if (this.lstDriverStoreEntries.CheckedObjects?.Count > 0
                        && this.lstDriverStoreEntries
                            .SelectedObjects
                            .Cast<object>()
                            .All(i => this.lstDriverStoreEntries.CheckedObjects.Contains(i)))
                    {
                        this.ctxMenuSelect.Text = Language.Context_Deselect;
                    }
                    else
                    {
                        this.ctxMenuSelect.Text = Language.Context_Select;
                    }

                    this.ctxMenuSelect.Enabled = isRunAsAdministrator;

                    this.ctxMenuOpenFolder.Enabled = this.lstDriverStoreEntries.SelectedObjects.Count == 1;
                }
                else
                {
                    this.ctxMenuOpenFolder.Enabled = false;
                    this.ctxMenuSelect.Enabled = false;
                }
            }
            else
            {
                this.ctxMenuSelect.Enabled = false;
                this.ctxMenuSelectAll.Enabled = false;
                this.ctxMenuSelectOldDrivers.Enabled = false;
                this.ctxMenuOpenFolder.Enabled = false;
            }
        }

        // Function to switch between "selected" and "unselected" states
        private void CtxMenuSelectAll_Click(object sender, EventArgs e)
        {
            // Check if there are any entries
            if (this.lstDriverStoreEntries.Objects != null)
            {
                if (this.lstDriverStoreEntries.CheckedObjects != null
                    && this.lstDriverStoreEntries.CheckedObjects.Count != 0)
                {
                    this.lstDriverStoreEntries.UncheckAll();
                }
                else
                {
                    this.lstDriverStoreEntries.CheckAll();
                }
            }
        }

        private void CtxMenuSelect_Click(object sender, EventArgs e)
        {
            if (this.lstDriverStoreEntries.Objects != null)
            {
                ArrayList list = new ArrayList();
                if (this.lstDriverStoreEntries.CheckedObjects?.Count > 0)
                {
                    list.AddRange(this.lstDriverStoreEntries.CheckedObjects);
                }

                if (this.lstDriverStoreEntries.SelectedObjects?.Count > 0)
                {
                    if (this.lstDriverStoreEntries
                        .SelectedObjects
                        .Cast<object>()
                        .All(i => this.lstDriverStoreEntries.CheckedObjects.Contains(i)))
                    {
                        foreach (var item in this.lstDriverStoreEntries.SelectedObjects)
                        {
                            list.Remove(item);
                        }
                    }
                    else
                    {
                        list.AddRange(this.lstDriverStoreEntries.SelectedObjects);
                    }
                }

                this.lstDriverStoreEntries.CheckedObjects = list;
            }
        }

        private void CtxMenuSelectOldDrivers_Click(object sender, EventArgs e)
        {
            if (this.lstDriverStoreEntries.Objects != null)
            {
                List<DriverStoreEntry> driverStoreEntryList = this.lstDriverStoreEntries.Objects as List<DriverStoreEntry>;

                this.lstDriverStoreEntries.CheckedObjects = driverStoreEntryList
                    .GroupBy(entry => new { entry.DriverClass, entry.DriverPkgProvider, entry.DriverInfName })
                    .SelectMany(g => g.OrderByDescending(row => row.DriverVersion).ThenByDescending(row => row.DriverDate).Skip(1))
                    .Where(entry => string.IsNullOrEmpty(entry.DeviceName))
                    .ToArray();
            }
        }

        private void ExportList()
        {
            // Check if there are any entries
            if (this.lstDriverStoreEntries.Objects != null)
            {
                try
                {
                    List<DriverStoreEntry> ldse = this.lstDriverStoreEntries.Objects as List<DriverStoreEntry>;
                    string fileName = new CsvExporter().Export(ldse);

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        string message = string.Format(Language.Export_Complete, fileName);
                        this.ShowStatus(Status.Normal, message, usePopup: true);
                    }
                }
                catch (Exception ex)
                {
                    this.ShowStatus(Status.Error, string.Format(Language.Export_Failed, ex), usePopup: true);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextFileTraceListener.LastTraceFile))
            {
                Process.Start(TextFileTraceListener.LastTraceFile);
            }
            else
            {
                MessageBox.Show(Language.Message_Log_File_NotFound, Language.Message_Error);
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExportList();
        }

        private void RunAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunAsAdministrator();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutBox();
        }

        private void PnpGuiForm_Load(object sender, EventArgs e)
        {
            this.lstDriverStoreEntries.RestoreState(Convert.FromBase64String(Settings.Default.DriverStoreViewState));

            if (Settings.Default.WindowState != default(FormWindowState))
            {
                this.WindowState = Settings.Default.WindowState;
            }

            if (Settings.Default.WindowLocation != default(Point))
            {
                this.Location = Settings.Default.WindowLocation;
            }

            if (Settings.Default.WindowSize != default(Size))
            {
                this.Size = Settings.Default.WindowSize;
            }
        }

        private void PnpGuiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.DriverStoreViewState = Convert.ToBase64String(this.lstDriverStoreEntries.SaveState());

            Settings.Default.WindowState = this.WindowState;
            Settings.Default.WindowLocation = this.Location;

            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.WindowSize = this.Size;
            }
            else
            {
                Settings.Default.WindowSize = this.RestoreBounds.Size;
            }

            Settings.Default.Save();
        }

        private void LstDriverStoreEntries_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            IList checkedObjects = this.lstDriverStoreEntries.CheckedObjects;

            if (checkedObjects?.Count > 0)
            {
                long totalSize = 0;

                foreach (DriverStoreEntry item in checkedObjects)
                {
                    totalSize += item.DriverSize;
                }

                this.ShowStatus(
                    Status.Normal,
                    string.Format(Language.Status_Selected_Drivers, checkedObjects.Count, DriverStoreEntry.GetBytesReadable(totalSize)));
                this.btnDelete.Enabled = true;
                this.deleteToolStripMenuItem.Enabled = true;
                this.btnDeleteForce.Enabled = true;
                this.deleteForceToolStripMenuItem.Enabled = true;
                this.btnDeselectAll.Enabled = true;
                this.deselectAllDriversToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.ShowStatus(Status.Normal, Language.Status_No_Drivers_Selected);
                this.btnDelete.Enabled = false;
                this.deleteToolStripMenuItem.Enabled = false;
                this.btnDeleteForce.Enabled = false;
                this.deleteForceToolStripMenuItem.Enabled = false;
                this.btnDeselectAll.Enabled = false;
                this.deselectAllDriversToolStripMenuItem.Enabled = false;
            }
        }

        private void UpdateColumnSize()
        {
            // Make the column size fit both header and content.
            for (var i = 0; i < this.lstDriverStoreEntries.Columns.Count - 1; i++)
            {
                this.lstDriverStoreEntries.Columns[i].Width = -2;
            }
        }

        private void CtxMenuOpenFolder_Click(object sender, EventArgs e)
        {
            if (this.lstDriverStoreEntries.SelectedObject != null)
            {
                DriverStoreEntry item = (DriverStoreEntry)this.lstDriverStoreEntries.SelectedObject;
                Process.Start("explorer.exe", "/select, " + Path.Combine(item.DriverFolderLocation, item.DriverInfName));
            }
        }

        private void ChooseDriverStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChooseDriverStore chooseDriverStore = new ChooseDriverStore())
            {
                chooseDriverStore.StoreType = this.driverStore.Type;
                if (this.driverStore.Type == DriverStoreType.Offline)
                {
                    chooseDriverStore.OfflineStoreLocation = this.driverStore.OfflineStoreLocation;
                }

                DialogResult result = chooseDriverStore.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!this.backgroundWorker1.IsBusy)
                    {
                        switch (chooseDriverStore.StoreType)
                        {
                            case DriverStoreType.Online:
                                this.UpdateDriverStore(new PnpUtil());
                                break;

                            case DriverStoreType.Offline:
                                this.UpdateDriverStore(new DismUtil(chooseDriverStore.OfflineStoreLocation));
                                break;
                        }

                        this.PopulateUIWithDriverStoreEntries(true);
                    }
                    else
                    {
                        this.InProgress();
                    }
                }
            }
        }

        private void LstDriverStoreEntries_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == this.deviceNameColumn.Index)
            {
                DriverStoreEntry entry = (DriverStoreEntry)e.Model;
                if (entry.DevicePresent == false)
                {
                    e.SubItem.ForeColor = Color.Gray;
                }
            }
        }

        private void btnChooseStore_Click(object sender, EventArgs e)
        {
            using (ChooseDriverStore chooseDriverStore = new ChooseDriverStore())
            {
                chooseDriverStore.StoreType = this.driverStore.Type;
                if (this.driverStore.Type == DriverStoreType.Offline)
                {
                    chooseDriverStore.OfflineStoreLocation = this.driverStore.OfflineStoreLocation;
                }

                DialogResult result = chooseDriverStore.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!this.backgroundWorker1.IsBusy)
                    {
                        switch (chooseDriverStore.StoreType)
                        {
                            case DriverStoreType.Online:
                                this.UpdateDriverStore(new PnpUtil());
                                break;

                            case DriverStoreType.Offline:
                                this.UpdateDriverStore(new DismUtil(chooseDriverStore.OfflineStoreLocation));
                                break;
                        }

                        this.PopulateUIWithDriverStoreEntries(true);
                    }
                    else
                    {
                        this.InProgress();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateUIWithDriverStoreEntries(true);
            if (this.lstDriverStoreEntries.SelectedIndex == -1)
            {
                this.btnFolderLocation.Enabled = false;
                this.openFolderLocationToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.btnFolderLocation.Enabled = true;
                this.openFolderLocationToolStripMenuItem.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.AddDriverPackage2(this.openFileDialog.FileName, false);
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.AddDriverPackage2(this.openFileDialog.FileName, true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstDriverStoreEntries.CheckedObjects.Count == 0 && this.lstDriverStoreEntries.SelectedIndex == -1)
            {
                // No entry is selected 
                this.ShowStatus(Status.Warning, Language.Message_Select_Driver_Entry);
                return;
            }

            List<DriverStoreEntry> driverStoreEntries = new List<DriverStoreEntry>();
            if (this.lstDriverStoreEntries.CheckedItems.Count > 0)
            {
                foreach (DriverStoreEntry o in this.lstDriverStoreEntries.CheckedObjects)
                {
                    driverStoreEntries.Add(o);
                }
            }

            this.DeleteDriverStoreEntries2(driverStoreEntries, false);
        }

        private void btnDeleteForce_Click(object sender, EventArgs e)
        {
            if (this.lstDriverStoreEntries.CheckedObjects.Count == 0 && this.lstDriverStoreEntries.SelectedIndex == -1)
            {
                // No entry is selected 
                this.ShowStatus(Status.Warning, Language.Message_Select_Driver_Entry);
                return;
            }

            List<DriverStoreEntry> driverStoreEntries = new List<DriverStoreEntry>();
            if (this.lstDriverStoreEntries.CheckedItems.Count > 0)
            {
                foreach (DriverStoreEntry o in this.lstDriverStoreEntries.CheckedObjects)
                {
                    driverStoreEntries.Add(o);
                }
            }

            this.DeleteDriverStoreEntries2(driverStoreEntries, true);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (this.lstDriverStoreEntries.Objects != null)
            {
                /*
                if (this.lstDriverStoreEntries.CheckedObjects != null
                    && this.lstDriverStoreEntries.CheckedObjects.Count != 0)
                {
                    this.lstDriverStoreEntries.UncheckAll();
                }
                else
                {
                    this.lstDriverStoreEntries.CheckAll();
                }
                */
                this.lstDriverStoreEntries.CheckAll();
            }
        }

        private void btnSelectOld_Click(object sender, EventArgs e)
        {
            this.CtxMenuSelectOldDrivers_Click(sender, e);
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            if (this.lstDriverStoreEntries.Objects != null)
            {
                /*
                if (this.lstDriverStoreEntries.CheckedObjects != null
                    && this.lstDriverStoreEntries.CheckedObjects.Count != 0)
                {
                    this.lstDriverStoreEntries.UncheckAll();
                }
                else
                {
                    this.lstDriverStoreEntries.CheckAll();
                }
                */
                this.lstDriverStoreEntries.UncheckAll();
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.ExportList();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextFileTraceListener.LastTraceFile))
            {
                Process.Start(TextFileTraceListener.LastTraceFile);
            }
            else
            {
                MessageBox.Show(Language.Message_Log_File_NotFound, Language.Message_Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ShowAboutBox();
        }

        private void btnFolderLocation_Click(object sender, EventArgs e)
        {
            /*
            if (this.lstDriverStoreEntries.SelectedIndex == -1)
            {
                // No entry is selected 
                this.ShowStatus(Status.Warning, Language.Message_Select_Driver_Entry);
                return;
            }
            */
            this.CtxMenuOpenFolder_Click(sender, e);
        }

        private void lstDriverStoreEntries_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.lstDriverStoreEntries.SelectedIndex == -1)
            {
                this.btnFolderLocation.Enabled = false;
                this.openFolderLocationToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.btnFolderLocation.Enabled = true;
                this.openFolderLocationToolStripMenuItem.Enabled = true;
            }
        }

        private void lstDriverStoreEntries_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.lstDriverStoreEntries.SelectedIndex == -1)
            {
                this.btnFolderLocation.Enabled = false;
                this.openFolderLocationToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.btnFolderLocation.Enabled = true;
                this.openFolderLocationToolStripMenuItem.Enabled = true;
            }
        }

        private void mnRefreshView_Click(object sender, EventArgs e)
        {
            this.btnRefresh_Click(sender, e);
        }

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnAdd_Click(sender, e);
        }

        private void installDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnInstall_Click(sender, e);
        }

        private void openFolderLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnFolderLocation_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnDelete_Click(sender, e);
        }

        private void deleteForceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnDeleteForce_Click(sender, e);
        }

        private void selectAllDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnSelectAll_Click(sender, e);
        }

        private void selectOldDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnSelectOld_Click(sender, e);
        }

        private void deselectAllDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnDeselectAll_Click(sender, e);
        }
    }
}
