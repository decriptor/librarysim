using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.SqliteClient;
using librarysim.Interfaces;

namespace librarysim.Databases
{	
	class SQLite
	{
		#region Variables
		const string ConnectStringFormat = "URI=file:{0};New={1};Synchronous={2}";
		static string ConnectString;
		#endregion
		
		#region Constructors
		static SQLite()
		{
			ConnectString = string.Format(ConnectStringFormat, "librarysim.db", "True", "Off");
		}
		public SQLite()
		{
			
		}
		#endregion
		
		#region Patrons
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
                using (SqliteConnection conn = new SqliteConnection(ConnectString))
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
        /// Update an existing user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        /// <param name="dob"></param>
        public void UserUpdate(int patronID, string name, string phoneNumber, string address, string gender, int dob)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(ConnectString))
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
        /// Delete an user
        /// </summary>
        /// <param name="userID"></param>
        public void UserDelete(int userID)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(ConnectString))
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

	}
}
