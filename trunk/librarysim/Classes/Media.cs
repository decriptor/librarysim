using System;
using System.Data;
using System.Windows.Forms;

namespace librarysim.Classes
{
	public class Media
  {

    #region Variables
    int mediaID;
    int patronID;
    string type;
    string title;
    string rating;
    string description;
    DateTime checkedin;
    DateTime checkedout;
    int reserved;
    #endregion


    #region Properties
    public int MediaID
    {
      get { return mediaID; }
      set { mediaID = value; }
    }

    public int PatronID
    {
      get { return patronID; }
      set { patronID = value; }
    }

    public string Type
    {
      get { return type; }
      set { type = value; }
    }

    public string Title
    {
      get { return title; }
      set { title = value; }
    }

    public string Rating
    {
      get { return rating; }
      set { rating = value; }
    }

    public string Description
    {
      get { return description; }
      set { description = value; }
    }

    public DateTime Checkedin
    {
      get { return checkedin; }
      set { checkedin = value; }
    }

    public DateTime Checkedout
    {
      get { return checkedout; }
      set { checkedout = value; }
    }

    public int Reserved
    {
      get { return reserved; }
      set { reserved = value; }
    }
    #endregion
    
    public Media( DataRow mediaDR )
		{

		}
	}
	
	public class MediaListViewItem : ListViewItem
	{
		
		public MediaListViewItem( DataRow mediaDR )
		{
		}
		
	}
}
