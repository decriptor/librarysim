using System;

namespace librarysim.Backend
{
	public static class Tables
	{
		#region Patrons Table Columns
		public static string patronID = 		"ID";
		public static string patronName = 		"Name";
		public static string patronPhoneNumber ="PhoneNumber";
		public static string patronAddress = 	"Address";
		public static string patronGender = 	"Gender";
		public static string patronDateOfBirth ="DOB";
		#endregion
		
		#region Books Table Columns
		public static string bookID = 			"ID";
		public static string bookPatronID = 	"Patron";
		public static string bookType = 		"Type";
		public static string bookTitle = 		"Title";
		public static string bookAuthor = 		"Author";
		public static string bookDescription = 	"Description";
		public static string bookCheckedIn =	"Checkedin";
		public static string bookCheckedOut =	"Checkedout";
		public static string bookReserved =		"Reserved";
		#endregion
		
		#region Media Table Columns
		public static string mediaID = 			"ID";
		public static string mediaPatronID = 	"Patron";
		public static string mediaType = 		"Type";
		public static string mediaTitle = 		"Title";
		public static string mediaRating = 		"Rating";
		public static string mediaDescription = "Description";
		public static string mediaCheckedIn =	"Checkedin";
		public static string mediaCheckedOut =	"Checkedout";
		public static string mediaReserved =	"Reserved";
		#endregion

	}
}
