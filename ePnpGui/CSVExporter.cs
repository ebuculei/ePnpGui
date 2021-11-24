﻿using System.Collections.Generic;
using System.IO;

using ePnpGui.Utils;
using System.Windows.Forms;
using ePnpGui.Lang;

namespace ePnpGui
{
    public class CsvExporter : IExport
    {
        private const string CsvDelimiter = ",";
        private const string CsvQuote = "\"";

        public string Export(List<DriverStoreEntry> driverStoreEntries)
        {
            if (driverStoreEntries.Count == 0)
            {
                MessageBox.Show(Language.Message_No_Entries, Language.Export_Error);
                return null;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                CheckFileExists = false,
                DefaultExt = "csv",
                Filter = Language.Dialog_Export_Filters,
                SupportMultiDottedExtensions = true
            };

            saveFileDialog.FileName = "DriverList";
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string csvFileName = saveFileDialog.FileName;   // Path                

                using (StreamWriter file = new StreamWriter(csvFileName))
                {
                    // Write the header once
                    string headerLine = string.Join(CsvDelimiter, DriverStoreEntry.GetFieldNames());
                    file.WriteLine(headerLine);

                    // Write the values
                    foreach (DriverStoreEntry entry in driverStoreEntries)
                    {
                        string valueLine = string.Join(CsvDelimiter, Sanitize(entry.GetFieldValues()));
                        file.WriteLine(valueLine);
                    }
                }

                return csvFileName;
            }

            return null;
        }

        private static string[] Sanitize(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Contains(CsvDelimiter)
                    || values[i].Contains(CsvQuote))
                {
                    values[i] = CsvQuote + values[i].Replace(CsvQuote, "\\\"") + CsvQuote;
                }
            }

            return values;
        }
    }
}
