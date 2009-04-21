using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace librarysim.Classes
{
	class Controller
	{
		#region Variables
		XmlSerializer s;
		DataAccess data;
		Config conf;
		string configPathBase;
		#endregion

		#region Delegates
		public delegate void PatronsRefreshHandler(PatronsListViewItem[] projects);
		public event PatronsRefreshHandler PatronsRefresh;
		
		public delegate void BooksRefreshHandler(BooksListViewItem[] books);
		public event BooksRefreshHandler BooksRefresh;
		
		public delegate void MediaRefreshHandler(MediaListViewItem[] media);
		public event MediaRefreshHandler MediaRefresh;
		
		public delegate void AllBooksMediaRefreshHandler(BooksListViewItem[] books, MediaListViewItem[] media);
		public event AllBooksMediaRefreshHandler AllBooksMediaRefresh;
		
        public delegate void PatronCheckedOutRefreshHandler(BooksListViewItem[] books, MediaListViewItem[] media);
        public event PatronCheckedOutRefreshHandler PatronCheckedOutRefresh;
		#endregion

		public Controller( )
		{
			ConfigLoader( );
			data = new DataAccess( conf.DbLocation );
		}
		
		private void ConfigLoader( )
		{
			configPathBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"librarysim");
			s = new XmlSerializer( typeof( Config) );
			//Check if directory exists
			if(!Directory.Exists(configPathBase))
			{
				Directory.CreateDirectory(configPathBase);
			}
			if(File.Exists(Path.Combine(configPathBase,"librarysim.xml")))
			{
				// Deserialization + Import configuration
				TextReader r = new StreamReader( Path.Combine(configPathBase,"librarysim.xml") );
				conf = (Config)s.Deserialize( r );
				r.Close();
			}
			else
			{
				//Create New Config
				conf = new Config();
			}
		}
		
		private void ConfigWriter()
		{
			// Writing out Config
			TextWriter w = new StreamWriter(Path.Combine(configPathBase,"librarysim.xml"));
			s.Serialize(w, conf);
			w.Close();
		}

        internal void RefreshPatrons( )
        {
            RefreshPatrons( string.Empty );
        }

		internal void RefreshPatrons( string nameSearch )
		{
			List<PatronsListViewItem> patrons = new List<PatronsListViewItem>();
			DataSet ds;
			try
			{
                if (nameSearch != string.Empty){
                    ds = data.PatronNameSearch(nameSearch);
                }else{
                    ds = data.RetrievePatron(null, null);
                }
                
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
			DataSet booksDS;
			try
			{
				booksDS = data.RetrieveBook(null, null);
				if ((booksDS.Tables.Count > 0) && (booksDS.Tables["Books"].Rows.Count > 0))
				{
					for (int i = 0; i < booksDS.Tables["Books"].Rows.Count; i++)
					{
						DataRow bookDR = booksDS.Tables["Books"].Rows[i];
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
				mediaDS = data.RetrieveMedia(null, null);
				if ((mediaDS.Tables.Count > 0) && (mediaDS.Tables["Media"].Rows.Count > 0))
				{
					for (int i = 0; i < mediaDS.Tables["Media"].Rows.Count; i++)
					{
						DataRow mediaDR = mediaDS.Tables["Media"].Rows[i];
						media.Add(new MediaListViewItem(mediaDR));
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

		internal void RefreshAllBooksMedia( )
		{
			List<BooksListViewItem> books = new List<BooksListViewItem>();
			DataSet booksDS;
			List<MediaListViewItem> media = new List<MediaListViewItem>();
			DataSet mediaDS;
			try
			{
				booksDS = data.RetrieveBook(null, null);
				if ((booksDS.Tables.Count > 0) && (booksDS.Tables["Books"].Rows.Count > 0))
				{
					for (int i = 0; i < booksDS.Tables["Books"].Rows.Count; i++)
					{
						DataRow bookDR = booksDS.Tables["Books"].Rows[i];
						books.Add(new BooksListViewItem(bookDR));
					}
				}
				mediaDS = data.RetrieveMedia(null, null);
				if ((mediaDS.Tables.Count > 0) && (mediaDS.Tables["Media"].Rows.Count > 0))
				{
					for (int i = 0; i < mediaDS.Tables["Media"].Rows.Count; i++)
					{
						DataRow mediaDR = mediaDS.Tables["Media"].Rows[i];
						media.Add(new MediaListViewItem(mediaDR));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (BooksRefresh != null)
			{
				AllBooksMediaRefresh(books.ToArray(), media.ToArray());
			}
		}

        internal void RefreshPatronCheckedOut(int patronID)
        {
            List<BooksListViewItem> books = new List<BooksListViewItem>();
            DataSet booksDS;
            List<MediaListViewItem> media = new List<MediaListViewItem>();
            DataSet mediaDS;
            try
            {
                booksDS = data.RetrieveBook(null, patronID);
                if ((booksDS.Tables.Count > 0) && (booksDS.Tables["Books"].Rows.Count > 0))
                {
                    for (int i = 0; i < booksDS.Tables["Books"].Rows.Count; i++)
                    {
                        DataRow bookDR = booksDS.Tables["Books"].Rows[i];
                        books.Add(new BooksListViewItem(bookDR));
                    }
                }
                mediaDS = data.RetrieveMedia(null, patronID);
                if ((mediaDS.Tables.Count > 0) && (mediaDS.Tables["Media"].Rows.Count > 0))
                {
                    for (int i = 0; i < mediaDS.Tables["Media"].Rows.Count; i++)
                    {
                        DataRow mediaDR = mediaDS.Tables["Media"].Rows[i];
                        media.Add(new MediaListViewItem(mediaDR));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (BooksRefresh != null)
            {
                PatronCheckedOutRefresh(books.ToArray(), media.ToArray());
            }
        }

		internal void LoadPatronDetails(int patronID)
		{
			DataSet patronsDS;
            Patrons p;
			try
			{
                patronsDS = data.RetrievePatron(patronID, null);
                if ((patronsDS.Tables.Count > 0) && (patronsDS.Tables["Patrons"].Rows.Count > 0))
				{
                    DataRow patronDR = patronsDS.Tables["Patrons"].Rows[0];
                    p = new Patrons(patronDR);
                    LaunchPatronsDialog(p);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		internal void LaunchPatronsDialog(Patrons p)
		{
      PatronForm pf = new PatronForm(p);
			if (pf.ShowDialog() == DialogResult.OK)
			{
				//Update Patrons View  
        RefreshPatrons();
			}
		}
  
		internal void LaunchPatronCreateDialog()
		{
      PatronForm pf = new PatronForm();
      if (pf.ShowDialog() == DialogResult.OK)
      {
        //Create Patron Dialog  
        RefreshPatrons();
      }
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

		internal void EditPatron( int patronID )
		{
      PatronForm FPE = new PatronForm();
			if (FPE.ShowDialog() == DialogResult.OK)
			{
				//Update Patron's Information
			}
		}

        internal void CheckOutBook(int bookID, int patronID, DateTime selectedDate)
        {
            data.CheckOutBook(bookID, patronID, selectedDate);
        }

        internal void CheckOutMedia(int mediaID, int patronID, DateTime selectedDate)
        {
            data.CheckOutMedia(mediaID, patronID, selectedDate);
        }

        internal void CheckInBook(int bookID)
        {
            data.CheckInBook(bookID);
        }

        internal void CheckInMedia(int mediaID)
        {
            data.CheckInMedia(mediaID);
        }

        internal void PatronNameSearch(string name)
        {
            RefreshPatrons(name);
        }
        
        internal void PatronDelete(int id)
        {
          data.DeletePatron(id);
          RefreshPatrons();
        }
  }
}
