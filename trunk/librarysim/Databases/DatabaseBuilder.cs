using System;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

namespace librarysim.Databases
{
	public class DatabaseBuilder
	{
		#region Variables
		private SqliteConnection connection;
		#endregion
		
		public DatabaseBuilder( )
		{
			
		}
		
		public void BuildDatabase( string dbLocation )
		{
			Console.WriteLine(dbLocation);
			try
			{
				connection = new SqliteConnection(dbLocation);
				connection.Open( );
				CreateTables( );
				connection.Close( );
				connection = null;
			}
			catch (SqliteException ex)
			{
				throw ex;
			}		
			
		}
		
		private void CreateTables( )
		{
			if(!TableExists("Patrons")){
				ExecuteScalar(@"CREATE TABLE Patrons (
						ID INTEGER PRIMARY KEY,
						Name TEXT,
						PhoneNumber TEXT,
						Address TEXT,
						Gender TEXT,
						DOB TEXT
				)");
			}
			if(!TableExists("Books")){
				ExecuteScalar(@"CREATE TABLE Books (
						ID INTEGER PRIMARY KEY,
						Patron INTEGER KEY,
						Type TEXT,
						Title TEXT,
						Author TEXT,
						Description TEXT,
						Checkedin TEXT,
						Checkedout TEXT,
						Reserved INTEGER
				)");
			}
			if(!TableExists("Media")){
				ExecuteScalar(@"CREATE TABLE Media (
						ID INTEGER PRIMARY KEY,
						Patron INTEGER KEY,
						Type TEXT,
						Title TEXT,
						Rating TEXT,
						Description TEXT,
						Checkedin TEXT,
						Checkedout TEXT,
						Reserved INTEGER
				)");
			}
		}
		
		private bool TableExists(string table)
		{
			return Convert.ToInt32(ExecuteScalar(String.Format(@"
                    SELECT COUNT(*)
                    FROM sqlite_master
                    WHERE Type='table' AND Name='{0}'", 
                    table))) > 0;
		}
			
		private object ExecuteScalar(string command)
		{
			object resultset;
  
            SqliteCommand cmd = connection.CreateCommand();
            cmd.CommandText = command;
            resultset = cmd.ExecuteScalar();
            return resultset;
		}
		
		//Maybe a section that populates some fake data?
		
	}
}
