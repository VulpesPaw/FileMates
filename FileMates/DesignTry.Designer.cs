
namespace FileMates
{
    partial class DesignTry
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
            this.originalFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.initialFilesDlg = new System.Windows.Forms.OpenFileDialog();
            this.searchFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbxDstDir = new System.Windows.Forms.GroupBox();
            this.FldFindDestinationBtn = new System.Windows.Forms.Button();
            this.tbxDstFld = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpbxSrchDir = new System.Windows.Forms.GroupBox();
            this.grpbxSelectPaths = new System.Windows.Forms.GroupBox();
            this.tbcOgFld = new System.Windows.Forms.TextBox();
            this.FldFindOriginalBtn = new System.Windows.Forms.Button();
            this.tbxSrchFld = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.FldFindSearchBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grpbxDstDir.SuspendLayout();
            this.grpbxSelectPaths.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialFilesDlg
            // 
            this.initialFilesDlg.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpbxDstDir);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.grpbxSrchDir);
            this.panel1.Controls.Add(this.grpbxSelectPaths);
            this.panel1.Controls.Add(this.tbxSrchFld);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMoveFiles);
            this.panel1.Controls.Add(this.FldFindSearchBtn);
            this.panel1.Location = new System.Drawing.Point(12, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 395);
            this.panel1.TabIndex = 0;
            // 
            // grpbxDstDir
            // 
            this.grpbxDstDir.Controls.Add(this.FldFindDestinationBtn);
            this.grpbxDstDir.Controls.Add(this.tbxDstFld);
            this.grpbxDstDir.Location = new System.Drawing.Point(10, 99);
            this.grpbxDstDir.Name = "grpbxDstDir";
            this.grpbxDstDir.Size = new System.Drawing.Size(597, 89);
            this.grpbxDstDir.TabIndex = 126;
            this.grpbxDstDir.TabStop = false;
            this.grpbxDstDir.Text = "Directory Destinatio ";
            // 
            // FldFindDestinationBtn
            // 
            this.FldFindDestinationBtn.Location = new System.Drawing.Point(6, 19);
            this.FldFindDestinationBtn.Name = "FldFindDestinationBtn";
            this.FldFindDestinationBtn.Size = new System.Drawing.Size(126, 23);
            this.FldFindDestinationBtn.TabIndex = 114;
            this.FldFindDestinationBtn.Text = "DestinationFolder";
            this.FldFindDestinationBtn.UseVisualStyleBackColor = true;
            // 
            // tbxDstFld
            // 
            this.tbxDstFld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDstFld.Location = new System.Drawing.Point(138, 22);
            this.tbxDstFld.Name = "tbxDstFld";
            this.tbxDstFld.Size = new System.Drawing.Size(444, 20);
            this.tbxDstFld.TabIndex = 123;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(637, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(554, 56);
            this.listBox1.TabIndex = 0;
            // 
            // grpbxSrchDir
            // 
            this.grpbxSrchDir.Location = new System.Drawing.Point(613, 4);
            this.grpbxSrchDir.Name = "grpbxSrchDir";
            this.grpbxSrchDir.Size = new System.Drawing.Size(597, 89);
            this.grpbxSrchDir.TabIndex = 125;
            this.grpbxSrchDir.TabStop = false;
            this.grpbxSrchDir.Text = "Search Directories";
            // 
            // grpbxSelectPaths
            // 
            this.grpbxSelectPaths.Controls.Add(this.tbcOgFld);
            this.grpbxSelectPaths.Controls.Add(this.FldFindOriginalBtn);
            this.grpbxSelectPaths.Location = new System.Drawing.Point(10, 4);
            this.grpbxSelectPaths.Name = "grpbxSelectPaths";
            this.grpbxSelectPaths.Size = new System.Drawing.Size(597, 89);
            this.grpbxSelectPaths.TabIndex = 124;
            this.grpbxSelectPaths.TabStop = false;
            this.grpbxSelectPaths.Text = "Select Directories";
            // 
            // tbcOgFld
            // 
            this.tbcOgFld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcOgFld.Location = new System.Drawing.Point(138, 21);
            this.tbcOgFld.Name = "tbcOgFld";
            this.tbcOgFld.Size = new System.Drawing.Size(444, 20);
            this.tbcOgFld.TabIndex = 123;
            // 
            // FldFindOriginalBtn
            // 
            this.FldFindOriginalBtn.Location = new System.Drawing.Point(6, 19);
            this.FldFindOriginalBtn.Name = "FldFindOriginalBtn";
            this.FldFindOriginalBtn.Size = new System.Drawing.Size(126, 23);
            this.FldFindOriginalBtn.TabIndex = 113;
            this.FldFindOriginalBtn.Text = "Add Directory Search";
            this.FldFindOriginalBtn.UseVisualStyleBackColor = true;
            // 
            // tbxSrchFld
            // 
            this.tbxSrchFld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSrchFld.Location = new System.Drawing.Point(750, 310);
            this.tbxSrchFld.Name = "tbxSrchFld";
            this.tbxSrchFld.Size = new System.Drawing.Size(427, 20);
            this.tbxSrchFld.TabIndex = 123;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(897, 248);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 26);
            this.lblTitle.TabIndex = 119;
            this.lblTitle.Text = "FileMates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1045, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "!! Change lbl path to tbxPaths";
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Location = new System.Drawing.Point(750, 252);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFiles.TabIndex = 116;
            this.btnMoveFiles.Text = "Move Files";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            // 
            // FldFindSearchBtn
            // 
            this.FldFindSearchBtn.Location = new System.Drawing.Point(637, 308);
            this.FldFindSearchBtn.Name = "FldFindSearchBtn";
            this.FldFindSearchBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindSearchBtn.TabIndex = 115;
            this.FldFindSearchBtn.Text = "SearchFolder";
            this.FldFindSearchBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 243);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(211, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 243);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(613, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 89);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duplicate Files";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // DesignTry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 668);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DesignTry";
            this.Text = "DesignTry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesignTry_FormClosing);
            this.Load += new System.EventHandler(this.DesignTry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpbxDstDir.ResumeLayout(false);
            this.grpbxDstDir.PerformLayout();
            this.grpbxSelectPaths.ResumeLayout(false);
            this.grpbxSelectPaths.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog originalFolderDlg;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderDlg;
        private System.Windows.Forms.OpenFileDialog initialFilesDlg;
        private System.Windows.Forms.FolderBrowserDialog searchFolderDlg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FldFindDestinationBtn;
        private System.Windows.Forms.Button FldFindOriginalBtn;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button FldFindSearchBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxDstFld;
        private System.Windows.Forms.TextBox tbxSrchFld;
        private System.Windows.Forms.TextBox tbcOgFld;
        private System.Windows.Forms.GroupBox grpbxSelectPaths;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpbxSrchDir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox grpbxDstDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}