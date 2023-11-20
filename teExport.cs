using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IntegralHashing
{
    public class teExport
    {
        /// <summary>
        /// Create excel objects for exporting data to a worksheet
        /// </summary>
        readonly Microsoft.Office.Interop.Excel.Application exp = new Microsoft.Office.Interop.Excel.Application();
        
        // Workbook/Worksheet
        Workbook ewb;
        Worksheet ews;

        /// <summary>
        /// Open workbook for exporting
        /// </summary>
        public void OpenExcelWorksSheet()
        {            
            exp.Visible = false;
            ewb = exp.Workbooks.Add(1);
            ews = (Worksheet)ewb.Worksheets[1];
        }

        /// <summary>
        /// Write to excel cells
        /// </summary>
        public void ExportHashColumnsCells(int row, int column, ListView lstvOutput)
        {
            // Write Columns to Cells
            foreach (ColumnHeader c in lstvOutput.Columns)
            {
                // Write to Cells
                ews.Cells[row, column] = c.Text;
                column++;
            }

            // Reinitialize column
            column = 1;

            try
            {
                // Write Data to Cells
                foreach (ListViewItem i in lstvOutput.Items)
            {
                row++;
                ews.Cells[row, column] = i.Text;
                ews.Cells[row, column + 1] = i.SubItems[1].Text;
                ews.Cells[row, column + 2] = i.SubItems[2].Text;
                ews.Cells[row, column + 3] = i.SubItems[3].Text;
            }
            }
            catch (ArgumentOutOfRangeException rngex)
            {
                /// <summary>
                /// Ignore rngex, error implies hashes have not been generated
                /// throws range exception, warn user to generate hashes first.
                /// </summary>
                MessageBox.Show("Please generate hashes first before exporting list.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // Autofit Columns
            ews.Cells.EntireColumn.AutoFit();
        }

        /// <summary>                        
        /// Check if file already exists            
        /// Save file, close stream, quit app
        /// </summary>             
        public void SaveExcelWorkbook(string filepath)
        {            
            // Null parameter
            object mV = System.Reflection.Missing.Value;

            ewb.SaveAs(filepath, XlFileFormat.xlOpenXMLWorkbook, mV, mV, mV, mV, XlSaveAsAccessMode.xlNoChange, mV, mV, mV, mV, mV);
            ewb.Close();
            exp.Quit();
        }

        /// <summary>
        /// Retrieves listview data then returns the built string for saving
        /// </summary>        
        public StringBuilder ExportText(ListView lstvOutput)
        {
            StringBuilder build = new StringBuilder();

            foreach (ListViewItem i in lstvOutput.Items)
            {
                build.Append(string.Format($"{i.SubItems[1].Text},{i.SubItems[3].Text}{Environment.NewLine}"));
            }

            // Return built string
            return build;
        }
        public void SaveFileDocument(string filename, StringBuilder built)
        {
            // Save to text document
            File.WriteAllText(filename, built.ToString());     
        }
    }
}