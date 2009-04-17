using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using librarysim;
using librarysim.Interfaces;

namespace librarysim.Databases
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
				connection = new SqliteConnection(db);
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
		
		#region Patrons
		
		/// <summary>
        /// Retrieve all patrons(null) or one specific patron(patron uid)
        /// </summary>
        /// <param name="patronID"></param>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        /// <param name="dob"></param>
        /// <returns>patron Data Set</returns>
        public DataSet PatronRetrieve(int? patronID, string name, string phoneNumber, string address, 
		                  string gender, DateTime? dob)
        {
			this.Open();
            DataSet patronDS = new DataSet();
            try
            {
                SqliteCommand cmd = new SqliteCommand();
				cmd.CommandText = String.Format("select * from Patrons where ID = {0} and Name = {1} and PhoneNumber = {2} and Address = {3} and Gender = {4} and DOB = {5}"
				                             , patronID, name, phoneNumber, address, gender, dob.ToString());
				SqliteDataAdapter DA = new SqliteDataAdapter(cmd);
				DA.Fill(patronDS, "Patrons");
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
			return patronDS;
        }
		
        /// <summary>
        /// Add a new patron
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        /// <param name="dob"></param>
        public void PatronInsert(string name, string phoneNumber, string address, string gender, DateTime dob)
        {
			this.Open();
            try
            {
				SqliteCommand cmd = new SqliteCommand();
				cmd.CommandText = String.Format("insert into Patrons (Name,PhoneNumber,Address,Gender,DOB) VALUES ({0}, {1}, {2}, {3}, {4})"
				                             , name, phoneNumber, address, gender, dob.ToString());
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
				throw ex;
            }
			this.Close();
        }

        /// <summary>
        /// Update an existing patron
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        /// <param name="dob"></param>
        public void PatronUpdate(int patronID, string name, string phoneNumber, string address, string gender, DateTime dob)
        {
			this.Open();
            try
            {
                SqliteCommand cmd = new SqliteCommand();
                cmd.CommandText = String.Format("UPDATE Patrons SET Name = {0}, PhoneNumber = {1}, Address = {2}, Gender = {3}, DOB = {4} WHERE (ID = {5})"
				                                , name, phoneNumber, address, gender, dob.ToString(), patronID);
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
        }

        /// <summary>
        /// Delete a patron
        /// </summary>
        /// <param name="patronID"></param>
        public void PatronDelete(int patronID)
        {
			this.Open();
            try
            {
                SqliteCommand cmd = new SqliteCommand();
                cmd.CommandText = String.Format("DELETE FROM Patrons WHERE ID = {0}", patronID);
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
        }
        #endregion
	
		#region Books
		
		/// <summary>
        /// Retrieve all books(null) or one specific book(book id)
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="patronID"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="description"></param>
        /// <param name="checkedout"></param>
        /// <param name="checkedin"></param>
        /// <param name="reserved"></param>
        /// <returns>book Data Set</returns>
		public DataSet BookRetrieve(int? bookID, int? patronID, string type, string title, string author, 
		                            string description, DateTime? checkedin, DateTime? checkedout, bool? reserved)
		{
			this.Open();
			DataSet bookDS = new DataSet();
			try
            {
                SqliteCommand cmd = new SqliteCommand();
				cmd.CommandText = String.Format("select * from Books where ID = {0} and Patron = {1} and Type = {2} and Title = {3} and Author = {4} and description = {5} and Checkedin = {6} and Checkedout = {7} and Reserved = {8}"
				                             , bookID, patronID, type, title, author, description, checkedin.ToString(), checkedout.ToString(), Convert.ToInt32(reserved));
				SqliteDataAdapter DA = new SqliteDataAdapter(cmd);
				DA.Fill(bookDS, "Books");
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
			return bookDS;
		}
		
		
        public void BookInsert(string type, string title, string author, string description)
		{
			this.Open();
            try
            {
				SqliteCommand cmd = new SqliteCommand();
				cmd.CommandText = String.Format("insert into Books (Type,Title,Author,Description) VALUES ({0}, {1}, {2}, {3})"
				                             , type, title, author, description);
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
				throw ex;
            }
			this.Close();
		}

        public void BookUpdate(int bookID, int? patronID, string type, string title, string author,
		                string description, DateTime? checkedin, DateTime? checkedout, bool? reserved)
		{
			this.Open();
            try
            {
                SqliteCommand cmd = new SqliteCommand();
                cmd.CommandText = String.Format("UPDATE Books SET Patron = {0}, Type = {1}, Title = {2}, Author = {3}, Description = {4}, Checkedin = {5}, Checkedout = {6}, Reserved = {7} WHERE (ID = {8})"
				                                , patronID, type, title, author, description, checkedin.ToString(), checkedout.ToString(), Convert.ToInt32(reserved));
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
		}
		
        public void BookDelete(int bookID)
		{
			this.Open();
            try
            {
                SqliteCommand cmd = new SqliteCommand();
                cmd.CommandText = String.Format("DELETE FROM Books WHERE ID = {0}", bookID);
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
		}
        #endregion

		#region Media
		public DataSet MediaRetrieve(int? mediaID, int? patronID, string type, string title, string author, 
		                            string rating, DateTime? checkedin, DateTime? checkedout, bool? reserved )
		{
			this.Open();
			DataSet mediaDS = new DataSet();
			try
            {
                SqliteCommand cmd = new SqliteCommand();
				cmd.CommandText = String.Format("select * from Media where ID = {0} and Patron = {1} and Type = {2} and Title = {3} and Rating = {4} and description = {5} and Checkedin = {6} and Checkedout = {7} and Reserved = {8}"
				                             , mediaID, patronID, type, title, author, rating, checkedin.ToString(), checkedout.ToString(), Convert.ToInt32(reserved));
				SqliteDataAdapter DA = new SqliteDataAdapter(cmd);
				DA.Fill(mediaDS, "Media");
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
			return mediaDS;
		}
		
        public void MediaInsert(string type, string title, string rating, string description)
		{
			this.Open();
            try
            {
				SqliteCommand cmd = new SqliteCommand();
				cmd.CommandText = String.Format("insert into Media (Type,Title,Rating,Description) VALUES ({0}, {1}, {2}, {3})"
				                             , type, title, rating, description);
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
				throw ex;
            }
			this.Close();
		}

        public void MediaUpdate(int mediaID, int? patronID, string type, string title, string rating,
		                string description, DateTime? checkedin, DateTime? checkedout, bool? reserved)
		{
			this.Open();
            try
            {
                SqliteCommand cmd = new SqliteCommand();
                cmd.CommandText = String.Format("UPDATE Media SET Patron = {0}, Type = {1}, Title = {2}, Rating = {3}, Description = {4}, Checkedin = {5}, Checkedout = {6}, Reserved = {7} WHERE (ID = {8})"
				                                , patronID, type, title, rating, description, checkedin.ToString(), checkedout.ToString(), Convert.ToInt32(reserved));
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
		}
		
        public void MediaDelete(int mediaID)
		{
			this.Open();
            try
            {
                SqliteCommand cmd = new SqliteCommand();
                cmd.CommandText = String.Format("DELETE FROM Media WHERE ID = {0}", mediaID);
				cmd.ExecuteNonQuery();
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			this.Close();
		}
        #endregion
		
	}
}
