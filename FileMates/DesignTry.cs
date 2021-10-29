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
    public partial class DesignTry : Form
    {
        public DesignTry()
        {
            InitializeComponent();
        }

        private void DesignTry_Load(object sender, EventArgs e)
        {

        }

        private void DesignTry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
