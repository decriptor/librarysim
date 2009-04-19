using System;
using System.Data;
using System.Windows.Forms;

using librarysim.Backend;

namespace librarysim.Classes
{
	public class Patrons
	{
		#region Variables
    	int patronID;
    	string name;
    	string phoneNumber;
    	string address;
    	string gender;
    	string age;
    	#endregion

    	#region Properties
    	public int PatronID
    	{
			get { return patronID; }
    	}

    	public string Name
    	{
			get { return name; }
    	}
		
		public string PhoneNumber
		{
			get { return phoneNumber; }
		}
		
		public string Address
		{
			get { return address; }
		}
		
		public string Gender
		{
			get { return gender; }
		}
		
		public string Age
		{
			get { return age; }
		}
		#endregion
		
		
		public Patrons( DataRow patronDR )
		{
			patronID = Convert.ToInt32(patronDR[Tables.patronID]);
			name = patronDR[Tables.patronName].ToString();
			phoneNumber = patronDR[Tables.patronPhoneNumber].ToString();
			address = patronDR[Tables.patronAddress].ToString();
			gender = patronDR[Tables.patronGender].ToString();
			age = patronDR[Tables.patronAge].ToString();
		}
	}
	
	public class PatronsListViewItem : ListViewItem
	{
		#region Variables
    	int patronID;
    	string name;
    	string phoneNumber;
    	string address;
    	string gender;
    	string age;
    	#endregion

    	#region Properties
    	public int PatronID
    	{
			get { return patronID; }
    	}

    	public string PatronName
    	{
			get { return name; }
    	}
		
		public string PhoneNumber
		{
			get { return phoneNumber; }
		}
		
		public string Address
		{
			get { return address; }
		}
		
		public string Gender
		{
			get { return gender; }
		}
		
		public string Age
		{
			get { return age; }
		}
		#endregion
		
		
		public PatronsListViewItem( DataRow patronDR )
		{
			patronID = Convert.ToInt32(patronDR[Tables.patronID]);
			name = patronDR[Tables.patronName].ToString();
			phoneNumber = patronDR[Tables.patronPhoneNumber].ToString();
			address = patronDR[Tables.patronAddress].ToString();
			gender = patronDR[Tables.patronGender].ToString();
			age = patronDR[Tables.patronAge].ToString();
		}

	}
}
