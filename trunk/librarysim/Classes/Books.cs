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
		DateTime checkedout;
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
		
		public DateTime Checkedout
		{
			get { return checkedout; }
		}

		#endregion
		
		public Books( DataRow booksDR )
		{
			booksID = Convert.ToInt32(booksDR[Tables.bookID]);
      try
      {
        patronID = Convert.ToInt32(booksDR[Tables.bookPatronID]);
      }
      catch (Exception) { }
      type = booksDR[Tables.bookType].ToString();
			title = booksDR[Tables.bookTitle].ToString();
			author = booksDR[Tables.bookAuthor].ToString();
			description = booksDR[Tables.bookDescription].ToString();
			//checkedout = Convert.ToDateTime(booksDR[Tables.bookCheckedOut]);
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
		DateTime checkedout;
		string dateTest;
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
		
		public DateTime Checkedout
		{
			get { return checkedout; }
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
			dateTest = booksDR[Tables.bookCheckedOut].ToString();
			Console.WriteLine("Date Test is: {0}", dateTest);
			if(dateTest != string.Empty)
			{
				checkedout = DateTime.Parse(dateTest);
			}
			
			SetOption();
			BuildSubItems();
		}
		
		private void BuildSubItems()
		{
			this.SubItems.Add(type);
			this.SubItems.Add(title);
			this.SubItems.Add(description);
			this.SubItems.Add(author);
			this.SubItems.Add("");
			if(dateTest == string.Empty)
			{
				this.SubItems.Add(string.Empty);
			}
			else
			{
				this.SubItems.Add(checkedout.ToString());
			}
		}
		
		private void SetOption()
		{
			this.Text = patronID.ToString();
		}
	}
}
