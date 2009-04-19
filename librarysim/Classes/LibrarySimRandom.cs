using System;
using System.Collections;
using System.Collections.Generic;

namespace librarysim.Classes
{
	
	public class LibrarySimRandom
	{

		#region Variables
		Random random = new Random();
		string[] maleFirstName = {"James","John","Robert","Michael","David","Richard","Charles","Joseph","Thomas","Christopher","Daniel",
			"Paul","Mark","Donald","George","Kenneth","Steven","Edward","Brian","Ronald","Anthony","Kevin","Jason","Matthew","Gary","Timothy",
			"Jose","Larry","Jeffery","Frank","Scott","Eric","Stephen","Andrew","Raymond","Gregory","Joshua","Jerry","Dennis","Walter","Patrick",
			"Peter","Harold","Douglas","Henry","Carl","Arthur","Ryan","Roger","Joe","Juan","Jack","Devon","Adolfo","Harrison","Tyson","Burton",
			"Tyson","Brady","Elliott","Wilfredo","Bart","Jarrod","Vance","Denis","Damien","Ashley","Joaquin","Harlan","Desmond","Darwin","Xavier"};
		string[] femaleFirstName = {"Mary","Linda","Barbara","Elizabeth","Jennifer","Maria","Susan","Margaret","Dorothy","Lisa","Nancy","Betty",
			"Helen","Sandra","Donna","Carol","Ruth","Sharon","Patricia","Michelle","Laura","Sarah","Kimberly","Deborah","Jessica","Shirley","Cythia",
			"Angela","Melissa","Brenda","Amy","Anna","Rebecca","Virginia","Kathleen","Pamela","Martha","Debra","Amanda","Stephanie","Carolyn","Christine",
			"Marie","Janet","Catherine","Frances","Ann","Joyce","Diane","Alice","Julie","Heather","Teresa","Doris","Gloria","Evelyn","Jean","Cheryl",
			"Mildred","Katherine","Joan","Shelia","Gayle","Della","Vicky","Lynne","Sheri","Marianne","Kara","Erma","Pat","Myra","Leticia","Francis"};
		string[] lastName = {"Smith","Johnson","Williams","Jones","Brown","Davis","Miller","Wilson","Moore","Taylor","Anderson","Thomas","Jackson","White",
			"Harris","Martin","Thompson","Garcia","Martinez","Robinson","Clark","Rodriguez","Lewis","Lee","Walker","Hall","Allen","Young","Hernandez","King",
			"Wright","lopez","Hill","Scott","Green","Adams","Baker","Gonzalez","Nelson","Carter","Mitchell","Perez","Roberts","Turner","Phillips","Campbell",
			"Parker","Evans","Edwards","Collins","Stewart","Sanchez","Morris","Rogers","Reed","Cook","Morgan","Bill","Murphy","Bailey","Rivera","Cooper",
			"Huff","Clayton","Massey","Lloyd","Figueroa","Carson","Bowers","Roberson","Barton","Tran","Lamb","Harrington","Casey","Boone","Cortez","Clarke",
			"Mathis","Singleton","Wilkins","Cain","Bryan","Underwood","Hogan","McKenzie","Collier","Luna","Phelps","McGuire","Allison","Bridges","Wilkerson",
			"Nash","Summers","Atkins","Wilcox","Pitts","Conley","Marquez","Burnett","Richard","Cochran","Chase","Davenport","Hood","Gates","Clay","Ayala",
			"Sawyer","Roman","Vazquez","Dickerson","Hodge","Acosta","Flynn","Espinoza","Nicholson","Monroe","Wolf","Morrow","Kirk","Ricks","Holliday","Ferris",
			"Hairston","Sheffield","Lange","Fountain","Marino","Doss","Betts","Kaplan","Carmichael","Bloom","Ruffin","Penn","Kern","Bowles","Sizemore","Larkin",
			"Dupree","Jewell","Silver","Seals","Metcalf","Hutchison","Henley","Farr","Castle","McCauley","Hankins","Gustafson","Deal","Curran","Ash","Waddell",
			"Ramey","Cates","Pollock","Major","Irvin","Cummins","Messer","Heller","Dewitt","Lin","Funk","Cornett","Palacios","Galindo","Cano","Hathaway","Singer"};
		string[] cityNames = {"Alpine","Alta","Altamont","Alton","Amalga","American Fork","Annabella","Antimony","Aurora","Ballard","Bear River City","Beaver",
			"Bicknell","Big Water","Blanding","Bluffdale","Boulder","Bountiful","Brian Head","Brigham City","Cannonville","Canyon Rim","Castle Dale","Castle Valley",
			"Cedar City","Cedar Fort","Cedar Hills","Centerfield","Centerville","Charleston","Circleville","Clarkston","Clawson","Clearfield","Cleveland","Clinton",
			"Coalville","Corinne","Cornish","Cottonwood Heights","Cottonwood West","Delta","Deweyville","Draper","Duchesne","Dugway","East Carbon","East Millcreek",
			"Elk Ridge","Elmo","Elsinore","Elwood","Emery","Enoch","Enterprise","Ephraim","Erda","Escalante","Eureka","Fairview","Farmington","Farr West","Moroni",
			"Mount Carmel","Mount Carmel Junction","Mount Olympus","Mount Pleasant","Murray","Myton","Naples","Neola","Nephi","New Harmony","Newton","Nibley","North Logan",
			"North Ogden","North Salt Lake","Oak City","Oakley","Ogden","Ophir","Oquirrh","Orangeville","Orderville","Orem","Panguitch","Paradise","Paragonah","Park City",
			"Parowan","Payson","Perry","Plain City","Pleasant Grove","Pleasant View","Plymouth","Portage","Price","Providence","Provo","Randlett","Randolph","Redmond",
			"Richfield","Richmond","River Heights","Riverdale","Riverton","Rockville","Roosevelt","Roy","Rush Valley","Salem","Salina","Waco  Waco  Waco","Waskom",
			"Watauga","Waxahachie","Weatherford","Webberville","Webster","Weslaco","West Columbia","West Lake Hills","West Orange","West University Place","Westlake",
			"Wheeler","White Oak","White Settlement","Whitehouse","Wichita Falls","Willow Park","Wimberley","Windrest","Winnie","Winters","Wixon Valley","Wolfe City",
			"Woodlake","Woodlawn","Woodville","Woodway","Wortham","Wylie","Yoakum","Zapata","Zavalla","Basin","Buffalo","Casper","Cheyenne","Cody","Douglas","Evanston",
			"Gillette","Green River","Kemmerer","Lander","Laramie","Newcastle","Powell","Rawlins","Riverton","Rock Springs","Sheridan","Torrington"};
		string[] STATES = {"AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA","HI","ID","IL","IN","IA","KS","KY","LA","ME","MD","MA","MI","MN","MS","MO","MT","NE","NV",
			"NH","NJ","NM","NY","NC","ND","OH","OK","OR","PA","RI","SC","SD","TN","TX","UT","VT","VI","VA","WA","WV","WI","WY"};
		string[] NORSOU = {"N","S"};
		string[] EASWES = {"E","W"};
		string[] AGE = {"adult","child"};
		String[] GENDER = {"male","female"};		
		#endregion
		
