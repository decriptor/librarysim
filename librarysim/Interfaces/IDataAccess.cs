using System;
using System.Data;

namespace librarysim.Interfaces
{
	public interface IDataAccess
	{
		#region Patrons
		DataSet PatronRetrieve(int? patronID);
		
        void PatronInsert(string name, string phoneNumber, string address, 
		                  string gender, int dob);

        void PatronUpdate(int patronID, string name, string phoneNumber, 
		                  string address, string gender, int dob);

        void PatronDelete(int patronID);
        #endregion


	}
}
