using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;

namespace IntegralHashing
{
    /// <summary>
    /// Author: Branden Prins
    /// Date: 12:31 AM 6/30/2021
    /// Course: 21/SU-COP-2939-53251
    /// Program: Computer Programming Capstone
    /// 
    /// Integral Hashing is a hash generator that is intended to
    /// focus on two algorithms, SHA-256 and SHA-512. The purpose
    /// behind these two algorithms is the absence of collision
    /// present today. Although, no avoidable, there are no known
    /// collisions with SHA-256 or SHA-512. Additionally the
    /// program allows users to create hashlists as well as
    /// compare the generated hash. The advantage of Integral
    /// Hashing is like most open-source programs, it is
    /// free-to-use and the features it offers may be of a
    /// convenience to others.Users can generate hash lists from
    /// any directory, so long as a directory has file contents
    /// and data within each file.A unique hash will be generated
    /// and users can export this data to a spreadsheet, or textfile
    /// as well as compare hashes from a pregenerated, preformatted
    /// hash list.    
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Store dictionary for comparing files and hashes later
        /// </summary>
        StringStorage storage = new StringStorage();
        DirectoryInfo dinfo;
        ListViewItem lvi;
        FileInfo[] finfo;

        /// <summary>
        /// Helps to calculator the progress from the stream during the hashing process.
        /// </summary>
        byte[] buffer;
        int bytesRead;
        long size;
        long tBytesRead = 0;

        public frmMain()
        {
            InitializeComponent();            
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            // Configure SFD
            sfdExport = new SaveFileDialog()
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx|Text (MS-DOS) (*.txt)|*.txt",
                FilterIndex = 1,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true
            };

            // Make dialog, child to frmMain
            if (sfdExport.ShowDialog() == DialogResult.OK)
            {
                // Call Export Class
                teExport tee = new teExport();

                try
                {

                    // Check Extension
                    switch (Path.GetExtension(sfdExport.FileName).ToLower())
                    {
                        // If Excel
                        case ".xlsx":
                            // Set row/column
                            int row = 1, column = 1;

                            /// <summary>
                            /// Open Worksheet, Export Data, Save Workbook, Close Application
                            /// </summary>
                            tee.OpenExcelWorksSheet();
                            tee.ExportHashColumnsCells(row, column, lstvOutput);
                            if (!File.Exists(sfdExport.FileName))
                            {
                                tee.SaveExcelWorkbook(sfdExport.FileName);
                            }
                            else
                                tee.SaveExcelWorkbook(sfdExport.FileName);
                            break;
                        case ".txt":

                            /// <summary>
                            /// Save Text Document
                            /// </summary>
                            if (!File.Exists(sfdExport.FileName))
                            {
                                tee.SaveFileDocument(sfdExport.FileName, tee.ExportText(lstvOutput));
                            }
                            else
                                tee.SaveFileDocument(sfdExport.FileName, tee.ExportText(lstvOutput));
                            break;
                        default:
                            // Throw if filetype not supported
                            throw new ArgumentOutOfRangeException(Path.GetExtension(sfdExport.FileName).ToLower());
                    }
                }
                catch (Exception ioe)
                {                    
                    MessageBox.Show("File not saved", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Re-useable between controls, cleans things up
        /// </summary>   
        public void ResetControls()
        {
            // Clear listview items
            lstvOutput.Items.Clear();
            storage.absolute.Clear();
            storage.hashed.Clear();

            // Disable context menu options
            ctxCopy.Enabled = false;
            ctxRename.Enabled = false;
            ctxMove.Enabled = false;
            ctxRecycle.Enabled = false;
            ctxPerma.Enabled = false;
            ctxCompareList.Enabled = false;
            
            // Enable Start
            btnStartHash.Enabled = true;

            // Labels
            lblMatched.Text = string.Empty;
            lblUnique.Text = string.Empty;
        }

        /// <summary>
        /// Get folder contents from drag and drop
        /// </summary>    
        private void lblDragDrop_Click(object sender, EventArgs e)
        {
            ResetControls();

            if (fbdWorkingPath.ShowDialog() == DialogResult.OK)
            {
                int count = 1;
                GetFolderContents(count, fbdWorkingPath.SelectedPath);
            }
        }


        /// <summary>
        /// Get folder contents
        /// </summary>    
        public void GetFolderContents(int count, string path)
        {
            storage.directory = path;
            dinfo = new DirectoryInfo(storage.directory);
            finfo = dinfo.GetFiles();            
            lstvOutput.SuspendLayout();
            foreach (FileInfo f in finfo)
            {
                storage.absolute.Add(f.FullName);

                lvi = lstvOutput.Items.Add((count++).ToString());
                lvi.ForeColor = Color.Cyan;

                lvi.UseItemStyleForSubItems = false;
                lvi.SubItems.Add(f.Name);
                lvi.SubItems.Add(GetFileSize(f.Length));
                lvi.SubItems[2].ForeColor = Color.Magenta;
            }
            lstvOutput.ResumeLayout();
        }

        private void pnlDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            /// <summary>
            /// Allow drop for label when entering panel on drag and drop, this prevent clicking
            /// the label for folder browser dialog.
            /// </summary>
            lblDragDrop.AllowDrop = true;

            /// <summary>
            /// This will determine if the drag source will be copied or ignored
            /// upon entry.
            /// </summary>
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnlDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            ResetControls();

            /// <summary>
            /// Disable drop for label when drop complete, this allows clicking
            /// the label for folder browser dialog.
            /// </summary>
            lblDragDrop.AllowDrop = false;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                /// <summary>
                /// When a folder is dropped, GetData will determine if one or more folders are dropped
                /// After the directory check returns true, textbox retrieves the folder path 
                /// </summary>
                string[] fldr = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Directory.Exists(fldr[0]))
                {
                    /// <summary>
                    /// Clear items before dumping files and info
                    /// </summary>
                    lstvOutput.Items.Clear();
                    int count = 1;
                    GetFolderContents(count, fldr[0]);
                }
            }

            
        }
        private void lblDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            /// <summary>
            /// This will determine if the drag source will be copied or ignored
            /// upon entry.
            /// </summary>
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                /// <summary>
                /// When a folder is dropped, GetData will determine if one or more folders are dropped
                /// After the directory check returns true, textbox retrieves the folder path 
                /// </summary>
                string[] fldr = (string[])e.Data.GetData(DataFormats.FileDrop);

