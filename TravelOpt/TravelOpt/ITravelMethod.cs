using System;
using System.Collections.Generic;

namespace TravelFactory
{
    public interface ITravelMethod
    {
        String getMethod();
        List<String> getLocations();
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
        public List<String> getLocations()
        {
            return locations;
        }
        public void convertSymbolToLocation()
        {

        }
    }

    public partial class TrainUI : System.Windows.Forms.Form, ITravelMethod
    {
        private List<String> locations;
        public String getMethod()
        {
            return "Train *CHOO CHOO*";
        }
        public List<String> getLocations()
        {
            return locations;
        }
        public void convertSymbolToLocation()
        {

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
