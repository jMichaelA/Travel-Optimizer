using System;
using System.Collections.Generic;
using TravelOpt;

namespace TravelFactory
{
    public interface ITravelMethod
    {
        String getMethod();
        void getLocations();
        void convertSymbolToLocation();
    }

    public enum TransportType
    {
        airplane,
        train
    }

    public partial class AirplaneUI : System.Windows.Forms.Form, ITravelMethod
    {
        private List<String> locations;
        public String getMethod()
        {
            return "Airplane";
        }
        public void getLocations()
        {
            
        }
        public void convertSymbolToLocation()
        {

        }
    }

    public partial class TrainUI : System.Windows.Forms.Form, ITravelMethod
    {
        private List<String> _locations = new List<String> { };
        private List<String> _departureTimes = new List<String> { };
        private List<Train> _trains;

        public TrainUI(List<Train> trains)
        {
            InitializeComponent();
            _trains = trains;
            getLocations();
            addLocationsToList();
        }

        public String getMethod()
        {
            return "Train *CHOO CHOO*";
        }
        public void getLocations()
        {
            foreach (var train in _trains)
            {
                if(train.Destination != "")
                {
                    _locations.Add(train.Destination);
                    _departureTimes.Add(train.ChildDepartureDay);
                }
            }
        }
        public void convertSymbolToLocation()
        {

        }
        public void addLocationsToList()
        {
            foreach (var train in _trains)
            {
                if(train.Destination != "")
                {
                    this.destinationList.Items.Add(train.Destination);
                    this.timesListBox.Items.Add(train.ChildDepartureDay);
                    Console.WriteLine("\n\n gasp");
                }
            }
        }
    }

    public class transportFactory
    {
        public ITravelMethod getTransport(TransportType type)
        {
            switch (type)
            {
                case TransportType.airplane:
                    return new AirplaneUI();
                case TransportType.train:
                    return new TrainUI();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
