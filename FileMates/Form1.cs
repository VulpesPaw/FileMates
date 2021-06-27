using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMates
{
    public partial class Form1 : Form
    {
        enum e_exportMode
        {
            move = 0,
            copy = 1
        }
        e_exportMode exportMode = e_exportMode.move;

        public Form1()
        {
            // Fix self-ish updateing
            // https://www.youtube.com/watch?v=9mUuJIKq40M
            // Select mutliple files with File Dialog: https://stackoverflow.com/a/12909759
            InitializeComponent();

        
        }

        private async void exportFiles()
        {
            // todo Development shortcuts, start with only folder searches, implements certain files lates


        }

        private void FldFindOriginalBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = originalFolderDlg.ShowDialog();
            lblogFldPath.Text = originalFolderDlg.SelectedPath;
        }

        private void FldFindSearchBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = searchFolderDlg.ShowDialog();
            lblsrchFldPath.Text = searchFolderDlg.SelectedPath;
        }

       

        private void FldFindDestinationBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = destinationFolderDlg.ShowDialog();
            lbldsFldPath.Text = destinationFolderDlg.SelectedPath;
        }
    }
}
