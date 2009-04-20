using System;
using System.Data;
using System.Windows.Forms;

using librarysim.Backend;

namespace librarysim.Classes
{
	public class Books
	{
		#region Variables
		int booksID;
		int patronID;
		string type;
		string title;
		string author;
		string description;
		DateTime checkedin;
		DateTime checkedout;
		bool reserved;
		#endregion
		
		#region Properties
		public int BooksID
		{
			get { return booksID; }
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
		
		public bool Reserved
		{
			get { return reserved; }
		}
		#endregion
		
		public Books( DataRow booksDR )
		{
			booksID = Convert.ToInt32(booksDR[Tables.bookID]);
			patronID = Convert.ToInt32(booksDR[Tables.bookPatronID]);
			type = booksDR[Tables.bookType].ToString();
			title = booksDR[Tables.bookTitle].ToString();
			author = booksDR[Tables.bookAuthor].ToString();
			description = booksDR[Tables.bookDescription].ToString();
			checkedin = Convert.ToDateTime(booksDR[Tables.bookCheckedIn]);
			checkedout = Convert.ToDateTime(booksDR[Tables.bookCheckedOut]);
			reserved = Convert.ToBoolean(booksDR[Tables.bookReserved]);
		}
	}
	
	public class BooksListViewItem : ListViewItem
	{
		#region Variables
		int booksID;
		int patronID;
		string type;
		string title;
		string author;
		string description;
		DateTime checkedin;
		DateTime checkedout;
		bool reserved;
		#endregion
		
		#region Properties
		public int BooksID
		{
			get { return booksID; }
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
		
		public bool Reserved
		{
			get { return reserved; }
		}
		#endregion
		
		public BooksListViewItem( DataRow booksDR )
		{
			booksID = Convert.ToInt32(booksDR[Tables.bookID]);
			//patronID = Convert.ToInt32(booksDR[Tables.bookPatronID]);
			type = booksDR[Tables.bookType].ToString();
			title = booksDR[Tables.bookTitle].ToString();
			author = booksDR[Tables.bookAuthor].ToString();
			description = booksDR[Tables.bookDescription].ToString();
			//checkedin = DateTime.Parse(booksDR[Tables.bookCheckedIn].ToString());
			//checkedout = DateTime.Parse(booksDR[Tables.bookCheckedOut].ToString());
			//reserved = Convert.ToBoolean(booksDR[Tables.bookReserved]);SetOption();
			SetOption();
			BuildSubItems();
		}
		
		private void BuildSubItems()
		{
			this.SubItems.Add(type);
			this.SubItems.Add(title);
			this.SubItems.Add(description);
			this.SubItems.Add(author);
			this.SubItems.Add(reserved.ToString());
		}
		
		private void SetOption()
		{
			this.Text = patronID.ToString();
		}
	}
}
