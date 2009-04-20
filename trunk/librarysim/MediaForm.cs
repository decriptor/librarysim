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
  public partial class MediaForm : Form
  {
    int mediaID = 0;

    public MediaForm()
    {
      InitializeComponent();
      cmbType.SelectedIndex = 0;
    }

    public MediaForm( Media m )
    {
      InitializeComponent();
      mediaID = m.MediaID;
      txtPatronID.ReadOnly = false;
      txtPatronID.Text = m.PatronID.ToString(); // todo
      cmbType.SelectedIndex = (m.Type == "DVD") ? 1 : 0; // todo
      txtTitle.Text = m.Title;
      txtDescription.Text = m.Description;
      dtpCheckedOut.Value = new DateTime(); // todo
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
			this.Close();
    }
  }
}
