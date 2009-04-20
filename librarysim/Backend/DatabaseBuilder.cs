using System;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

using librarysim.Classes;

namespace librarysim.Backend
{
	public class DatabaseBuilder
	{
		#region Variables
		private SqliteConnection connection;
		private bool fakeData = false;
		private LibrarySimRandom lsr;
		#endregion
		
		public DatabaseBuilder( )
		{
		}
		
		public void BuildDatabase( string dbLocation, bool gfd)
		{
			this.fakeData = gfd;
			if(fakeData){
				lsr = new LibrarySimRandom();
			}
			BuildDatabase(dbLocation);
		}
		
		public void BuildDatabase( string dbLocation )
		{
			Console.WriteLine(dbLocation);
			try
			{
				connection = new SqliteConnection(dbLocation);
				connection.Open( );
				CreateTables( );
				if(this.fakeData){
					GenerateFakeData();
				}
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
						Age TEXT
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
						Checkedout TEXT
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
						Checkedout TEXT
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
			
		private object ExecuteScalar( string command )
		{
			object resultset;
  
            SqliteCommand cmd = connection.CreateCommand();
            cmd.CommandText = command;
            resultset = cmd.ExecuteScalar();
            return resultset;
		}
		
		private void ExecuteNonQuery( string command )
		{
			try
			{
            	SqliteCommand cmd = connection.CreateCommand();
				cmd.CommandText = command;
				cmd.ExecuteNonQuery();
			}
			catch( SqliteException ex )
			{
				throw ex;
			}
			catch( SqliteExecutionException ex )
			{
				throw ex;
			}
		}
		
		private void GenerateFakeData()
		{
			CreatePatrons( 0 );
			CreateBooks( 0 );
			CreateMedia( 0 );
		}
		
		private void CreatePatrons( int count )
		{
			string gender;
			for( int i = 0; i < count; ++i )
			{
				gender = lsr.RandomGender();
				if(gender == "male"){
					ExecuteNonQuery(String.Format("insert into Patrons (Name,PhoneNumber,Address,Gender,Age) VALUES (\"{0}\", {1}, \"{2}\", \"{3}\", \"{4}\")", 
					              lsr.RandomMalePerson(), lsr.RandomPhoneNumber(), lsr.RandomAddress(), gender, lsr.RandomAge()));
				}else{
					ExecuteNonQuery(String.Format("insert into Patrons (Name,PhoneNumber,Address,Gender,Age) VALUES (\"{0}\", {1}, \"{2}\", \"{3}\", \"{4}\")", 
					              lsr.RandomFemalePerson(), lsr.RandomPhoneNumber(), lsr.RandomAddress(), gender, lsr.RandomAge()));

				}
			}				
		}
		
		private void CreateBooks( int count )
		{
			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "The Boy Who Dared", "Bartoletti, Susan Campbell", "Told through flashbacks, this is a fictionalized biography of German teenager Helmuth Hubener, who was imprisoned and executed in 1942 for openly resisting the Nazis."));
		
			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "The Last Knight", "Bell, Hilari", "An anachronistic knight errant takes a criminal as squire, mistakenly frees a woman charged with murdering her husband (brother to his father's liege), and becomes captive in her keep."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Audrey", "Benway, Robin", "Audrey's ex-boyfriend records a hit song about their breakup, and suddenly all eyes (and cameras) are on Audrey. Fans, Facebook, and tabloids - it's all too much for Audrey."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "What I Saw and How I Lied", "Blundell, Judy", "When Evie’s father returns from the war, she expects life to return to normal but a mysterious trip to Florida, secrets, deceptions, and a first forbidden love complicates things."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Coe, Kendra", "Booth", "Kendra is thrilled her mom, Renee, has completed her Ph.D. program—now they can finally be a real family. But is Renee excited for their future together, too?"));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Shift", "Bradbury, Jennifer", "Chris and Win take a bicycle trip across America after graduation, but only one returns and that person is pressured to reveal what happened."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Debbie Harry Sings in French", "Brothers, Meagan", "After Johnny’s dad dies in a car accident and an unintentional drug overdose lands him in the hospital, he moves in with an uncle, gets a girlfriend, and starts to explore his interest in cross-dressing."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Bunce, Elizabeth", "A Curse Dark as Gold", "When young Charlotte Miller takes over the family's woolen mill after her father's death, she is faced with unexpected debts, catastrophes, and a hidden curse that threatens her family's future."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "The Fortunes of Indigo Skye", "Caletti, Deb", "At 18, Indigo wants no more out of life than to be a waitress and give people food, until a customer gives her $2,500,000. Can she stand the changes?"));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Graceling", "Cashore, KristinHarcourt", "Katsa was born with ability to kill men with her bare hands but can she find moral courage to stand up to evil rulers and fight for what is right?"));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Airman", "HyperionColfer, Eoin", "Conor Broekhart spends his days dreaming of flying hot air balloons and inventing flying machines until murder and court intrigue sends him to prison and labor in the diamond mines."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "The Hunger Games", "Collins, Suzanne", "Katniss has been providing for her family since her father died, but is she strong enough to win the Hunger Games, a deadly competition that can have only one winner?"));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Waiting for Normal", "Conner, Leslie", "Left to live in an old trailer under the overhead train track with Mommers, Addie is the child that has to learn to take care of herself. She almost succeeds."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Mexican White", "Boyde la Pena, Matt", "Half white, half Mexican and 100% confused, Danny struggles with baseball, his absent father and first love while spending the summer with his familia in San Diego."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Little Brother", "Doctorow, Cory", "There's been another major terrorist attack and the Department of Homeland Security has clamped down big time. It's up to Marcus, computer geek, to save everyone from this police state."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "Bog Child", "Dowd, Siobhan","When Fergus and his uncle find the body of a girl buried in the peat bog near their home, all sorts of troubles comes to light."));

			ExecuteNonQuery(String.Format("insert into Books (Type,Title,Author,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")",
			                              lsr.RandomAge(), "The London Eye Mystery", "Dowd, Siobhan David Fickling", "When their cousin Salim disappears into thin air during a ride on the London Eye ferris wheel, Ted and his sister Kat try to solve."));
		}
		
		private void CreateMedia( int count )
		{
			ExecuteNonQuery(String.Format("insert into Media (Type,Title,Rating,Description) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\")"
				                             , "adult", "The Matrix", "R", "Fake Description"));
			
		}
	}
}