                /// <summary>
                /// Clear items before dumping files and info
                /// </summary>
                lstvOutput.Items.Clear();
                if (Directory.Exists(fldr[0]))
                {
                    storage.directory = fldr[0];
                    bgwHashToListView.RunWorkerAsync();
                }
            }
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {            
            this.Close(); // Terminate the application
        }
              
        public string GetFileSize(double length)
        {
            /// <summary>
            /// This will determine the file size for each file being processed
            /// Highest support measurement Terabyte
            /// Anything less than 1 KB will report as KB
            /// </summary>  
            string format = string.Empty;
            if (length < 1024f)
                format = "1 KB";

            if (length > 1024f && length <= Math.Pow(1024f, 2))
                format = $"{Math.Round(length / 1024.0)} KB";

            if (length > Math.Pow(1024f, 2) && length <= Math.Pow(1024f, 3))
                format = $"{Math.Round(length / Math.Pow(1024, 2))} MB";

            if (length > Math.Pow(1024f, 3) && length <= Math.Pow(1024f, 4))
                format = $"{Math.Round(length / Math.Pow(1024, 3))} GB";

            if (length > Math.Pow(1024f, 4) && length <= Math.Pow(1024f, 5))
                format = $"{Math.Round(length / Math.Pow(1024, 4))} TB";

            return format;
        }

        /// <summary>
        /// Use label as click option to open file browser dialog
        /// </summary>        
        private void lblDragDrop1_Click(object sender, EventArgs e)
        {
            ofdImport = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true,
                FilterIndex = 1,
                Filter = "Text (MS-DOS) (*.txt)|*.txt"
            };
            if (ofdImport.ShowDialog() == DialogResult.OK)
            {
                TextImport(ofdImport.FileName);
            }
            
        }

        private void lblDragDrop1_DragEnter(object sender, DragEventArgs e)
        {
            /// <summary>
            /// This will determine if the drag source will be copied or ignored
            /// upon entry.
            /// </summary>
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblDragDrop1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                /// <summary>
                /// When a folder is dropped, GetData will determine if one or more folders are dropped
                /// After the directory check returns true, textbox retrieves the folder path 
                /// </summary>
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (File.Exists(file[0]))
                {
                    /// <summary>
                    /// Open file dialog never opens, update name
                    /// </summary>
                    TextImport(file[0]);
                }                
            }
        }

        public void TextImport(string filename)
        {
            /// <summary>
            /// conver all lines in file to array, then clean array
            /// before dictionary conversion
            /// </summary>
            string[] hashes = File.ReadAllText(filename).Replace("\r", string.Empty).Split('\n');
            hashes = hashes.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            // Initialize new keyvalue storage
            storage.keyVal = new Dictionary<string, string>();

            // split arrays at ',' then store key+value
            foreach (string h in hashes)
            {
                var splt = h.Split(',');
                if (!string.IsNullOrEmpty(splt[0]) && !string.IsNullOrEmpty(splt[1]))
                {
                    // Do not store if already exists
                    if (!storage.keyVal.ContainsKey(splt[0]))
                    {
                        storage.keyVal.Add(splt[0], splt[1]);
                    }
                }
            }

            /// <summary>
            /// File and hash count, in event that a key is missing a value
            /// </summary>
            lblFileCount.Text = storage.keyVal.Keys.Count.ToString();

            if (storage.hashed.Count != 0)
            {
                ctxCompareList.Enabled = true;
            }
        }

        private void pnlDragDrop1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                /// <summary>
                /// When a folder is dropped, GetData will determine if one or more folders are dropped
                /// After the directory check returns true, textbox retrieves the folder path 
                /// </summary>
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (File.Exists(file[0]))
                {
                    /// <summary>
                    /// Open file dialog never opens, update name
                    /// </summary>
                    TextImport(file[0]);
                }
            }
        }

        private void pnlDragDrop1_DragEnter(object sender, DragEventArgs e)
        {
            /// <summary>
            /// This will determine if the drag source will be copied or ignored
            /// upon entry.
            /// </summary>
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Convert byte array to human readable format using linq then return.
        /// </summary>        
        public string ByteToStringConversion(byte[] bytes)
        {
            StringBuilder r = new StringBuilder();
            foreach (byte b in bytes)
            {
                r.Append(b.ToString("x2"));
            }
            return r.ToString();
        }

        private void btnStartHash_Click(object sender, EventArgs e)
        {       
            
            // Run one of two threads.
            switch(cmbAlgorithm.SelectedIndex)
            {
                case 1:
                    bgwSha256.RunWorkerAsync();
                    break;
                case 2:
                    bgwSha512.RunWorkerAsync();
                    break;
            }

            // Enable context menu items for editing.
            EnableContextMenuItems();
        }


        // Function to enable necessary context menu items
        public void EnableContextMenuItems()
        {
            ctxCopy.Enabled = true;
            ctxRename.Enabled = true;
            ctxMove.Enabled = true;
            ctxRecycle.Enabled = true;
            ctxPerma.Enabled = true;
            ctxFileLocation.Enabled = true;
        }

        /// <summary>
        ///  Background worker for SHA256
        /// </summary>        
        private void bgwSha256_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            storage.hashed.Clear(); // Cleared stored hashes, helps with drawing correct values in listview

            for (int count = 0; count < storage.absolute.Count; count++)
            {                
                lblWorkingFileName.Text = storage.absolute[count];

                if (File.Exists(storage.absolute[count]))
                {
                    size = new FileInfo(storage.absolute[count]).Length; // Report progress of hashing process through the file size.

                    // Prevents streaming files with zero data
                    if (size != 0)
                    {
                        using (FileStream fStream = File.OpenRead(storage.absolute[count]))
                        {
                            using (SHA256 s256 = SHA256.Create())
                            {
                                do
                                {
                                    // Only used for progress
                                    buffer = new byte[4096];
                                    bytesRead = fStream.Read(buffer, 0, buffer.Length);
                                    tBytesRead += bytesRead;
                                    s256.TransformBlock(buffer, 0, bytesRead, null, 0);
                                    bgwSha256.ReportProgress((int)(((double)tBytesRead / size) * 100));
                                } while (bytesRead != 0);

                                // Reset progress
                                tBytesRead = 0;

                                // Convert string add to storage
                                storage.hashed.Add(ByteToStringConversion(s256.ComputeHash(fStream)));
                            }
                        }                       
                    }
                    else
                        // Add no data if hash missing or no data within file, prevents exception
                        storage.hashed.Add("(no data)");
                }
            }
            
            // Run background worker
            bgwHashToListView.RunWorkerAsync();
        }

        private void bgwSha256_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            // Update value of progress bar
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bgwSha256_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("SHA-256 Hashing Complete!", "Hashing Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
            lblWorkingFileName.Text = string.Empty;
        }

        /// <summary>
        ///  Background worker for SHA512
        /// </summary>
        private void bgwSha512_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            storage.hashed.Clear(); // Cleared stored hashes, helps with drawing correct values in listview
            for (int count = 0; count < storage.absolute.Count; count++)
            {                
                lblWorkingFileName.Text = storage.absolute[count];

                if (File.Exists(storage.absolute[count]))
                {
                    size = new FileInfo(storage.absolute[count]).Length; // Report progress of hashing process through the file size.

                    // Files MUST have data in order for hash to be created successfully!
                    if (size != 0)
                    {
                        using (FileStream fStream = File.OpenRead(storage.absolute[count]))
                        {
                            using (SHA512 s512 = SHA512.Create())
                            {
                                do
                                {
                                    // Only used for progress
                                    buffer = new byte[4096];
                                    bytesRead = fStream.Read(buffer, 0, buffer.Length);
                                    tBytesRead += bytesRead;
                                    s512.TransformBlock(buffer, 0, bytesRead, null, 0);                                                                        
                                    bgwSha512.ReportProgress((int)(((double)tBytesRead / size) * 100));
                                } while (bytesRead != 0);

                                // Reset progress
                                tBytesRead = 0;
                                
                                // Convert string add to storage
                                storage.hashed.Add(ByteToStringConversion(s512.ComputeHash(fStream)));
                            }
                        }                       
                    }
                    else
                        // Add no data if hash missing or no data within file, prevents exception
                        storage.hashed.Add("(no data)");
                }
              
            }

            // Run background worker
            bgwHashToListView.RunWorkerAsync();
        }

        private void bgwSha512_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {            
            progressBar1.Value = e.ProgressPercentage; // Update value of progress bar
        }

        private void bgwSha512_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("SHA-512 Hashing Complete!", "Hashing Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
            lblWorkingFileName.Text = string.Empty;
        }

        private void bgwHashToListView_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            /// <summary>
            /// Invoke ot new thread, avoid cross-thread exception
            /// </summary>
            if (lstvOutput.InvokeRequired)
            {
                lstvOutput.Invoke((MethodInvoker)delegate ()
                {
                    // Probably pointless to use
                    lstvOutput.SuspendLayout();
                    int count = 0;
                    foreach (ListViewItem i in lstvOutput.Items)
                    {
                        /// <summary>
                        /// Checks if listview already contains subitems to update
                        /// values with different checksum
                        /// </summary>
                        if (i.SubItems.Count != lstvOutput.Columns.Count)
                        {
                            i.SubItems.Add(storage.hashed[count]);                            
                            i.SubItems[3].ForeColor = Color.Yellow;
                            count++;
                        }
                        else
                        {
                            i.SubItems[3].Text = storage.hashed[count];
                            i.SubItems[3].ForeColor = Color.Yellow;
                            count++;
                        }
                    }

                    // Probably pointless to use
                    lstvOutput.ResumeLayout();
                });
            }
        }

        private void lstvOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctxIdentifier.Text = $"ID: {lstvOutput.SelectedItems[0].Text}";
            }
            /// <summary>
            /// Nullify exception, ArgumentOutOfRangeException thrown if index selected but right click elsewhere.
            /// Nullifying exception does not break, instead, right clicking will change the selected index providing context
            /// </summary>
            catch { }
            
        }

        private void ctxExit_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Prompt Exit if list view contains items
            /// </summary>
            if (lstvOutput.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?","Exit Application",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                // Exit if no items
                this.Close();
        }

        private void ctxCopy_Click(object sender, EventArgs e)
        {               
            // Copy selected hash text from 4th column, to clipboard.
            Clipboard.SetText(lstvOutput.SelectedItems[0].SubItems[3].Text);
        }

        private void ctxRename_Click(object sender, EventArgs e)
        {            
            try
            {
                /// <summary>
                /// This will convert the select index form listview to identify the respect absolute path in the array
                /// Then once the method is complete, the value is color coded to easier identify changes from the results
                /// </summary>
                if (Int32.TryParse(lstvOutput.SelectedItems[0].Text, out int index))
                {   
                    lstvOutput.SelectedItems[0].SubItems[1].Text = $"{RenameMoveFile(index, "")}";
                    lstvOutput.SelectedItems[0].SubItems[1].ForeColor = Color.White;
                }
            }
            catch (IOException fex)
            {
                MessageBox.Show($"{fex.Message}");
            }
        }

        private void ctxMove_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// This will convert the select index form listview to identify the respect absolute path in the array
                /// Then once the method is complete, the value is color coded to easier identify changes from the results
                /// </summary>
                if (Int32.TryParse(lstvOutput.SelectedItems[0].Text, out int index))
                {
                    fbdWorkingPath.ShowDialog();
                    RenameMoveFile(index, fbdWorkingPath.SelectedPath);
                    lstvOutput.SelectedItems[0].SubItems[1].ForeColor = Color.FromArgb(0, 255, 130, 36);
                }

            }
            catch (IOException fex)
            {
                MessageBox.Show($"{fex.Message}");
            }
        }

        public string RenameMoveFile(int index, string newpath)
        {
            /// <summary>
            /// Break absolute path apart and re-assign as needed
            /// </summary>
            string directory = Path.GetDirectoryName($"{storage.absolute[index - 1]}");
            string filename = Path.GetFileNameWithoutExtension($"{ storage.absolute[index - 1]}");
            string extension = Path.GetExtension($"{storage.absolute[index - 1]}");
            string nFilename = string.Empty;

            if (!string.IsNullOrEmpty(newpath))
            {
                /// <summary>
                /// Moves the file to a different directory
                /// </summary>
                File.Move($"{storage.absolute[index - 1]}", $"{newpath}\\{filename}{extension}");
                storage.absolute[index - 1] = $"{newpath}\\{filename}{extension}";
            }
            else
            {
                /// <summary>
                /// Renames the file in the given directory
                /// </summary>
                nFilename = Interaction.InputBox("Filename: ", "Rename File", $"{lstvOutput.SelectedItems[0].SubItems[1].Text}");
                File.Move($"{storage.absolute[index - 1]}", $"{directory}\\{nFilename}{extension}");
                storage.absolute[index - 1] = $"{directory}\\{nFilename}{extension}";
            }

            // Return filename to update listview
            return $"{nFilename}{extension}";
        }

        private void ctxFileLocation_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(lstvOutput.SelectedItems[0].Text, out int index))
            {                
                /// <summary>
                /// Assigns a parameter with the given path, open and selects the file within explorer.
                /// </summary>
                string parameter = $"/select,{storage.absolute[index - 1]}";
                Process.Start("explorer.exe", parameter);
            }
        }

        private void ctxRecycle_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(lstvOutput.SelectedItems[0].Text, out int index))
            {
                FileSystem.DeleteFile($"{storage.absolute[index - 1]}", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin,Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException);                
                lstvOutput.SelectedItems[0].SubItems[1].ForeColor = Color.FromArgb(0, 58, 58, 58);
            }

            // Prevents rehashing in case files not present, results in program crashing
            btnStartHash.Enabled = false;
        }

        private void ctxPerma_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(lstvOutput.SelectedItems[0].Text, out int index))
            {
                FileSystem.DeleteFile($"{storage.absolute[index - 1]}", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException);
                lstvOutput.SelectedItems[0].SubItems[1].ForeColor = Color.Red;
            }

            // Prevents rehashing in case files not present, results in program crashing
            btnStartHash.Enabled = false;
        }

        private void ctxCompareList_Click(object sender, EventArgs e)
        {
            // Creates new instance for storing and counting compared later
            storage.matched = new Dictionary<string, string>();
            storage.unique = new Dictionary<string, string>();

            // For each subitem in output check if dictionary contains the item
            foreach (ListViewItem i in lstvOutput.Items)
            {
                if (storage.keyVal.ContainsValue(i.SubItems[3].Text))
                {
                    // Color pale Green if found
                    i.SubItems[3].ForeColor = Color.FromArgb(0, 128, 255, 128);
                    storage.matched.Add(i.SubItems[1].Text, i.SubItems[3].Text);
                }
                else
                {
                    // Color pale Red if missing
                    i.SubItems[3].ForeColor = Color.FromArgb(0, 255, 192, 192);
                    storage.unique.Add(i.SubItems[1].Text, i.SubItems[3].Text);
                }
            }

            // Update labels with count on matching and unique
            lblMatched.Text = $"{storage.matched.Keys.Count}";
            lblUnique.Text = $"{storage.unique.Keys.Count}";
        }

        // UserManual private, unchanged
        private const string chmFileName = "UserManual.chm";

        private void mnuSupport_Click(object sender, EventArgs e)
        {
            // Show help when support clicked
            Help.ShowHelp(this, Application.StartupPath + $"\\Resources\\{chmFileName}");
        }
    }
}