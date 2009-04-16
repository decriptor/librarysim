using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Collections;
using System.Windows.Forms;


namespace librarysim.Classes
{
	class Controller
	{
		#region Variables
		DataAccess data;
		#endregion

		#region Delegates
		public delegate void PatronsRefreshHandler(PatronsListViewItem[] projects);
		public event PatronsRefreshHandler PatronsRefresh;
		
		public delegate void BooksRefreshHandler(BooksListViewItem[] books);
		public event BooksRefreshHandler BooksRefresh;
		
		public delegate void MediaRefreshHandler(MediaListViewItem[] media);
		public event MediaRefreshHandler MediaRefresh;
		#endregion

		public Controller( )
		{
			data = new DataAccess();
		}

		internal void RefreshPatrons( )
		{
			List<PatronsListViewItem> patrons = new List<PatronsListViewItem>();
			DataSet ds;
			try
			{
                ds = data.RetrievePatron(null, null, null, null, null, null);
				if ((ds.Tables.Count > 0) && (ds.Tables["Patrons"].Rows.Count > 0))
				{
					for (int i = 0; i < ds.Tables["Patrons"].Rows.Count; i++)
					{
						DataRow patronsDR = ds.Tables["Patrons"].Rows[i];
						patrons.Add(new PatronsListViewItem(patronsDR));
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (PatronsRefresh != null)
			{
				PatronsRefresh(patrons.ToArray());
			}
		}

		internal void RefreshBooks( )
		{

			List<BooksListViewItem> books = new List<BooksListViewItem>();
			DataSet ds;
			try
			{
				ds = data.RetrieveBook(null, null, null, null, null, null, null, null, null);
				if ((ds.Tables.Count > 0) && (ds.Tables["Books"].Rows.Count > 0))
				{
					for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++)
					{
						DataRow bookDR = ds.Tables["Books"].Rows[i];
						books.Add(new BooksListViewItem(bookDR));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (BooksRefresh != null)
			{
				BooksRefresh(books.ToArray());
			}
		}

		internal void RefreshMedia( )
		{
			List<MediaListViewItem> media = new List<MediaListViewItem>();
			DataSet mediaDS;
			try
			{
				mediaDS = data.RetrieveMedia(null, null, null, null, null, null, null, null, null);
				if ((mediaDS.Tables.Count > 0) && (mediaDS.Tables["Media"].Rows.Count > 0))
				{
					for (int i = 0; i < mediaDS.Tables["Media"].Rows.Count; i++)
					{
						DataRow mediaDR = mediaDS.Tables["Media"].Rows[i];
						if (mediaDR["checkout"].ToString() == "")
						{
							media.Add(new MediaListViewItem(mediaDR));
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (MediaRefresh != null)
			{
				MediaRefresh(media.ToArray());
			}
		}

		internal void LoadBookDetails(int bookID)
		{
			List<Books> BK = new List<Books>();
			DataSet booksDS;
			try
			{
				booksDS = data.RetrieveBook( bookID, null, null, null, null, null, null, null, null);
				if ((booksDS.Tables.Count > 0) && (booksDS.Tables["Books"].Rows.Count > 0))
				{
					DataRow bookDR = booksDS.Tables["Books"].Rows[0];
					BK.Add(new Books(bookDR));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			//if (BookDetails != null)
			//{
			//	BookDetails(BK.ToArray());
			//}		
		}
		
		internal void LoadMediaDetails(int mediaID)
		{
			List<Media> MD = new List<Media>();
			DataSet mediaDS;
			try
			{
				mediaDS = data.RetrieveBook( mediaID, null, null, null, null, null, null, null, null);
				if ((mediaDS.Tables.Count > 0) && (mediaDS.Tables["Media"].Rows.Count > 0))
				{
					DataRow mediaDR = mediaDS.Tables["Media"].Rows[0];
					MD.Add(new Media(mediaDR));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			//if (MediaDetails != null)
			//{
			//	MediaDetails(MD.ToArray());
			//}		
		}
		
		internal void LaunchPatronsDialog()
		{
			//Form_PatronsDialog PD =  new Form_PatronsDialog();
			//if (PD.ShowDialog() == DialogResult.OK)
			//{
				//Update Patrons View  //RefreshPatrons();
			//}
		}
		        
		internal void LaunchPatronCreateDialog()
		{
			//Form_PatronCreate FPC = new Form_PatronCreate();
			//if (FPC.ShowDialog() == DialogResult.OK)
			//{
				//Create Patron Dialog  //RefreshPatrons();
			//}
		}

		internal void LaunchBookCreateDialog()
		{
			//Form_CreateBook FCB = new Form_CreateBook();
			//if (FCB.ShowDialog() == DialogResult.OK)
			//{
				//Create Book Dialog  //RefreshBooks();
			//}
		}

		internal void LaunchMediaCreateDialog()
		{
			//Form_MediaCreate FMC = new Form_MediaCreate();
			//if (FMC.ShowDialog() == DialogResult.OK)
			//{
				//Create Media Dialog  //RefreshMedia();
			//}
		}

		internal void LaunchHistoryViewer()
		{
			//Form_HistoryViewer FHV = new Form_HistoryViewer();
			//FHV.ShowDialog();
		}

		internal bool CheckBookAvailability(int bookID)
		{
			DataSet booksDS = data.RetrieveBook( bookID, null, null, null, null, null, null, null, null);
			if (booksDS != null)
			{
				if ((booksDS.Tables.Count > 0) && (booksDS.Tables["Books"].Rows.Count > 0))
				{
					DataRow bookDR = booksDS.Tables["Books"].Rows[0];
					if (bookDR["checkouted"].ToString() == "")
					{
						return true;
					}
				}
			}
			return false;
		}
		
		internal bool CheckMediaAvailability(int mediaID)
		{
			DataSet mediaDS = data.RetrieveMedia(null, null, null, null, null, null, null, null, null);
			if (mediaDS != null)
			{
				if ((mediaDS.Tables.Count > 0) && (mediaDS.Tables["Media"].Rows.Count > 0))
				{
					DataRow mediaDR = mediaDS.Tables["Media"].Rows[0];
					if (mediaDR["checkouted"].ToString() == "")
					{
						return true;
					}
				}
			}
			return false;
		}

		internal void EditPatron( int patronID )
		{
			//Form_PatronEditor FPE = new Form_PatronEditor();
			//if (FPE.ShowDialog() == DialogResult.OK)
			//{
				//Update Patron's Information
			//}
		}
	}
}
