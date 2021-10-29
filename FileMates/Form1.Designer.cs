
namespace FileMates
{
    partial class Form1
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
            if(disposing && (components != null))
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.FldFindOriginalBtn = new System.Windows.Forms.Button();
            this.lbldsFldPath = new System.Windows.Forms.Label();
            this.FldFindDestinationBtn = new System.Windows.Forms.Button();
            this.lblsrchFldPath = new System.Windows.Forms.Label();
            this.FldFindSearchBtn = new System.Windows.Forms.Button();
            this.lblogFldPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialFilesDlg
            // 
            this.initialFilesDlg.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1347, 546);
            this.splitContainer1.SplitterDistance = 449;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.FldFindOriginalBtn);
            this.splitContainer2.Panel1.Controls.Add(this.lbldsFldPath);
            this.splitContainer2.Panel1.Controls.Add(this.FldFindDestinationBtn);
            this.splitContainer2.Panel1.Controls.Add(this.lblsrchFldPath);
            this.splitContainer2.Panel1.Controls.Add(this.FldFindSearchBtn);
            this.splitContainer2.Panel1.Controls.Add(this.lblogFldPath);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnMoveFiles);
            this.splitContainer2.Size = new System.Drawing.Size(894, 546);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Location = new System.Drawing.Point(386, 60);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFiles.TabIndex = 106;
            this.btnMoveFiles.Text = "Move Files";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // FldFindOriginalBtn
            // 
            this.FldFindOriginalBtn.Location = new System.Drawing.Point(308, 109);
            this.FldFindOriginalBtn.Name = "FldFindOriginalBtn";
            this.FldFindOriginalBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindOriginalBtn.TabIndex = 97;
            this.FldFindOriginalBtn.Text = "OriginalFolder";
            this.FldFindOriginalBtn.UseVisualStyleBackColor = true;
            this.FldFindOriginalBtn.Click += new System.EventHandler(this.FldFindOriginalBtn_Click);
            // 
            // lbldsFldPath
            // 
            this.lbldsFldPath.AutoSize = true;
            this.lbldsFldPath.Location = new System.Drawing.Point(559, 172);
            this.lbldsFldPath.Name = "lbldsFldPath";
            this.lbldsFldPath.Size = new System.Drawing.Size(28, 13);
            this.lbldsFldPath.TabIndex = 103;
            this.lbldsFldPath.Text = "path";
            // 
            // FldFindDestinationBtn
            // 
            this.FldFindDestinationBtn.Location = new System.Drawing.Point(308, 167);
            this.FldFindDestinationBtn.Name = "FldFindDestinationBtn";
            this.FldFindDestinationBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindDestinationBtn.TabIndex = 98;
            this.FldFindDestinationBtn.Text = "DestinationFolder";
            this.FldFindDestinationBtn.UseVisualStyleBackColor = true;
            this.FldFindDestinationBtn.Click += new System.EventHandler(this.FldFindDestinationBtn_Click);
            // 
            // lblsrchFldPath
            // 
            this.lblsrchFldPath.AutoSize = true;
            this.lblsrchFldPath.Location = new System.Drawing.Point(559, 143);
            this.lblsrchFldPath.Name = "lblsrchFldPath";
            this.lblsrchFldPath.Size = new System.Drawing.Size(28, 13);
            this.lblsrchFldPath.TabIndex = 104;
            this.lblsrchFldPath.Text = "path";
            // 
            // FldFindSearchBtn
            // 
            this.FldFindSearchBtn.Location = new System.Drawing.Point(308, 138);
            this.FldFindSearchBtn.Name = "FldFindSearchBtn";
            this.FldFindSearchBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindSearchBtn.TabIndex = 99;
            this.FldFindSearchBtn.Text = "SearchFolder";
            this.FldFindSearchBtn.UseVisualStyleBackColor = true;
            this.FldFindSearchBtn.Click += new System.EventHandler(this.FldFindSearchBtn_Click);
            // 
            // lblogFldPath
            // 
            this.lblogFldPath.AutoSize = true;
            this.lblogFldPath.Location = new System.Drawing.Point(559, 114);
            this.lblogFldPath.Name = "lblogFldPath";
            this.lblogFldPath.Size = new System.Drawing.Size(28, 13);
            this.lblogFldPath.TabIndex = 105;
            this.lblogFldPath.Text = "path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Original FolderPath:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Destination FolderPath:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Search FolderPath:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 546);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "FileMates";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog originalFolderDlg;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderDlg;
        private System.Windows.Forms.OpenFileDialog initialFilesDlg;
        private System.Windows.Forms.FolderBrowserDialog searchFolderDlg;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button FldFindOriginalBtn;
        private System.Windows.Forms.Label lbldsFldPath;
        private System.Windows.Forms.Button FldFindDestinationBtn;
        private System.Windows.Forms.Label lblsrchFldPath;
        private System.Windows.Forms.Button FldFindSearchBtn;
        private System.Windows.Forms.Label lblogFldPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoveFiles;
    }
}

