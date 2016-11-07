using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net;

namespace DesktopVoiceAssistant
{
    class WeatherSys
    {
        private const string apikey = "0ce521c9655fd6b32e77b9316280962e";
        internal const string ForecastUrl = "http://api.openweathermap.org/data/2.5/forecast?" +
    "q=@LOC@&mode=xml&units=imperial&APPID=" + apikey;

        //These variables are used to store the weather data from the xml file. We can
        //use them to store their values in the proper text boxes
        public string nodenameid;

        // Return the XML result of the URL.
        public string GetFormattedXml(string url)
        {
            // Create a web client.
            using (System.Net.WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                string xml = client.DownloadString(url);

                // Load the response into an XML document.
                XmlDocument xml_document = new XmlDocument();
                xml_document.LoadXml(xml);

                XmlNode namenode = xml_document.DocumentElement.SelectSingleNode("/weatherdata/location/name");
                nodenameid = Convert.ToString(namenode.SelectSingleNode("/weatherdata/location/name").InnerText);

                // Format the XML.
                using (System.IO.StringWriter string_writer = new StringWriter())
                {
                    XmlTextWriter xml_text_writer =
                        new XmlTextWriter(string_writer);
                    xml_text_writer.Formatting = Formatting.Indented;
                    xml_document.WriteTo(xml_text_writer);
                    
                    // Return the result.
                    return string_writer.ToString();
                }
                
                
            }
        }
        


    }
}
