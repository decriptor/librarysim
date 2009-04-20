using System;
using System.Data;
using System.Windows.Forms;

using librarysim.Backend;

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
		bool reserved;
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
		
		public bool Reserved
		{
			get { return reserved; }
		}
		#endregion
		
		public Media( DataRow mediaDR )
		{
			mediaID = Convert.ToInt32(mediaDR[Tables.mediaID]);
			patronID = Convert.ToInt32(mediaDR[Tables.mediaPatronID]);
			type = mediaDR[Tables.mediaType].ToString();
			title = mediaDR[Tables.mediaTitle].ToString();
			rating = mediaDR[Tables.mediaRating].ToString();
			description = mediaDR[Tables.mediaDescription].ToString();
			checkedin = Convert.ToDateTime(mediaDR[Tables.mediaCheckedIn]);
			checkedout = Convert.ToDateTime(mediaDR[Tables.mediaCheckedOut]);
			reserved = Convert.ToBoolean(mediaDR[Tables.mediaReserved]);
		}
	}
	
	public class MediaListViewItem : ListViewItem
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
		bool reserved;
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
		
		public bool Reserved
		{
			get { return reserved; }
		}
		#endregion
		
		public MediaListViewItem( DataRow mediaDR )
		{
			mediaID = Convert.ToInt32(mediaDR[Tables.mediaID]);
			//patronID = Convert.ToInt32(mediaDR[Tables.mediaPatronID]);
			type = mediaDR[Tables.mediaType].ToString();
			title = mediaDR[Tables.mediaTitle].ToString();
			rating = mediaDR[Tables.mediaRating].ToString();
			description = mediaDR[Tables.mediaDescription].ToString();
			//checkedin = DateTime.Parse(mediaDR[Tables.mediaCheckedIn].ToString());
			//checkedout = DateTime.Parse(mediaDR[Tables.mediaCheckedOut].ToString());
			//reserved = Convert.ToBoolean(mediaDR[Tables.mediaReserved]);
			SetOption();
			BuildSubItems();
		}
		
		private void BuildSubItems()
		{
			this.SubItems.Add(type);
			this.SubItems.Add(title);
			this.SubItems.Add(description);
			this.SubItems.Add(rating);
			this.SubItems.Add(reserved.ToString());
		}
		
		private void SetOption()
		{
			this.Text = patronID.ToString();
		}
	}
}
