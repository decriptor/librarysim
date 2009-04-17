using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace librarysim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
          PatronForm pf = new PatronForm();
          pf.ShowDialog();
        }

    }
}
