using System;
using System.Data;
using System.Collections;
using Mono.Data.Sqlite;

using librarysim.Databases;
using librarysim.Interfaces;

namespace librarysim
{	
	public sealed class DataAccess : IDataAccess
	{
		private SQLite _database;
		
		public DataAccess()
		{
			try
			{
				_database = new SQLite();
			}
			catch (SqliteException ex)
			{
				//Do we want some kind of logging system?
			}
		}
		
		#region Patrons
		public DataSet RetrievePatron(int patronID)
		{
			return RetrievePatron(patronID);
		}
		
        public void AddPatron(string name, string phoneNumber, string address, 
		                  string gender, int dob)
		{
			//_database.
		}

        public void UpdatePatron(int patronID, string name, string phoneNumber, 
		                  string address, string gender, int dob)
		{
			//
		}

        public void DeletePatron(int patronID)
		{
			//_database.
		}
        #endregion
		
		#region Books
		public DataSet RetrieveBook(int? bookID)
		{
			return _database.BookRetrieve(bookID);
		}
		
        public void AddBook(string type, string title, string author, string description)
		{
			//
		}

        public void UpdateBook(int bookID, int? patron, string type, string title, string author,
		                string description, DateTime checkedin, DateTime checkedout,
		                bool reserved)
		{
			//
		}
		
        public void DeleteBook(int bookID)
		{
			//
		}
        #endregion

		#region Media
		public DataSet RetrieveMedia(int? media)
		{
			return _database.MediaRetrieve(media);
		}
		
        public void AddMedia(string type, string title, string rating, string description)
		{
			//
		}

        public void UpdateMedia(int mediaID, int? patron, string type, string title, string rating,
		                string description, DateTime checkedin, DateTime checkedout,
		                bool reserved)
		{
			//
		}
		
        public void DeleteMedia(int mediaID)
		{
			//
		}
        #endregion
		
	}
}
