using System;
using System.Data;

namespace librarysim.Interfaces
{
	public interface IDataAccess
	{
		#region Patrons
		DataSet RetrievePatron(int patronID);
		
        void AddPatron(string name, string phoneNumber, string address, 
		                  string gender, int dob);

        void UpdatePatron(int patronID, string name, string phoneNumber, 
		                  string address, string gender, int dob);

        void DeletePatron(int patronID);
        #endregion
		
		#region Books
		DataSet RetrieveBook(int? bookID);
		
        void AddBook(string type, string title, string author, string description);

        void UpdateBook(int bookID, int? patron, string type, string title, string author,
		                string description, DateTime checkedin, DateTime checkedout,
		                bool reserved);
		
        void DeleteBook(int bookID);
        #endregion

		#region Media
		DataSet RetrieveMedia(int? media);
		
        void AddMedia(string type, string title, string rating, string description);

        void UpdateMedia(int mediaID, int? patron, string type, string title, string rating,
		                string description, DateTime checkedin, DateTime checkedout,
		                bool reserved);
		
        void DeleteMedia(int mediaID);
        #endregion
	}
}
