using System;
using System.Data;
using System.Collections;
using System.IO;
using Mono.Data.Sqlite;

using librarysim.Databases;
using librarysim.Interfaces;

namespace librarysim
{	
	public sealed class DataAccess : IDataAccess
	{
		private SQLite _database;
		
		public DataAccess( string dbLocation )
		{
			if(!File.Exists(dbLocation))
			{
				//Build Initial Database if it doesn't exist
				Databases.DatabaseBuilder dBuilder = new librarysim.Databases.DatabaseBuilder();
				dBuilder.BuildDatabase( dbLocation );
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
		                  string gender, DateTime? dob)
		{
			return _database.PatronRetrieve(patronID, name, phoneNumber, address, gender, dob);
		}
		
        public void AddPatron(string name, string phoneNumber, string address, 
		                  string gender, DateTime dob)
		{
			_database.PatronInsert(name, phoneNumber, address, gender, dob);
		}

        public void UpdatePatron(int patronID, string name, string phoneNumber, 
		                  string address, string gender, DateTime dob)
		{
			_database.PatronUpdate(patronID, name, phoneNumber, address, gender, dob);
		}

        public void DeletePatron(int patronID)
		{
			_database.PatronDelete(patronID);
		}
        #endregion
		
		#region Books
		public DataSet RetrieveBook(int? bookID, int? patronID, string type, string title, string author, 
		                            string description, DateTime? checkedin, DateTime? checkedout, bool? reserved)
		{
			return _database.BookRetrieve(bookID, patronID, type, title, author, description, checkedin, checkedout, reserved);
		}
		
        public void AddBook(string type, string title, string author, string description)
		{
			_database.BookInsert(type, title, author, description);
		}

        public void UpdateBook(int bookID, int? patronID, string type, string title, string author,
		                string description, DateTime? checkedin, DateTime? checkedout, bool? reserved)
		{
			_database.BookUpdate(bookID, patronID, type, title, author, description, checkedin, checkedout, reserved);
		}
		
        public void DeleteBook(int bookID)
		{
			_database.BookDelete(bookID);
		}
        #endregion

		#region Media
		public DataSet RetrieveMedia(int? mediaID, int? patronID, string type, string title, string author, 
		                            string rating, DateTime? checkedin, DateTime? checkedout, bool? reserved)
		{
			return _database.MediaRetrieve( mediaID, patronID, type, title, author, rating, checkedin, checkedout, reserved);
		}
		
        public void AddMedia(string type, string title, string rating, string description)
		{
			_database.MediaInsert(type, title, rating, description);
		}

        public void UpdateMedia(int mediaID, int? patronID, string type, string title, string rating,
		                string description, DateTime? checkedin, DateTime? checkedout, bool? reserved)
		{
			_database.MediaUpdate(mediaID, patronID, type, title, rating, description, checkedin, checkedout, reserved);
		}
		
        public void DeleteMedia(int mediaID)
		{
			_database.MediaDelete(mediaID);
		}
        #endregion
		
	}
}
