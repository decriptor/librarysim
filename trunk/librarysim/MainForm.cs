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
    public partial class MainForm : Form
    {
        #region Variables
        Controller MC;
        int _selectedPatron = 0;
        DateTime _currentDate;
        #endregion


        public MainForm()
        {
			MC = new Controller();
            InitializeComponent();
            RegisterEvents();
			FillListViews();
            BuildGUIComponents();
        }

        private void RegisterEvents()
        {
            MC.PatronsRefresh += new Controller.PatronsRefreshHandler(MC_PatronsRefresh);
            MC.BooksRefresh += new Controller.BooksRefreshHandler(MC_BooksRefresh);
            MC.MediaRefresh += new Controller.MediaRefreshHandler(MC_MediaRefresh);
			MC.AllBooksMediaRefresh += new Controller.AllBooksMediaRefreshHandler(MC_AllBooksMediaRefresh);
            MC.PatronCheckedOutRefresh += new Controller.PatronCheckedOutRefreshHandler(MC_PatronCheckedOutRefresh);
        }

		void FillListViews()
		{
			MC.RefreshPatrons();
            cb_FilterBooks.Checked = true;
            cb_FilterMedia.Checked = true;
			MC.RefreshAllBooksMedia();
		}

        private void BuildGUIComponents()
        {
			dtp_DateSelector.Value = DateTime.Now;
            cb_TargetAudience.Items.Add("all");
            cb_TargetAudience.Items.Add("adult");
            cb_TargetAudience.Items.Add("child");
        }

		#region Events
        void MC_PatronsRefresh(PatronsListViewItem[] projects)
        {
            lsv_Patron.Items.Clear();
            lsv_Patron.Items.AddRange(projects);
        }
		
		void MC_AllBooksMediaRefresh( BooksListViewItem[] books, MediaListViewItem[] media )
		{
			lsv_AllBooksMedia.Items.Clear();
            if (cb_FilterBooks.Checked)
            {
                lsv_AllBooksMedia.Items.AddRange(books);
            }
            if (cb_FilterMedia.Checked)
            {
                lsv_AllBooksMedia.Items.AddRange(media);
            }
		}

        void MC_PatronCheckedOutRefresh(BooksListViewItem[] books, MediaListViewItem[] media)
        {
            lsv_CheckedOutByPatron.Items.Clear();
            lsv_CheckedOutByPatron.Items.AddRange(books);
            lsv_CheckedOutByPatron.Items.AddRange(media);
        }

        void MC_BooksRefresh(BooksListViewItem[] books)
        {
			throw new NotImplementedException();
        }

        void MC_MediaRefresh(MediaListViewItem[] media)
        {
            throw new NotImplementedException();
        }

        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
          PatronForm pf = new PatronForm();
          pf.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          AboutBox ab = new AboutBox();
          ab.ShowDialog();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          MediaForm mf = new MediaForm();
          mf.ShowDialog();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigEditor ce = new ConfigEditor();
            ce.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		#endregion

        private void lsv_Patron_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection patrons = lsv_Patron.SelectedItems;

            if ((patrons != null) && (patrons.Count == 1))
            {
                foreach (PatronsListViewItem patron in patrons)
                {
                    _selectedPatron = (patron as PatronsListViewItem).PatronID;
                    gb_PatronCheckedOut.Text = "Books and Media Checked Out by " + (patron as PatronsListViewItem).PatronName;
                    MC.RefreshPatronCheckedOut(_selectedPatron);                    
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            MC.RefreshAllBooksMedia();
        }

        private void btn_checkInOut_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = lsv_AllBooksMedia.SelectedItems;
            if ((items != null) && (items.Count >= 1))
            {
                for (int i = 0; i < items.Count; ++i)
                {
                    ListViewItem Selected = items[i];
                    if (Selected is BooksListViewItem)
                    {
                        foreach (BooksListViewItem item in items)
                        {
                            MC.CheckOutBook((item as BooksListViewItem).BooksID, _selectedPatron, _currentDate);
                            MC.RefreshPatronCheckedOut(_selectedPatron);
                        }
                    }
                    if (Selected is MediaListViewItem)
                    {
                        foreach (MediaListViewItem item in items)
                        {
                            MC.CheckOutMedia((item as MediaListViewItem).MediaID, _selectedPatron, _currentDate);
                            MC.RefreshPatronCheckedOut(_selectedPatron);
                        }
                    }
                }
            }
        }

        private void dtp_DateSelector_ValueChanged(object sender, EventArgs e)
        {
            _currentDate = (sender as DateTimePicker).Value;
            MC.RefreshAllBooksMedia();
            MC.RefreshPatronCheckedOut(_selectedPatron);
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
			
            ListView.SelectedListViewItemCollection items = lsv_CheckedOutByPatron.SelectedItems;
            if ((items != null) && (items.Count >= 1))
            {
                for (int i = 0; i < items.Count; ++i)
                {
                    ListViewItem Selected = items[i];
                    if (Selected is BooksListViewItem)
                    {
                        foreach (BooksListViewItem item in items)
                        {
                            MC.CheckInBook((item as BooksListViewItem).BooksID);
                            MC.RefreshPatronCheckedOut(_selectedPatron);
                        }
                    }
                    if (Selected is MediaListViewItem)
                    {
                        foreach (MediaListViewItem item in items)
                        {
                            MC.CheckInMedia((item as MediaListViewItem).MediaID);
                            MC.RefreshPatronCheckedOut(_selectedPatron);
                        }
                    }
                }
            }
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
			if (tb_FirstName.Text.Length == 0 && tb_LastName.Text.Length == 0)
            {
                MC.RefreshPatrons( );
            }
            if (tb_FirstName.Text.Length >= 2 || tb_LastName.Text.Length >= 2)
            {
                MC.PatronNameSearch(string.Format(tb_FirstName.Text.Trim() + "% " + tb_LastName.Text.Trim() + "%"));
            }
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
          BookForm bf = new BookForm();
          bf.ShowDialog();
        }
    
	}
}
