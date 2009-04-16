using System;
using System.Data;
using System.Windows.Forms;

namespace librarysim.Classes
{
	public class Books
	{
    #region Variables
    int bookID;
    int patronID;
    string type;
    string title;
    string author;
    string description;
    DateTime checkedin;
    DateTime checkedout;
    int reserved;
    #endregion

    #region Properties
    public int ID
    {
      get { return bookID; }
    }

    public int PatronID
    {
      get { return patronID; }
    }

    public string Type
    {
      get { return type; }
    }

    public string Title
    {
      get { return title; }
    }

    public string Author
    {
      get { return author; }
    }

    public string Description
    {
      get { return description; }
    }

    public DateTime Checkedin
    {
      get { return checkedin; }
    }

    public DateTime Checkedout
    {
      get { return checkedout; }
    }

    public int Reserved
    {
      get { return reserved; }
    }
    #endregion

		public Books( DataRow bookDR )
		{
      bookID = (int)bookDR["bookID"];
      patronID = (int)bookDR["patronID"];
      type = bookDR["type"].ToString();
      title = bookDR["title"].ToString();
      author = bookDR["author"].ToString();
      description = bookDR["description"].ToString();
      //checkedin = bookDR["checkedin"].ToString();
      //checkedout = bookDR["checkedout"].ToString();
      reserved = (int)bookDR["reserved"];
		}
	}
	
	public class BooksListViewItem : ListViewItem
	{
		
		public BooksListViewItem( DataRow bookDR )
		{
		}
		
	}
}