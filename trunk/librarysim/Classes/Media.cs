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

    public string Rating
    {
      get { return rating; }
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
    
    public Media( DataRow mediaDR )
		{
      mediaID = (int)mediaDR["mediaID"];
      patronID = (int)mediaDR["patronID"];
      type = mediaDR["type"].ToString();
      title = mediaDR["title"].ToString();
      rating = mediaDR["rating"].ToString();
      description = mediaDR["description"].ToString();
      //checkedin = mediaDR["checkedin"].ToString();
      //checkedout = mediaDR["checkedout"].ToString();
      reserved = (int)mediaDR["reserved"];
    }
	}
	
	public class MediaListViewItem : ListViewItem
	{
		
		public MediaListViewItem( DataRow mediaDR )
		{
		}
		
	}
}
