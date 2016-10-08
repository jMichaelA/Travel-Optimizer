using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOpt
{
    public class Transportation
    {
        private int? _price;
        private string _destination;
        private string _origin;
        public const string _apiStart = "http://api.sandbox.amadeus.com/";
        public const string _apiKey = "bnRwWHdSaSXJMLKtMljloLFf7f6oYlIo";
        public const string _apiVersion = "v1.2";
        private DateTime _departureDay;
        private DateTime _returnDay;

        public int? Cost { get { return _price; } set { _price = value; } }
        public string Destination { get { return _destination; } set { _destination = value; } }
        public string Origin { get { return _origin; } set { _origin = value; } }
        public DateTime DepartureDay { get { return _departureDay; } set { _departureDay = value; } }
        public DateTime ReturnDay { get { return _returnDay; } set { _returnDay = value; } }

        public Transportation()
        {
            _price = null;
            _destination = "";
            _origin = "";
            _departureDay = new DateTime();
            _returnDay = new DateTime();
        }

        public Transportation(int cost, string destination, string origin, DateTime departureDay, DateTime returnDay )
        {
            _price = cost;
            _destination = destination;
            _departureDay = departureDay;
            _returnDay = returnDay;
            _origin = origin;
        }
    }
}
