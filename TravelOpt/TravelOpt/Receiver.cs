using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelFactory;

namespace TravelOpt
{
    public class Receiver
    {
        private DateTime _departureDate;
        private String _origin;
        private String _maxPrice;

        public Receiver(DateTime departureDate, String origin, String maxPrice)
        {
            _departureDate = departureDate;
            _origin = origin;
            _maxPrice = maxPrice;
        }

        public void getTransport(String transport)
        {
            Train tempTrain = new Train();
            Airplane tempAirplane = new Airplane();
            ApiParser parse = new ApiParser();
            List<Train> trains = new List<Train> { };
            List<Train> airplaneRes = new List<Train> { };

            if (transport == "railroad")
            {
               trains = parse.getTrains(_departureDate, _origin, _maxPrice);
               TrainUI trainSubject = new TrainUI(trains);
               trainSubject.Show();
            }
            else if(transport == "airplane")
            {
                Console.WriteLine("Implement airport in Receiver");
            }
        }
    }
}
