
namespace IntegralHashing
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxIdentifier = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxRename = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxRecycle = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPerma = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxCompareList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUnique = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMatched = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartHash = new System.Windows.Forms.Button();
            this.pnlDragDrop1 = new System.Windows.Forms.Panel();
            this.lblDragDrop1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.pnlDragDrop = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lstvOutput = new System.Windows.Forms.ListView();
            this.chCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fbdWorkingPath = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.bgwHashToListView = new System.ComponentModel.BackgroundWorker();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWorkingFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.bgwSha256 = new System.ComponentModel.BackgroundWorker();
            this.bgwSha512 = new System.ComponentModel.BackgroundWorker();
            this.menu.SuspendLayout();
            this.ctxOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDragDrop1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(794, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExport,
            this.toolStripMenuItem4,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuExport
            // 
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(108, 22);
            this.mnuExport.Text = "&Export";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(105, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(108, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSupport,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuSupport
            // 
            this.mnuSupport.Name = "mnuSupport";
            this.mnuSupport.Size = new System.Drawing.Size(116, 22);
            this.mnuSupport.Text = "&Support";
            this.mnuSupport.Click += new System.EventHandler(this.mnuSupport_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // ctxOptions
            // 
            this.ctxOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxIdentifier,
            this.toolStripMenuItem2,
            this.ctxCompareList,
            this.toolStripMenuItem6,
            this.ctxExit});
            this.ctxOptions.Name = "ctxmOptions";
            this.ctxOptions.Size = new System.Drawing.Size(145, 82);
            // 
            // ctxIdentifier
            // 
            this.ctxIdentifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCopy,
            this.toolStripMenuItem1,
            this.ctxRename,
            this.ctxMove,
            this.toolStripMenuItem3,
            this.ctxRecycle,
            this.ctxPerma,
            this.toolStripMenuItem5,
            this.ctxFileLocation});
            this.ctxIdentifier.Name = "ctxIdentifier";
            this.ctxIdentifier.Size = new System.Drawing.Size(144, 22);
            this.ctxIdentifier.Text = "#";
            // 
            // ctxCopy
            // 
            this.ctxCopy.Enabled = false;
            this.ctxCopy.Name = "ctxCopy";
            this.ctxCopy.Size = new System.Drawing.Size(185, 22);
            this.ctxCopy.Text = "Copy Hash";
            this.ctxCopy.Click += new System.EventHandler(this.ctxCopy_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // ctxRename
            // 
            this.ctxRename.Enabled = false;
            this.ctxRename.Name = "ctxRename";
            this.ctxRename.Size = new System.Drawing.Size(185, 22);
            this.ctxRename.Text = "Rename";
            this.ctxRename.Click += new System.EventHandler(this.ctxRename_Click);
            // 
            // ctxMove
            // 
            this.ctxMove.Enabled = false;
            this.ctxMove.Name = "ctxMove";
            this.ctxMove.Size = new System.Drawing.Size(185, 22);
            this.ctxMove.Text = "Move";
            this.ctxMove.Click += new System.EventHandler(this.ctxMove_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 6);
            // 
            // ctxRecycle
            // 
            this.ctxRecycle.Enabled = false;
            this.ctxRecycle.Name = "ctxRecycle";
            this.ctxRecycle.Size = new System.Drawing.Size(185, 22);
            this.ctxRecycle.Text = "Delete (Recycle Bin)";
            this.ctxRecycle.Click += new System.EventHandler(this.ctxRecycle_Click);
            // 
            // ctxPerma
            // 
            this.ctxPerma.Enabled = false;
            this.ctxPerma.Name = "ctxPerma";
            this.ctxPerma.Size = new System.Drawing.Size(185, 22);
            this.ctxPerma.Text = "Delete (Permanently)";
            this.ctxPerma.Click += new System.EventHandler(this.ctxPerma_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(182, 6);
            // 
            // ctxFileLocation
            // 
            this.ctxFileLocation.Name = "ctxFileLocation";
            this.ctxFileLocation.Size = new System.Drawing.Size(185, 22);
            this.ctxFileLocation.Text = "Open file location";
            this.ctxFileLocation.Click += new System.EventHandler(this.ctxFileLocation_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 6);
            // 
            // ctxCompareList
            // 
            this.ctxCompareList.Enabled = false;
            this.ctxCompareList.Name = "ctxCompareList";
            this.ctxCompareList.Size = new System.Drawing.Size(144, 22);
            this.ctxCompareList.Text = "Compare List";
            this.ctxCompareList.Click += new System.EventHandler(this.ctxCompareList_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(141, 6);
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(144, 22);
            this.ctxExit.Text = "Exit";
            this.ctxExit.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblFileCount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblUnique);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblMatched);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnStartHash);
            this.panel2.Controls.Add(this.pnlDragDrop1);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.lblDragDrop);
            this.panel2.Controls.Add(this.pnlDragDrop);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.cmbAlgorithm);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 494);
            this.panel2.TabIndex = 3;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFileCount.Location = new System.Drawing.Point(740, 454);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(0, 13);
            this.lblFileCount.TabIndex = 0;
            this.lblFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(651, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Imported Pair(s):";
            // 
            // lblUnique
            // 
            this.lblUnique.AutoSize = true;
            this.lblUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUnique.Location = new System.Drawing.Point(603, 454);
            this.lblUnique.Name = "lblUnique";
            this.lblUnique.Size = new System.Drawing.Size(0, 13);
            this.lblUnique.TabIndex = 0;
            this.lblUnique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(553, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unique:";
            // 
            // lblMatched
            // 
            this.lblMatched.AutoSize = true;
            this.lblMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMatched.Location = new System.Drawing.Point(505, 454);
            this.lblMatched.Name = "lblMatched";
            this.lblMatched.Size = new System.Drawing.Size(0, 13);
            this.lblMatched.TabIndex = 0;
            this.lblMatched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(459, 454);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Match:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(239, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Deleted";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Red;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(223, 455);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 10);
            this.panel15.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(165, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Recycled";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(149, 455);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 10);
            this.panel13.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(103, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Moved";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(36)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(87, 455);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(28, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Renamed";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 24;
            // 
            // btnStartHash
            // 
            this.btnStartHash.Location = new System.Drawing.Point(440, 77);
            this.btnStartHash.Name = "btnStartHash";
            this.btnStartHash.Size = new System.Drawing.Size(75, 21);
            this.btnStartHash.TabIndex = 21;
            this.btnStartHash.Text = "Start";
            this.btnStartHash.UseVisualStyleBackColor = true;
            this.btnStartHash.Click += new System.EventHandler(this.btnStartHash_Click);
            // 
            // pnlDragDrop1
            // 
            this.pnlDragDrop1.AllowDrop = true;
            this.pnlDragDrop1.BackColor = System.Drawing.Color.Silver;
            this.pnlDragDrop1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDragDrop1.Controls.Add(this.lblDragDrop1);
            this.pnlDragDrop1.Location = new System.Drawing.Point(521, 35);
            this.pnlDragDrop1.Name = "pnlDragDrop1";
            this.pnlDragDrop1.Size = new System.Drawing.Size(270, 63);
            this.pnlDragDrop1.TabIndex = 16;
            this.pnlDragDrop1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragDrop1_DragDrop);
            this.pnlDragDrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragDrop1_DragEnter);
            // 
            // lblDragDrop1
            // 
            this.lblDragDrop1.AutoSize = true;
            this.lblDragDrop1.BackColor = System.Drawing.Color.Silver;
            this.lblDragDrop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragDrop1.ForeColor = System.Drawing.Color.DimGray;
            this.lblDragDrop1.Location = new System.Drawing.Point(75, 14);
            this.lblDragDrop1.Name = "lblDragDrop1";
            this.lblDragDrop1.Size = new System.Drawing.Size(119, 32);
            this.lblDragDrop1.TabIndex = 2;
            this.lblDragDrop1.Text = "Drag and drop file\r\nor click to navigate";
            this.lblDragDrop1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDragDrop1.Click += new System.EventHandler(this.lblDragDrop1_Click);
            this.lblDragDrop1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDragDrop1_DragDrop);
            this.lblDragDrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDragDrop1_DragEnter);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.label4);
            this.panel14.Location = new System.Drawing.Point(521, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(270, 26);
            this.panel14.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Import (optional)";
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.AutoSize = true;
            this.lblDragDrop.BackColor = System.Drawing.Color.Silver;
            this.lblDragDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragDrop.ForeColor = System.Drawing.Color.DimGray;
            this.lblDragDrop.Location = new System.Drawing.Point(61, 50);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(150, 32);
            this.lblDragDrop.TabIndex = 1;
            this.lblDragDrop.Text = "Drag and drop directory\r\nor click to navigate";
            this.lblDragDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDragDrop.Click += new System.EventHandler(this.lblDragDrop_Click);
            this.lblDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDragDrop_DragDrop);
            this.lblDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDragDrop_DragEnter);
            // 
            // pnlDragDrop
            // 
            this.pnlDragDrop.AllowDrop = true;
            this.pnlDragDrop.BackColor = System.Drawing.Color.Silver;
            this.pnlDragDrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDragDrop.Location = new System.Drawing.Point(3, 35);
            this.pnlDragDrop.Name = "pnlDragDrop";
            this.pnlDragDrop.Size = new System.Drawing.Size(270, 63);
            this.pnlDragDrop.TabIndex = 1;
            this.pnlDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragDrop_DragDrop);
            this.pnlDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragDrop_DragEnter);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lstvOutput);
            this.panel7.Location = new System.Drawing.Point(3, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(788, 345);
            this.panel7.TabIndex = 11;
            // 
            // lstvOutput
            // 
            this.lstvOutput.BackColor = System.Drawing.Color.Black;
            this.lstvOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCount,
            this.chFilename,
            this.chFileSize,
            this.chSha});
            this.lstvOutput.ContextMenuStrip = this.ctxOptions;
            this.lstvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvOutput.ForeColor = System.Drawing.Color.Lime;
            this.lstvOutput.FullRowSelect = true;
            this.lstvOutput.HideSelection = false;
            this.lstvOutput.Location = new System.Drawing.Point(0, 0);
            this.lstvOutput.MultiSelect = false;
            this.lstvOutput.Name = "lstvOutput";
            this.lstvOutput.Size = new System.Drawing.Size(788, 345);
            this.lstvOutput.TabIndex = 0;
            this.lstvOutput.UseCompatibleStateImageBehavior = false;
            this.lstvOutput.View = System.Windows.Forms.View.Details;
            this.lstvOutput.SelectedIndexChanged += new System.EventHandler(this.lstvOutput_SelectedIndexChanged);
            // 
            // chCount
            // 
            this.chCount.Text = "#";
            this.chCount.Width = 39;
            // 
            // chFilename
            // 
            this.chFilename.Text = "Filename";
            this.chFilename.Width = 213;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "Size";
            this.chFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chFileSize.Width = 67;
            // 
            // chSha
            // 
            this.chSha.Text = "SHA";
            this.chSha.Width = 459;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(279, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 36);
            this.panel6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select the algorithm needed to generate\r\nhashes on the files within the chosen di" +
    "rectory.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Items.AddRange(new object[] {
            "( ... )",
            "SHA-256",
            "SHA-512"});
            this.cmbAlgorithm.Location = new System.Drawing.Point(279, 77);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(155, 21);
            this.cmbAlgorithm.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(279, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 26);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select Algorithm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 26);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Open Directory";
            // 
            // sfdExport
            // 
            this.sfdExport.RestoreDirectory = true;
            // 
            // bgwHashToListView
            // 
            this.bgwHashToListView.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwHashToListView_DoWork);
            // 
            // ofdImport
            // 
            this.ofdImport.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWorkingFileName,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblWorkingFileName
            // 
            this.lblWorkingFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWorkingFileName.Name = "lblWorkingFileName";
            this.lblWorkingFileName.Size = new System.Drawing.Size(627, 17);
            this.lblWorkingFileName.Spring = true;
            this.lblWorkingFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 16);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // bgwSha256
            // 
            this.bgwSha256.WorkerReportsProgress = true;
            this.bgwSha256.WorkerSupportsCancellation = true;
            this.bgwSha256.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSha256_DoWork);
            this.bgwSha256.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSha256_ProgressChanged);
            this.bgwSha256.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSha256_RunWorkerCompleted);
            // 
            // bgwSha512
            // 
            this.bgwSha512.WorkerReportsProgress = true;
            this.bgwSha512.WorkerSupportsCancellation = true;
            this.bgwSha512.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSha512_DoWork);
            this.bgwSha512.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSha512_ProgressChanged);
            this.bgwSha512.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSha512_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integral Hash";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ctxOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDragDrop1.ResumeLayout(false);
            this.pnlDragDrop1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menu;
        protected System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem mnuExport;
        protected System.Windows.Forms.ToolStripMenuItem mnuExit;
        protected System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem mnuSupport;
        protected System.Windows.Forms.ToolStripMenuItem mnuAbout;
        protected System.Windows.Forms.ContextMenuStrip ctxOptions;
        protected System.Windows.Forms.ToolStripMenuItem ctxIdentifier;
        protected System.Windows.Forms.ToolStripMenuItem ctxCopy;
        protected System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem ctxRename;
        protected System.Windows.Forms.ToolStripMenuItem ctxMove;
        protected System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        protected System.Windows.Forms.ToolStripMenuItem ctxRecycle;
        protected System.Windows.Forms.ToolStripMenuItem ctxPerma;
        protected System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        protected System.Windows.Forms.ToolStripMenuItem ctxExit;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Panel pnlDragDrop;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel6;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.ComboBox cmbAlgorithm;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Panel panel7;
        protected System.Windows.Forms.ListView lstvOutput;
        protected System.Windows.Forms.ColumnHeader chCount;
        protected System.Windows.Forms.ColumnHeader chFilename;
        protected System.Windows.Forms.ColumnHeader chFileSize;
        protected System.Windows.Forms.ColumnHeader chSha;
        protected System.Windows.Forms.FolderBrowserDialog fbdWorkingPath;
        protected System.Windows.Forms.Label lblDragDrop;
        protected System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        protected System.Windows.Forms.SaveFileDialog sfdExport;
        private System.ComponentModel.BackgroundWorker bgwHashToListView;
        private System.Windows.Forms.Panel pnlDragDrop1;
        private System.Windows.Forms.Label lblDragDrop1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.Label lblFileCount;
        protected System.Windows.Forms.Label lblUnique;
        protected System.Windows.Forms.Label lblMatched;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnStartHash;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWorkingFileName;
        private System.ComponentModel.BackgroundWorker bgwSha256;
        private System.ComponentModel.BackgroundWorker bgwSha512;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem ctxFileLocation;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ctxCompareList;
    }
}

