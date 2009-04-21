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
  public partial class PatronForm : Form
  {
    int patronID = 0;

    public PatronForm()
    {
      InitializeComponent();
      cmbGender.SelectedIndex = 0;
    }

    public PatronForm(Patrons p)
    {
      InitializeComponent();
      patronID = p.PatronID;
      txtName.Text = p.Name;
      txtPhoneNumber.Text = p.PhoneNumber;
      txtAddress.Text = p.Address;
      cmbGender.SelectedIndex = (p.Gender == "male") ? 0 : 1;
      //dtpDOB.Value = new DateTime(); // todo
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
