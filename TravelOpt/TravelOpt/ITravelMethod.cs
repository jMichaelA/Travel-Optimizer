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

    public class Airplane : ITravelMethod
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

    public class Train : ITravelMethod
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
                    return new Airplane();
                case TransportType.train:
                    return new Train();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
