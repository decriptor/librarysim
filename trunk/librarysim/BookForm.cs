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
  public partial class BookForm : Form
  {
    int bookID = 0;
    
    public BookForm()
    {
      InitializeComponent();
      cmbType.SelectedIndex = 0;
    }

    public BookForm( Books b )
    {
      InitializeComponent();
      bookID = b.BooksID;
      txtPatronID.ReadOnly = false;
      txtPatronID.Text = b.PatronID.ToString(); // todo
      cmbType.SelectedIndex = (b.Type == "adult") ? 0 : 1; // todo
      txtTitle.Text = b.Title;
      txtDescription.Text = b.Description;
      //dtpCheckedOut.Value = new DateTime(); // todo
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
