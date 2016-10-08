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

        public Airplane(int cost, string destination, string origin, DateTime departureDay, DateTime returnDay, string maxPrice)
        {
            Cost = cost;
            Destination = destination;
            Origin = origin;
            DepartureDay = departureDay;
            ReturnDay = returnDay;
            _duration = "";
            _maxPrice = maxPrice;
        }

        public String apiComTest()
        {
            DepartureDay = Convert.ToDateTime("2016-11-06");
            ReturnDay = Convert.ToDateTime("2016-11-26");
            Origin = "BOS";
            //_duration = "7--9";
            _maxPrice = "500";
            _duration = (ReturnDay.Day - DepartureDay.Day) + "--" + (ReturnDay.Day - DepartureDay.Day + 3);
            if (ReturnDay.Day - DepartureDay.Day > 15)
            {
                _duration = "10--15";
            }
            string apiUrl = _apiStart + _apiVersion + _apiMisc + "origin=" + Origin + "&departure_date=" + DepartureDay.ToString("yyyy-MM-dd")+"--"+ReturnDay.ToString("yyyy-MM-dd") + "&duration=" + _duration + "&max_prcie=" + _maxPrice + "&apikey=" + _apiKey;
            Console.WriteLine(apiUrl);
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(apiUrl);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            return content;
        }
    }
}
