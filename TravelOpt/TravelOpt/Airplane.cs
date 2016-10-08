using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TravelOpt
{
    public class Airplane : Transportation, Transport
    {
        private const string _apiMisc = "/flights/inspiration-search?";
        private string _duration;
        private string _maxPrice;

        public void apiComTest()
        {
            DepartureDay = "2016-11-06--2016-11-26";
            Origin = "BOS";
            _duration = "7--9";
            _maxPrice = "500";
            string apiUrl = _apiStart + _apiVersion + _apiMisc + "origin=" + Origin + "&departure_date=" + DepartureDay + "&duration=" + _duration + "&max_prcie=" + _maxPrice + "&apikey=" + _apiKey;
            Console.WriteLine(apiUrl);
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(apiUrl);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            Console.WriteLine(content);
        }

        public void create()
        {
            Console.WriteLine("must create an Airplane");
        }


    }
}
