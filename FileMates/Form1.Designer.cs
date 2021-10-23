
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialFilesDlg
            // 
            this.initialFilesDlg.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "6176576.jpg");
            this.imageList1.Images.SetKeyName(1, "4ccb32777282fff69d63c79f77055a76.jpg");
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1082, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Original FolderPath:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1082, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Destination FolderPath:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1082, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Search FolderPath:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(150, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 250);
            this.panel1.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.Location = new System.Drawing.Point(3, 404);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(141, 115);
            this.treeView2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(141, 395);
            this.treeView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.53465F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.46535F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.81992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.18008F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(410, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 23);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(446, 31);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 23);
            this.btnForward.TabIndex = 79;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-23, -46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 80;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(840, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 81;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Path:";
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(526, 34);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(308, 20);
            this.tbxPath.TabIndex = 83;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(410, 70);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(505, 418);
            this.webBrowser.TabIndex = 84;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 546);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.FldFindOriginalBtn);
            this.Controls.Add(this.lbldsFldPath);
            this.Controls.Add(this.FldFindDestinationBtn);
            this.Controls.Add(this.lblsrchFldPath);
            this.Controls.Add(this.FldFindSearchBtn);
            this.Controls.Add(this.lblogFldPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "FileMates";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog originalFolderDlg;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderDlg;
        private System.Windows.Forms.OpenFileDialog initialFilesDlg;
        private System.Windows.Forms.FolderBrowserDialog searchFolderDlg;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button FldFindOriginalBtn;
        private System.Windows.Forms.Label lbldsFldPath;
        private System.Windows.Forms.Button FldFindDestinationBtn;
        private System.Windows.Forms.Label lblsrchFldPath;
        private System.Windows.Forms.Button FldFindSearchBtn;
        private System.Windows.Forms.Label lblogFldPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

