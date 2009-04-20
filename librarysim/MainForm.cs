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

        #endregion
        public MainForm()
        {
			MC = new Controller();
            InitializeComponent();
            RegisterEvents();
			FillListViews();
        }

        private void RegisterEvents()
        {
            MC.PatronsRefresh += new Controller.PatronsRefreshHandler(MC_PatronsRefresh);
            MC.BooksRefresh += new Controller.BooksRefreshHandler(MC_BooksRefresh);
            MC.MediaRefresh += new Controller.MediaRefreshHandler(MC_MediaRefresh);
			MC.AllBooksMediaRefresh += new Controller.AllBooksMediaRefreshHandler(MC_AllBooksMediaRefresh);
        }
		
		void FillListViews()
		{
			MC.RefreshPatrons();
			MC.RefreshAllBooksMedia();
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
			lsv_AllBooksMedia.Items.AddRange(books);
			lsv_AllBooksMedia.Items.AddRange(media);
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
    
	}
}
