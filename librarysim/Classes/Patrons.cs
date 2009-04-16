using System;
using System.Data;
using System.Windows.Forms;

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
    string dob;
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

    public string Dob
    {
      get { return dob; }
    }
    #endregion

	
		public Patrons( DataRow patronDR )
    {
      patronID = (int)patronDR["patronID"];
      name = patronDR["name"].ToString();
      phoneNumber = patronDR["phoneNumber"].ToString();
      address = patronDR["address"].ToString();
      gender = patronDR["gender"].ToString();
      dob = patronDR["dob"].ToString();
    }
	}
	
	public class PatronsListViewItem : ListViewItem
	{
		
		public PatronsListViewItem( DataRow patronDR )
		{
		}
		
	}
}
