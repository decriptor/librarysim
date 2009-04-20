using System;
using System.Data;

namespace librarysim.Interfaces
{
	public interface IDataAccess
	{
		#region Patrons
		DataSet RetrievePatron(int? patronID, string name, string phoneNumber, string address, 
		                  string gender, string age);
		
        void AddPatron(string name, string phoneNumber, string address, string gender, string age);

        void UpdatePatron(int patronID, string name, string phoneNumber, string address, 
		                  string gender, string age);

        void DeletePatron(int patronID);
        #endregion
		
		#region Books
		DataSet RetrieveBook(int? bookID, int? patronID, string type, string title, string author, 
		                            string description, DateTime? checkedout);
		
        void AddBook(string type, string title, string author, string description);

        void UpdateBook(int bookID, int? patronID, string type, string title, string author,
		                string description, DateTime? checkedout);
		
        void DeleteBook(int bookID);
        #endregion

		#region Media
		DataSet RetrieveMedia(int? mediaID, int? patronID, string type, string title, string author, 
		                            string rating, DateTime? checkedout);
		
        void AddMedia(string type, string title, string rating, string description);

        void UpdateMedia(int mediaID, int? patronID, string type, string title, string rating,
		                string description, DateTime? checkedout);
		
        void DeleteMedia(int mediaID);
        #endregion
	}
}
