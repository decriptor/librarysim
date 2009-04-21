using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;

using librarysim;

namespace librarysim.Backend
{	
	class SQLite
	{
		#region Variables
		string db;
		SqliteConnection connection;
		#endregion
		
		#region Constructors
		public SQLite( string dbLocation )
		{
			this.db = dbLocation;
		}
		#endregion
		
		private void Open()
		{
			try
			{
        connection = new SqliteConnection("URI=file:" + db);
				connection.Open();
			}
			catch( SqliteException ex )
			{
				throw ex;
			}
		}
		
		private void Close()
		{
			try
			{
				connection.Close();
				connection = null;
			}
			catch( SqliteException ex )
			{
				throw ex;
			}
		}
		
		private void ExecuteNonQuery( string command )
		{
			this.Open();
			try
			{
            	SqliteCommand cmd = connection.CreateCommand();
				cmd.CommandText = command;
				cmd.ExecuteNonQuery();
			}
			catch( SqliteExecutionException ex )
			{
				throw ex;
			}
			this.Close();
		}
		
		private DataSet ExecuteScalar( string command, string table )
		{
			this.Open();
			DataSet resultset = new DataSet();
  			try
			{
				SqliteCommand cmd = connection.CreateCommand();
				cmd.CommandText = command;
				SqliteDataAdapter DA = new SqliteDataAdapter(cmd);
				DA.Fill(resultset, table);
			}
			catch( SqliteExecutionException ex )
			{
				throw ex;
			}
			this.Close();
			return resultset;			
		}
		
		#region Patrons
		
        public DataSet PatronRetrieve( int? patronID, string age)
        {
			bool patronIDIsNull = true;
			string command = String.Format("select * from Patrons");
			if(patronID != null)
			{
				patronIDIsNull = false;
				command = String.Format(command + " where ID = {0}", patronID);
			
			}
			if(age != null)
			{
				if(patronIDIsNull){
					command = String.Format(command + " where Age = {0}", age);
				}else{
					command = String.Format(command + " Age = {0}", age);
				}
			}
			return ExecuteScalar(command, "Patrons");
        }
		
		public DataSet PatronNameSearch(string name)
        {
			return ExecuteScalar(String.Format("select * from Patrons where Name like '{0}'", name), "Patrons");
        }
		
        public void PatronInsert(string name, string phoneNumber, string address, string gender, string age)
        {
			ExecuteNonQuery(String.Format("insert into Patrons (Name,PhoneNumber,Address,Gender,Age) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\")"
				                             , name, phoneNumber, address, gender, age));
        }

        public void PatronUpdate(int patronID, string name, string phoneNumber, string address, string gender, string age)
        {
			ExecuteNonQuery(String.Format("UPDATE Patrons SET Name = \"{0}\", PhoneNumber = \"{1}\", Address = \"{2}\", Gender = \"{3}\", Age = \"{4}\" WHERE (ID = {5})"
				                                , name, phoneNumber, address, gender, age, patronID));
        }

        public void PatronDelete(int patronID)
        {
			ExecuteNonQuery(String.Format("DELETE FROM Patrons WHERE ID = {0}", patronID));
        }
        #endregion
	
		#region Books
		
		public DataSet BookRetrieve(int? bookID, int? patronID)
		{
			bool bookIDIsNull = true;
			string command = String.Format("select * from Books");
			if(bookID != null)
			{
				bookIDIsNull = false;
				command = String.Format(command + " where ID = {0}", bookID);
			
			}
			if(patronID != null)
			{
				if(bookIDIsNull){
					command = String.Format(command + " where Patron = {0}", patronID);
				}else{
					command = String.Format(command + " Patron = {0}", patronID);
				}
			}
      //if (bookID == null && patronID == null) 
      //  command = String.Format(command + " where Patron = 0");

			return ExecuteScalar(command, "Books");
		}
		
		
        public void BookInsert(string type, string title, string author, string description)
		{
			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")"
				                             , type, title, author, description));
		}

        public void BookUpdate(int bookID, int? patronID, string type, string title, string author,
		                string description, DateTime? checkedout)
		{
			ExecuteNonQuery(String.Format("UPDATE Books SET Patron = {0}, Type = \"{1}\", Title = \"{2}\", Author = \"{3}\", Description = \"{4}\", Checkedout = \"{5}\""
				                                , patronID, type, title, author, description, checkedout.ToString()));
		}
		
		public void BookCheckOut(int bookID, int patronID, DateTime checkedout)
		{
			ExecuteNonQuery(String.Format("UPDATE Books SET Patron = {0}, Checkedout = \"{1}\" WHERE ID = {2}" , patronID, checkedout.ToString(), bookID));
		}
		
		public void BookCheckIn(int bookID)
		{
			ExecuteNonQuery(String.Format("UPDATE Books SET Patron = null, Checkedout = null WHERE ID = {0}" , bookID));
		}
		
        public void BookDelete(int bookID)
		{
			ExecuteNonQuery(String.Format("DELETE FROM Books WHERE ID = {0}", bookID));
		}
        #endregion

		#region Media
		public DataSet MediaRetrieve(int? mediaID, int? patronID)
		{
			bool mediaIDIsNull = true;
			string command = String.Format("select * from Media");
			if(mediaID != null)
			{
				mediaIDIsNull = false;
				command = String.Format(command + " where ID = {0}", mediaID);
			
			}
			if(patronID != null)
			{
				if(mediaIDIsNull){
					command = String.Format(command + " where Patron = {0}", patronID);
				}else{
					command = String.Format(command + " Patron = {0}", patronID);
				}
			}
			return ExecuteScalar(command, "Media");
		}
		
        public void MediaInsert(string type, string title, string rating, string description)
		{
			ExecuteNonQuery(String.Format("insert into Media (Type,Title,Rating,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")"
				                             , type, title, rating, description));
		}

        public void MediaUpdate(int mediaID, int? patronID, string type, string title, string rating,
		                string description, DateTime? checkedout)
		{
			ExecuteNonQuery(String.Format("UPDATE Media SET Patron = {0}, Type = \"{1}\", Title = \"{2}\", Rating = \"{3}\", Description = \"{4}\", Checkedout = \"{5}\""
                                                , patronID, type, title, rating, description, checkedout.ToString()));
		}
		
		public void MediaCheckOut(int mediaID, int patronID, DateTime checkedout)
		{
			ExecuteNonQuery(String.Format("UPDATE Media SET Patron = {0}, Checkedout = \"{1}\" WHERE ID = {2}" , patronID, checkedout.ToString(), mediaID));
		}
		
		public void MediaCheckIn(int mediaID)
		{
			ExecuteNonQuery(String.Format("UPDATE Media SET Patron = null, Checkedout = null WHERE ID = {0}" , mediaID));
		}
		
        public void MediaDelete(int mediaID)
		{
			ExecuteNonQuery(String.Format("DELETE FROM Media WHERE ID = {0}", mediaID));
		}
        #endregion
		
	}
}
