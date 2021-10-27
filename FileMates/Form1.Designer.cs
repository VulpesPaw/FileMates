
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.originalFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.initialFilesDlg = new System.Windows.Forms.OpenFileDialog();
            this.searchFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.FldFindOriginalBtn = new System.Windows.Forms.Button();
            this.lbldsFldPath = new System.Windows.Forms.Label();
            this.FldFindDestinationBtn = new System.Windows.Forms.Button();
            this.lblsrchFldPath = new System.Windows.Forms.Label();
            this.FldFindSearchBtn = new System.Windows.Forms.Button();
            this.lblogFldPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // initialFilesDlg
            // 
            this.initialFilesDlg.FileName = "openFileDialog1";
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Location = new System.Drawing.Point(1185, 230);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFiles.TabIndex = 77;
            this.btnMoveFiles.Text = "Move Files";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // FldFindOriginalBtn
            // 
            this.FldFindOriginalBtn.Location = new System.Drawing.Point(959, 107);
            this.FldFindOriginalBtn.Name = "FldFindOriginalBtn";
            this.FldFindOriginalBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindOriginalBtn.TabIndex = 68;
            this.FldFindOriginalBtn.Text = "OriginalFolder";
            this.FldFindOriginalBtn.UseVisualStyleBackColor = true;
            this.FldFindOriginalBtn.Click += new System.EventHandler(this.FldFindOriginalBtn_Click);
            // 
            // lbldsFldPath
            // 
            this.lbldsFldPath.AutoSize = true;
            this.lbldsFldPath.Location = new System.Drawing.Point(1210, 170);
            this.lbldsFldPath.Name = "lbldsFldPath";
            this.lbldsFldPath.Size = new System.Drawing.Size(28, 13);
            this.lbldsFldPath.TabIndex = 74;
            this.lbldsFldPath.Text = "path";
            // 
            // FldFindDestinationBtn
            // 
            this.FldFindDestinationBtn.Location = new System.Drawing.Point(959, 165);
            this.FldFindDestinationBtn.Name = "FldFindDestinationBtn";
            this.FldFindDestinationBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindDestinationBtn.TabIndex = 69;
            this.FldFindDestinationBtn.Text = "DestinationFolder";
            this.FldFindDestinationBtn.UseVisualStyleBackColor = true;
            this.FldFindDestinationBtn.Click += new System.EventHandler(this.FldFindDestinationBtn_Click);
            // 
            // lblsrchFldPath
            // 
            this.lblsrchFldPath.AutoSize = true;
            this.lblsrchFldPath.Location = new System.Drawing.Point(1210, 141);
            this.lblsrchFldPath.Name = "lblsrchFldPath";
            this.lblsrchFldPath.Size = new System.Drawing.Size(28, 13);
            this.lblsrchFldPath.TabIndex = 75;
            this.lblsrchFldPath.Text = "path";
            // 
            // FldFindSearchBtn
            // 
            this.FldFindSearchBtn.Location = new System.Drawing.Point(959, 136);
            this.FldFindSearchBtn.Name = "FldFindSearchBtn";
            this.FldFindSearchBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindSearchBtn.TabIndex = 70;
            this.FldFindSearchBtn.Text = "SearchFolder";
            this.FldFindSearchBtn.UseVisualStyleBackColor = true;
            this.FldFindSearchBtn.Click += new System.EventHandler(this.FldFindSearchBtn_Click);
            // 
            // lblogFldPath
            // 
            this.lblogFldPath.AutoSize = true;
            this.lblogFldPath.Location = new System.Drawing.Point(1210, 112);
            this.lblogFldPath.Name = "lblogFldPath";
            this.lblogFldPath.Size = new System.Drawing.Size(28, 13);
            this.lblogFldPath.TabIndex = 76;
            this.lblogFldPath.Text = "path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 546);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.FldFindOriginalBtn);
            this.Controls.Add(this.lbldsFldPath);
            this.Controls.Add(this.FldFindDestinationBtn);
            this.Controls.Add(this.lblsrchFldPath);
            this.Controls.Add(this.FldFindSearchBtn);
            this.Controls.Add(this.lblogFldPath);
            this.Name = "Form1";
            this.Text = "FileMates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog originalFolderDlg;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderDlg;
        private System.Windows.Forms.OpenFileDialog initialFilesDlg;
        private System.Windows.Forms.FolderBrowserDialog searchFolderDlg;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button FldFindOriginalBtn;
        private System.Windows.Forms.Label lbldsFldPath;
        private System.Windows.Forms.Button FldFindDestinationBtn;
        private System.Windows.Forms.Label lblsrchFldPath;
        private System.Windows.Forms.Button FldFindSearchBtn;
        private System.Windows.Forms.Label lblogFldPath;
    }
}

