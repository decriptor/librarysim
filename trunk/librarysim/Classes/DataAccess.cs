using System;
using System.Data;
using System.Collections;
using System.IO;
using Mono.Data.Sqlite;

using librarysim.Backend;

namespace librarysim.Classes
{	
	public sealed class DataAccess
	{
		private SQLite _database;
		
		public DataAccess( string dbLocation )
		{
			if(!File.Exists(dbLocation))
			{
				//Build Initial Database if it doesn't exist
				Backend.DatabaseBuilder dBuilder = new librarysim.Backend.DatabaseBuilder();
				dBuilder.BuildDatabase( dbLocation, true );
			}
			try
			{
				
				_database = new SQLite( dbLocation );
			}
			catch (SqliteException ex)
			{
				throw ex;
			}
		}
		
		#region Patrons
		public DataSet RetrievePatron(int? patronID, string name, string phoneNumber, string address, 
		                  string gender, string age)
		{
			return _database.PatronRetrieve(patronID, name, phoneNumber, address, gender, age);
		}
		
        public void AddPatron(string name, string phoneNumber, string address, 
		                  string gender, string age)
		{
			_database.PatronInsert(name, phoneNumber, address, gender, age);
		}

        public void UpdatePatron(int patronID, string name, string phoneNumber, 
		                  string address, string gender, string age )
		{
			_database.PatronUpdate(patronID, name, phoneNumber, address, gender, age);
		}

        public void DeletePatron(int patronID)
		{
			_database.PatronDelete(patronID);
		}
        #endregion
		
		#region Books
		public DataSet RetrieveBook(int? bookID, int? patronID, string type, string title, string author, 
		                            string description, DateTime? checkedout)
		{
			return _database.BookRetrieve(bookID, patronID, type, title, author, description, checkedout);
		}
		
        public void AddBook(string type, string title, string author, string description)
		{
			_database.BookInsert(type, title, author, description);
		}

        public void UpdateBook(int bookID, int? patronID, string type, string title, string author,
		                string description, DateTime? checkedout)
		{
			_database.BookUpdate(bookID, patronID, type, title, author, description, checkedout);
		}
		
        public void DeleteBook(int bookID)
		{
			_database.BookDelete(bookID);
		}
        #endregion

		#region Media
		public DataSet RetrieveMedia(int? mediaID, int? patronID, string type, string title, string author, 
		                            string rating, DateTime? checkedout)
		{
			return _database.MediaRetrieve( mediaID, patronID, type, title, author, rating, checkedout);
		}
		
        public void AddMedia(string type, string title, string rating, string description)
		{
			_database.MediaInsert(type, title, rating, description);
		}

        public void UpdateMedia(int mediaID, int? patronID, string type, string title, string rating,
		                string description, DateTime? checkedout)
		{
			_database.MediaUpdate(mediaID, patronID, type, title, rating, description, checkedout);
		}
		
        public void DeleteMedia(int mediaID)
		{
			_database.MediaDelete(mediaID);
		}
        #endregion
		
	}
}
