
namespace ePnpGui
{
    partial class PnpGuiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PnpGuiForm));
            this.driverOemInfColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.driverSignerColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSelectOldDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRefreshView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogsTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.openFolderLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteForceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOldDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstDriverStoreEntries = new ePnpGui.MyObjectListView();
            this.driverInfColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.driverClassColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.driverProviderColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.driverVersionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.driverDateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.driverSizeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.deviceNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dummyColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnViewLogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnInstall = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFolderLocation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteForce = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.btnSelectOld = new System.Windows.Forms.ToolStripButton();
            this.btnDeselectAll = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstDriverStoreEntries)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // driverOemInfColumn
            // 
            this.driverOemInfColumn.AspectName = "DriverPublishedName";
            this.driverOemInfColumn.IsVisible = false;
            this.driverOemInfColumn.Text = global::ePnpGui.Lang.Language.Column_Oem_Inf;
            this.driverOemInfColumn.Width = 90;
            // 
            // driverSignerColumn
            // 
            this.driverSignerColumn.AspectName = "DriverSignerName";
            this.driverSignerColumn.IsVisible = false;
            this.driverSignerColumn.Text = global::ePnpGui.Lang.Language.Column_Signed_By;
            this.driverSignerColumn.Width = 250;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuSelect,
            this.ctxMenuSelectAll,
            this.ctxMenuSelectOldDrivers,
            this.toolStripSeparator1,
            this.ctxMenuOpenFolder});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(276, 138);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
            // 
            // ctxMenuSelect
            // 
            this.ctxMenuSelect.Name = "ctxMenuSelect";
            this.ctxMenuSelect.Size = new System.Drawing.Size(275, 32);
            this.ctxMenuSelect.Text = "Check";
            this.ctxMenuSelect.Click += new System.EventHandler(this.CtxMenuSelect_Click);
            // 
            // ctxMenuSelectAll
            // 
            this.ctxMenuSelectAll.Name = "ctxMenuSelectAll";
            this.ctxMenuSelectAll.Size = new System.Drawing.Size(275, 32);
            this.ctxMenuSelectAll.Text = "Check All Drivers";
            this.ctxMenuSelectAll.Click += new System.EventHandler(this.CtxMenuSelectAll_Click);
            // 
            // ctxMenuSelectOldDrivers
            // 
            this.ctxMenuSelectOldDrivers.Image = ((System.Drawing.Image)(resources.GetObject("ctxMenuSelectOldDrivers.Image")));
            this.ctxMenuSelectOldDrivers.Name = "ctxMenuSelectOldDrivers";
            this.ctxMenuSelectOldDrivers.Size = new System.Drawing.Size(275, 32);
            this.ctxMenuSelectOldDrivers.Text = "Check Old Drivers";
            this.ctxMenuSelectOldDrivers.Click += new System.EventHandler(this.CtxMenuSelectOldDrivers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(272, 6);
            // 
            // ctxMenuOpenFolder
            // 
            this.ctxMenuOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("ctxMenuOpenFolder.Image")));
            this.ctxMenuOpenFolder.Name = "ctxMenuOpenFolder";
            this.ctxMenuOpenFolder.Size = new System.Drawing.Size(275, 32);
            this.ctxMenuOpenFolder.Text = global::ePnpGui.Lang.Language.Context_Open_Folder;
            this.ctxMenuOpenFolder.Click += new System.EventHandler(this.CtxMenuOpenFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 832);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1232, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1209, 25);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = global::ePnpGui.Lang.Language.Status_Label;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 50;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 24);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = global::ePnpGui.Lang.Language.Dialog_Open_Filters;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = global::ePnpGui.Lang.Language.Dialog_Open_Filter_Text;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 36);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRefreshView,
            this.toolStripSeparator5,
            this.exportToolStripMenuItem,
            this.viewLogsTtoolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnRefreshView
            // 
            this.mnRefreshView.Image = ((System.Drawing.Image)(resources.GetObject("mnRefreshView.Image")));
            this.mnRefreshView.Name = "mnRefreshView";
            this.mnRefreshView.Size = new System.Drawing.Size(260, 34);
            this.mnRefreshView.Text = "&Refresh View";
            this.mnRefreshView.Click += new System.EventHandler(this.mnRefreshView_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(257, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.exportToolStripMenuItem.Text = "&Export Driver List...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // viewLogsTtoolStripMenuItem
            // 
            this.viewLogsTtoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewLogsTtoolStripMenuItem.Image")));
            this.viewLogsTtoolStripMenuItem.Name = "viewLogsTtoolStripMenuItem";
            this.viewLogsTtoolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.viewLogsTtoolStripMenuItem.Text = "View &Logs";
            this.viewLogsTtoolStripMenuItem.Click += new System.EventHandler(this.ViewLogsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(257, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDriverToolStripMenuItem,
            this.installDriverToolStripMenuItem,
            this.toolStripSeparator10,
            this.openFolderLocationToolStripMenuItem,
            this.toolStripSeparator11,
            this.deleteToolStripMenuItem,
            this.deleteForceToolStripMenuItem});
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.driversToolStripMenuItem.Text = "&Drivers";
            // 
            // addDriverToolStripMenuItem
            // 
            this.addDriverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addDriverToolStripMenuItem.Image")));
            this.addDriverToolStripMenuItem.Name = "addDriverToolStripMenuItem";
            this.addDriverToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.addDriverToolStripMenuItem.Text = "&Add Driver...";
            this.addDriverToolStripMenuItem.Click += new System.EventHandler(this.addDriverToolStripMenuItem_Click);
            // 
            // installDriverToolStripMenuItem
            // 
            this.installDriverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("installDriverToolStripMenuItem.Image")));
            this.installDriverToolStripMenuItem.Name = "installDriverToolStripMenuItem";
            this.installDriverToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.installDriverToolStripMenuItem.Text = "&Install Driver...";
            this.installDriverToolStripMenuItem.Click += new System.EventHandler(this.installDriverToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(294, 6);
            // 
            // openFolderLocationToolStripMenuItem
            // 
            this.openFolderLocationToolStripMenuItem.Enabled = false;
            this.openFolderLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFolderLocationToolStripMenuItem.Image")));
            this.openFolderLocationToolStripMenuItem.Name = "openFolderLocationToolStripMenuItem";
            this.openFolderLocationToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.openFolderLocationToolStripMenuItem.Text = "Open Folder &Location...";
            this.openFolderLocationToolStripMenuItem.Click += new System.EventHandler(this.openFolderLocationToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(294, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.deleteToolStripMenuItem.Text = "&Delete Driver(s)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteForceToolStripMenuItem
            // 
            this.deleteForceToolStripMenuItem.Enabled = false;
            this.deleteForceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteForceToolStripMenuItem.Image")));
            this.deleteForceToolStripMenuItem.Name = "deleteForceToolStripMenuItem";
            this.deleteForceToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.deleteForceToolStripMenuItem.Text = "Delete &Force Driver(s)";
            this.deleteForceToolStripMenuItem.Click += new System.EventHandler(this.deleteForceToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllDriversToolStripMenuItem,
            this.selectOldDriversToolStripMenuItem,
            this.deselectAllDriversToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.actionsToolStripMenuItem.Text = "Selections";
            // 
            // selectAllDriversToolStripMenuItem
            // 
            this.selectAllDriversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllDriversToolStripMenuItem.Image")));
            this.selectAllDriversToolStripMenuItem.Name = "selectAllDriversToolStripMenuItem";
            this.selectAllDriversToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.selectAllDriversToolStripMenuItem.Text = "Check All Drivers";
            this.selectAllDriversToolStripMenuItem.Click += new System.EventHandler(this.selectAllDriversToolStripMenuItem_Click);
            // 
            // selectOldDriversToolStripMenuItem
            // 
            this.selectOldDriversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectOldDriversToolStripMenuItem.Image")));
            this.selectOldDriversToolStripMenuItem.Name = "selectOldDriversToolStripMenuItem";
            this.selectOldDriversToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.selectOldDriversToolStripMenuItem.Text = "Check Old Drivers";
            this.selectOldDriversToolStripMenuItem.Click += new System.EventHandler(this.selectOldDriversToolStripMenuItem_Click);
            // 
            // deselectAllDriversToolStripMenuItem
            // 
            this.deselectAllDriversToolStripMenuItem.Enabled = false;
            this.deselectAllDriversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deselectAllDriversToolStripMenuItem.Image")));
            this.deselectAllDriversToolStripMenuItem.Name = "deselectAllDriversToolStripMenuItem";
            this.deselectAllDriversToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.deselectAllDriversToolStripMenuItem.Text = "Uncheck All Drivers";
            this.deselectAllDriversToolStripMenuItem.Click += new System.EventHandler(this.deselectAllDriversToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem1.Image")));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lstDriverStoreEntries, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1232, 793);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // lstDriverStoreEntries
            // 
            this.lstDriverStoreEntries.AllColumns.Add(this.driverInfColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.driverOemInfColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.driverClassColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.driverProviderColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.driverVersionColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.driverDateColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.driverSizeColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.driverSignerColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.deviceNameColumn);
            this.lstDriverStoreEntries.AllColumns.Add(this.dummyColumn);
            this.lstDriverStoreEntries.AllowColumnReorder = true;
            this.lstDriverStoreEntries.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstDriverStoreEntries.CellEditUseWholeCell = false;
            this.lstDriverStoreEntries.CheckBoxes = true;
            this.lstDriverStoreEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.driverInfColumn,
            this.driverClassColumn,
            this.driverProviderColumn,
            this.driverVersionColumn,
            this.driverDateColumn,
            this.driverSizeColumn,
            this.deviceNameColumn,
            this.dummyColumn});
            this.lstDriverStoreEntries.ContextMenuStrip = this.contextMenuStrip;
            this.lstDriverStoreEntries.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstDriverStoreEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDriverStoreEntries.EmptyListMsg = global::ePnpGui.Lang.Language.Message_No_Entries;
            this.lstDriverStoreEntries.FullRowSelect = true;
            this.lstDriverStoreEntries.GridLines = true;
            this.lstDriverStoreEntries.HideSelection = false;
            this.lstDriverStoreEntries.Location = new System.Drawing.Point(4, 40);
            this.lstDriverStoreEntries.Margin = new System.Windows.Forms.Padding(4, 40, 4, 4);
            this.lstDriverStoreEntries.Name = "lstDriverStoreEntries";
            this.lstDriverStoreEntries.ShowItemToolTips = true;
            this.lstDriverStoreEntries.Size = new System.Drawing.Size(1224, 731);
            this.lstDriverStoreEntries.SortGroupItemsByPrimaryColumn = false;
            this.lstDriverStoreEntries.TabIndex = 1;
            this.lstDriverStoreEntries.UseCellFormatEvents = true;
            this.lstDriverStoreEntries.UseCompatibleStateImageBehavior = false;
            this.lstDriverStoreEntries.View = System.Windows.Forms.View.Details;
            this.lstDriverStoreEntries.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.LstDriverStoreEntries_FormatCell);
            this.lstDriverStoreEntries.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LstDriverStoreEntries_ItemChecked);
            this.lstDriverStoreEntries.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstDriverStoreEntries_ItemSelectionChanged);
            this.lstDriverStoreEntries.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstDriverStoreEntries_MouseClick);
            // 
            // driverInfColumn
            // 
            this.driverInfColumn.AspectName = "DriverInfName";
            this.driverInfColumn.Text = global::ePnpGui.Lang.Language.Column_Inf;
            this.driverInfColumn.UseInitialLetterForGroup = true;
            this.driverInfColumn.Width = 120;
            // 
            // driverClassColumn
            // 
            this.driverClassColumn.AspectName = "DriverClass";
            this.driverClassColumn.Text = global::ePnpGui.Lang.Language.Column_Driver_Class;
            this.driverClassColumn.Width = 170;
            // 
            // driverProviderColumn
            // 
            this.driverProviderColumn.AspectName = "DriverPkgProvider";
            this.driverProviderColumn.Text = global::ePnpGui.Lang.Language.Column_Provider;
            this.driverProviderColumn.Width = 160;
            // 
            // driverVersionColumn
            // 
            this.driverVersionColumn.AspectName = "DriverVersion";
            this.driverVersionColumn.Text = global::ePnpGui.Lang.Language.Column_Version;
            this.driverVersionColumn.Width = 110;
            // 
            // driverDateColumn
            // 
            this.driverDateColumn.AspectName = "DriverDate";
            this.driverDateColumn.AspectToStringFormat = global::ePnpGui.Lang.Language.Date_Format;
            this.driverDateColumn.Text = global::ePnpGui.Lang.Language.Column_Date;
            this.driverDateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.driverDateColumn.Width = 80;
            // 
            // driverSizeColumn
            // 
            this.driverSizeColumn.AspectName = "DriverSize";
            this.driverSizeColumn.Text = global::ePnpGui.Lang.Language.Column_Size;
            this.driverSizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.driverSizeColumn.Width = 59;
            // 
            // deviceNameColumn
            // 
            this.deviceNameColumn.AspectName = "DeviceName";
            this.deviceNameColumn.Text = global::ePnpGui.Lang.Language.Column_DeviceName;
            this.deviceNameColumn.Width = 110;
            // 
            // dummyColumn
            // 
            this.dummyColumn.FillsFreeSpace = true;
            this.dummyColumn.Text = "";
            this.dummyColumn.Width = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.toolStripSeparator9,
            this.btnExport,
            this.btnViewLogs,
            this.toolStripSeparator6,
            this.btnAdd,
            this.btnInstall,
            this.toolStripSeparator3,
            this.btnFolderLocation,
            this.toolStripSeparator7,
            this.btnDelete,
            this.btnDeleteForce,
            this.toolStripSeparator8,
            this.btnSelectAll,
            this.btnSelectOld,
            this.btnDeselectAll,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(3, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1232, 41);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 36);
            this.btnRefresh.Text = "txtRefresh";
            this.btnRefresh.ToolTipText = "Refresh view";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 41);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(36, 36);
            this.btnExport.Text = "txtExport";
            this.btnExport.ToolTipText = "Export driver list";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViewLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnViewLogs.Image")));
            this.btnViewLogs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViewLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(36, 36);
            this.btnViewLogs.Text = "txtViewLogs";
            this.btnViewLogs.ToolTipText = "View Logs";
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 41);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.Text = "txtAdd";
            this.btnAdd.ToolTipText = "Add driver package";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInstall.Image = ((System.Drawing.Image)(resources.GetObject("btnInstall.Image")));
            this.btnInstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(36, 36);
            this.btnInstall.Text = "txtInstall";
            this.btnInstall.ToolTipText = "Add and install driver package";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // btnFolderLocation
            // 
            this.btnFolderLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFolderLocation.Enabled = false;
            this.btnFolderLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnFolderLocation.Image")));
            this.btnFolderLocation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFolderLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFolderLocation.Name = "btnFolderLocation";
            this.btnFolderLocation.Size = new System.Drawing.Size(36, 36);
            this.btnFolderLocation.Text = "txtFolderLocation";
            this.btnFolderLocation.ToolTipText = "Open folder location";
            this.btnFolderLocation.Click += new System.EventHandler(this.btnFolderLocation_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 41);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.Text = "txtDelete";
            this.btnDelete.ToolTipText = "Delete driver package(s)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteForce
            // 
            this.btnDeleteForce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteForce.Enabled = false;
            this.btnDeleteForce.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteForce.Image")));
            this.btnDeleteForce.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteForce.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteForce.Name = "btnDeleteForce";
            this.btnDeleteForce.Size = new System.Drawing.Size(36, 36);
            this.btnDeleteForce.Text = "txtDeleteForce";
            this.btnDeleteForce.ToolTipText = "Force delete driver package(s)";
            this.btnDeleteForce.Click += new System.EventHandler(this.btnDeleteForce_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 41);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.Image")));
            this.btnSelectAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(36, 36);
            this.btnSelectAll.Text = "txtSelectAll";
            this.btnSelectAll.ToolTipText = "Check all drivers";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectOld
            // 
            this.btnSelectOld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelectOld.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectOld.Image")));
            this.btnSelectOld.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSelectOld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectOld.Name = "btnSelectOld";
            this.btnSelectOld.Size = new System.Drawing.Size(36, 36);
            this.btnSelectOld.Text = "txtSelectOld";
            this.btnSelectOld.ToolTipText = "Check old drivers";
            this.btnSelectOld.Click += new System.EventHandler(this.btnSelectOld_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeselectAll.Enabled = false;
            this.btnDeselectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselectAll.Image")));
            this.btnDeselectAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeselectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(36, 36);
            this.btnDeselectAll.Text = "txtDeselectAll";
            this.btnDeselectAll.ToolTipText = "Uncheck all drivers";
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAbout.Size = new System.Drawing.Size(36, 36);
            this.btnAbout.Text = "txtAbout";
            this.btnAbout.ToolTipText = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // PnpGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1238, 867);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(709, 512);
            this.Name = "PnpGuiForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PnpUtil (GUI)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PnpGuiForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PnpGuiForm_FormClosed);
            this.Load += new System.EventHandler(this.PnpGuiForm_Load);
            this.Shown += new System.EventHandler(this.PnpGuiForm_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstDriverStoreEntries)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyObjectListView lstDriverStoreEntries;
        private BrightIdeasSoftware.OLVColumn driverOemInfColumn;
        private BrightIdeasSoftware.OLVColumn driverDateColumn;
        private BrightIdeasSoftware.OLVColumn driverClassColumn;
        private BrightIdeasSoftware.OLVColumn driverSignerColumn;
        private BrightIdeasSoftware.OLVColumn driverVersionColumn;
        private BrightIdeasSoftware.OLVColumn driverProviderColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSelect;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private BrightIdeasSoftware.OLVColumn driverInfColumn;
        private BrightIdeasSoftware.OLVColumn driverSizeColumn;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSelectOldDrivers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewLogsTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.OLVColumn dummyColumn;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private BrightIdeasSoftware.OLVColumn deviceNameColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnInstall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnDeleteForce;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnSelectAll;
        private System.Windows.Forms.ToolStripButton btnSelectOld;
        private System.Windows.Forms.ToolStripButton btnDeselectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnViewLogs;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripButton btnFolderLocation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnRefreshView;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem openFolderLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteForceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem selectAllDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectOldDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllDriversToolStripMenuItem;
    }
}

