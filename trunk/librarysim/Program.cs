using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace librarysim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			Config c;
			string configPathBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"librarysim");
			XmlSerializer s = new XmlSerializer( typeof( Config) );
			//Check if directory exists
			if(!Directory.Exists(configPathBase))
			{
				Directory.CreateDirectory(configPathBase);
			}
			if(File.Exists(Path.Combine(configPathBase,"librarysim.xml")))
			{
				// Deserialization + Import configuration
				TextReader r = new StreamReader( Path.Combine(configPathBase,"librarysim.xml") );
				c = (Config)s.Deserialize( r );
				r.Close();
			}
			else
			{
				//Create New Config
				c = new Config();
			}
			
			//Build Initial Database if it doesn't exist
			Databases.DatabaseBuilder dBuilder = new librarysim.Databases.DatabaseBuilder();
			dBuilder.BuildDatabase();
			
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
			
			// Writing out Config
			TextWriter w = new StreamWriter(Path.Combine(configPathBase,"librarysim.xml"));
			s.Serialize(w, c);
			w.Close();
        }
    }
}
