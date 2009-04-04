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
		public static readonly DateTime LocalUnixEpoch = new DateTime(1970, 1, 1).ToLocalTime();
		static string db;
		Config c;
		#endregion
		
		#region Constructors
		public SQLite()
		{
			c = new Config();
			db = c.DbLocation;
		}
		#endregion
		
		#region Patrons
		/// <summary>
        /// Retrieve all patrons(null) or one specific patron(patron uid)
        /// </summary>
        /// <param name="patronID"></param>
        /// <returns>patron Data Set</returns>
        public DataSet PatronRetrieve(int? patronID, string name, string phoneNumber, string address, 
		                  string gender, int? dob)
        {
            DataSet patronDS = new DataSet();
            try
            {
                using (SqliteConnection connection = new SqliteConnection(db))
                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.CommandType = CommandType.Text;
					//if(
					//string s_sql = "SELECT 
					SqliteDataAdapter DA = new SqliteDataAdapter(cmd);
                    DA.Fill(patronDS, "Patrons");
                }
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
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
        public void PatronInsert(string name, string phoneNumber, string address, string gender, int dob)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(db))
                using (SqliteCommand cmd = new SqliteCommand())
                {
					cmd.CommandType = CommandType.Text;
					string s_sql = "INSERT INTO PATRONS (NAME,PHONENUMBER,ADDRESS,GENDER,DOB) VALUES('"+name+"','"+phoneNumber+"','"+address+"','"+gender+"','"+dob+"')";
					cmd.CommandText = s_sql;
					conn.Open();
					cmd.ExecuteNonQuery();
                }
            }
            catch (SqliteExecutionException ex)
            {
				throw ex;
            }
        }

        /// <summary>
        /// Update an existing patron
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        /// <param name="dob"></param>
        public void PatronUpdate(int patronID, string name, string phoneNumber, string address, string gender, int dob)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(db))
                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete a patron
        /// </summary>
        /// <param name="patronID"></param>
        public void PatronDelete(int patronID)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(db))
                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.CommandType = CommandType.Text;
					conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
        }
        #endregion

		
		#region Books
		public DataSet BookRetrieve(int? bookID)
		{
			DataSet bookDS = new DataSet();
			
			try
            {
                using (SqliteConnection conn = new SqliteConnection(db))
                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.CommandType = CommandType.Text;
					conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqliteExecutionException ex)
            {
                throw ex;
            }
			
			return bookDS;
		}
				
        public void BookAdd(string type, string title, string author, string description)
		{
			
		}

        public void BookUpdate(int bookID, int? patron, string type, string title, string author,
		                string description, DateTime checkedin, DateTime checkedout,
		                bool reserved)
		{
			
		}
		
        public void BookUpdate(int bookID)
		{
			
		}
        #endregion

		#region Media
		public DataSet MediaRetrieve(int? media)
		{
			DataSet mediaDS = new DataSet();
			
			return mediaDS;
		}
		
        public void MediaAdd(string type, string title, string rating, string description)
		{
			
		}

        public void MediaUpdate(int mediaID, int? patron, string type, string title, string rating,
		                string description, DateTime checkedin, DateTime checkedout,
		                bool reserved)
		{
			
		}
		
        public void MediaDelete(int mediaID)
		{
			
		}
        #endregion
	}
}
