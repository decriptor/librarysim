using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace librarysim.Classes
{	
	//[XmlRoot("librarysimconfig")]
	[Serializable]
	public class Config
	{
		#region Patron Settings
		//All periods are in days
		private int adultPeriodInDays = 14;
		private int childrenPeriodInDays = 7;
		private int dvdPeriodInDays = 2;
		private int videoTapePeriodInDays = 3;
		//Limits are just numerical quantities
		private int adultBookLimit = 6;
		private int childrenBookLimit = 3;
		//All age delimiters are in years
		private int adultChildrenAgeDelimiter = 13;
		#endregion
		
		#region Database Settings

		private string dbLocation = "URI=file:" + Path.Combine(
                                       Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
		                               Path.Combine("librarysim", "librarysim.db"));
		#endregion
		
		#region Properties
		public int AdultPeriodInDays
		{
			get{ return adultPeriodInDays; }
			set{ adultPeriodInDays = value; }
		}
		
		public int ChildrenPeriodInDays
		{
			get{ return childrenPeriodInDays; }
			set{ childrenPeriodInDays = value; }
		}
		
		public int DvdPeriodInDays
		{
			get{ return dvdPeriodInDays; }
			set{ dvdPeriodInDays = value; }
		}
		
		public int VideoTapePeriodInDays
		{
			get{ return videoTapePeriodInDays; }
			set{ videoTapePeriodInDays = value; }
		}
		
		public int AdultBookLimit
		{
			get{ return adultBookLimit; }
			set{ adultBookLimit = value; }
		}
		
		public int ChildrenBookLimit
		{
			get{ return childrenBookLimit; }
			set{ childrenBookLimit = value; }
		}
		
		public int AdultChildrenAgeDelimiter
		{
			get{ return adultChildrenAgeDelimiter; }
			set{ adultChildrenAgeDelimiter = value; }
		}
		
		public string DbLocation
		{
			get{ return dbLocation; }
			set{ dbLocation = value; }
		}
		#endregion
		
		public Config()
		{

		}
		
		
		
	}
}
