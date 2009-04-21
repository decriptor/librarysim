using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using librarysim.Classes;

namespace librarysim
{
    public partial class ConfigEditor : Form
    {
        public ConfigEditor()
        {
            InitializeComponent();
        }

        public ConfigEditor(Config c)
        {
          InitializeComponent();
          this.nud_AdultCheckOutPeriod.Value = c.AdultPeriodInDays;
          this.nud_DVDPeriod.Value = c.DvdPeriodInDays;
          this.nud_ChildrenCheckOutPeriod.Value = c.ChildrenPeriodInDays;
          this.nub_VideoCheckOutPeriod.Value = c.VideoTapePeriodInDays;

          this.nud_AdultBookLimit.Value = c.AdultBookLimit;
          this.numericUpDown1.Value = c.ChildrenBookLimit;
          this.numericUpDown2.Value = 0;
          this.numericUpDown3.Value = 0;
          this.numericUpDown4.Value = c.AdultChildrenAgeDelimiter;
        
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
          this.Close();
        }

    }
}
