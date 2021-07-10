
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
            this.btnRun = new System.Windows.Forms.Button();
            this.destinationFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.initialFilesDlg = new System.Windows.Forms.OpenFileDialog();
            this.searchFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.FldFindOriginalBtn = new System.Windows.Forms.Button();
            this.FldFindDestinationBtn = new System.Windows.Forms.Button();
            this.FldFindSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblogFldPath = new System.Windows.Forms.Label();
            this.lblsrchFldPath = new System.Windows.Forms.Label();
            this.lbldsFldPath = new System.Windows.Forms.Label();
            this.btnF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(607, 512);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // initialFilesDlg
            // 
            this.initialFilesDlg.FileName = "openFileDialog1";
            // 
            // FldFindOriginalBtn
            // 
            this.FldFindOriginalBtn.Location = new System.Drawing.Point(12, 17);
            this.FldFindOriginalBtn.Name = "FldFindOriginalBtn";
            this.FldFindOriginalBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindOriginalBtn.TabIndex = 1;
            this.FldFindOriginalBtn.Text = "OriginalFolder";
            this.FldFindOriginalBtn.UseVisualStyleBackColor = true;
            this.FldFindOriginalBtn.Click += new System.EventHandler(this.FldFindOriginalBtn_Click);
            // 
            // FldFindDestinationBtn
            // 
            this.FldFindDestinationBtn.Location = new System.Drawing.Point(12, 75);
            this.FldFindDestinationBtn.Name = "FldFindDestinationBtn";
            this.FldFindDestinationBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindDestinationBtn.TabIndex = 2;
            this.FldFindDestinationBtn.Text = "DestinationFolder";
            this.FldFindDestinationBtn.UseVisualStyleBackColor = true;
            this.FldFindDestinationBtn.Click += new System.EventHandler(this.FldFindDestinationBtn_Click);
            // 
            // FldFindSearchBtn
            // 
            this.FldFindSearchBtn.Location = new System.Drawing.Point(12, 46);
            this.FldFindSearchBtn.Name = "FldFindSearchBtn";
            this.FldFindSearchBtn.Size = new System.Drawing.Size(107, 23);
            this.FldFindSearchBtn.TabIndex = 3;
            this.FldFindSearchBtn.Text = "SearchFolder";
            this.FldFindSearchBtn.UseVisualStyleBackColor = true;
            this.FldFindSearchBtn.Click += new System.EventHandler(this.FldFindSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original FolderPath:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search FolderPath:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination FolderPath:";
            // 
            // lblogFldPath
            // 
            this.lblogFldPath.AutoSize = true;
            this.lblogFldPath.Location = new System.Drawing.Point(362, 22);
            this.lblogFldPath.Name = "lblogFldPath";
            this.lblogFldPath.Size = new System.Drawing.Size(28, 13);
            this.lblogFldPath.TabIndex = 5;
            this.lblogFldPath.Text = "path";
            // 
            // lblsrchFldPath
            // 
            this.lblsrchFldPath.AutoSize = true;
            this.lblsrchFldPath.Location = new System.Drawing.Point(362, 51);
            this.lblsrchFldPath.Name = "lblsrchFldPath";
            this.lblsrchFldPath.Size = new System.Drawing.Size(28, 13);
            this.lblsrchFldPath.TabIndex = 5;
            this.lblsrchFldPath.Text = "path";
            // 
            // lbldsFldPath
            // 
            this.lbldsFldPath.AutoSize = true;
            this.lbldsFldPath.Location = new System.Drawing.Point(362, 80);
            this.lbldsFldPath.Name = "lbldsFldPath";
            this.lbldsFldPath.Size = new System.Drawing.Size(28, 13);
            this.lbldsFldPath.TabIndex = 5;
            this.lbldsFldPath.Text = "path";
            // 
            // btnF1
            // 
            this.btnF1.Location = new System.Drawing.Point(568, 190);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(75, 23);
            this.btnF1.TabIndex = 6;
            this.btnF1.Text = "F1";
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 547);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.lbldsFldPath);
            this.Controls.Add(this.lblsrchFldPath);
            this.Controls.Add(this.lblogFldPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FldFindSearchBtn);
            this.Controls.Add(this.FldFindDestinationBtn);
            this.Controls.Add(this.FldFindOriginalBtn);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "FileMates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog originalFolderDlg;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderDlg;
        private System.Windows.Forms.OpenFileDialog initialFilesDlg;
        private System.Windows.Forms.FolderBrowserDialog searchFolderDlg;
        private System.Windows.Forms.Button FldFindOriginalBtn;
        private System.Windows.Forms.Button FldFindDestinationBtn;
        private System.Windows.Forms.Button FldFindSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblogFldPath;
        private System.Windows.Forms.Label lblsrchFldPath;
        private System.Windows.Forms.Label lbldsFldPath;
        private System.Windows.Forms.Button btnF1;
    }
}

