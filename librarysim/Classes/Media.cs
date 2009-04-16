using System;
using System.Data;
using System.Windows.Forms;

namespace librarysim.Classes
{
	public class Media
	{
    int mediaID;

    public int MediaID
    {
      get { return mediaID; }
      set { mediaID = value; }
    }

    int patronID;

    public int PatronID
    {
      get { return patronID; }
      set { patronID = value; }
    }

    string type;

    public string Type
    {
      get { return type; }
      set { type = value; }
    }

    string title;

    public string Title
    {
      get { return title; }
      set { title = value; }
    }

    string rating;

    public string Rating
    {
      get { return rating; }
      set { rating = value; }
    }

    string description;

    public string Description
    {
      get { return description; }
      set { description = value; }
    }

    DateTime checkedin;

    public DateTime Checkedin
    {
      get { return checkedin; }
      set { checkedin = value; }
    }

    DateTime checkedout;

    public DateTime Checkedout
    {
      get { return checkedout; }
      set { checkedout = value; }
    }

    bool reserved;

    public bool Reserved
    {
      get { return reserved; }
      set { reserved = value; }
    }

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