		public LibrarySimRandom()
		{
			
		}
		
		private int grn(int low, int high)
		{
			return random.Next(low, high);
		}

		#region Random Patron Stuff
		public string RandomGender( )
		{
			return GENDER[grn(0, GENDER.Length)];
		}
		public string RandomMalePerson( )
		{
			return string.Format( maleFirstName[grn(0, maleFirstName.Length)] + " " + lastName[grn(0, lastName.Length)]);
		}
		
		public string RandomFemalePerson( )
		{
			return string.Format( femaleFirstName[grn(0, femaleFirstName.Length)] + " " + lastName[grn(0, lastName.Length)]);
		}
		
		public string RandomPhoneNumber( )
		{
			string sAreaCode = (grn(100, 999)).ToString();
			string sFirstThree = (grn(100, 999)).ToString();
			string sLastFour = (grn(0, 9999)).ToString();
			
			while( sLastFour.Length < 4)
			{
				sLastFour = '0' + sLastFour;
			}
			
			return string.Format(sAreaCode + sFirstThree + sLastFour);
		}

		public string RandomAddress()
		{
			return string.Format(grn(0, 1600).ToString() + " " + NORSOU[grn(0, NORSOU.Length)] + " " 
				+ grn(0, 1600).ToString() + " " + EASWES[grn(0, EASWES.Length)]
				+ cityNames[grn(0, cityNames.Length)] + ", " + STATES[grn(0, STATES.Length)] + " " + GenerateZipCode());
		}

		private string GenerateZipCode()
		{
			string zipCode = (grn(0, 99999)).ToString();
			while (zipCode.Length < 5)
			{
				zipCode = '0' + zipCode;
			}
			return zipCode;
		}
		
		public string RandomAge( )
		{
			return AGE[grn(0, AGE.Length)];
		}
		#endregion

	}
}
