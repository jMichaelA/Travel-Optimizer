using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TravelOpt 
{
    class Train : Transportation, Transport
    {
        private const string _apiMisc = "/trains/schedule-search?";

        public void create()
        {
            Console.WriteLine("Must create a train");
        }

        public void apiComTest()
        {
            DepartureDay = "2016-10-13";
            Origin = "8302589";
            string apiUrl = _apiStart + _apiVersion + _apiMisc + "origin="+ Origin +"&departure_date=" + DepartureDay +"&apikey=" + _apiKey;
            Console.WriteLine(apiUrl);
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(apiUrl);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
