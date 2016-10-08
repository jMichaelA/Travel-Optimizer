using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TravelOpt
{
    public class ApiParser
    {
        private DateTime _departureDay;
        private String _origin;
        private String _maxPrice;
        public const string _apiStart = "http://api.sandbox.amadeus.com/";
        public const string _apiKey = "bnRwWHdSaSXJMLKtMljloLFf7f6oYlIo";
        public const string _apiVersion = "v1.2";
        public const string _apiMiscTrain = "/trains/schedule-search?";

        public ApiParser(DateTime departureDay, String origin, String maxPrice)
        {
            _departureDay = departureDay;
            _origin = origin;
            _maxPrice = maxPrice;
        }

        public List<Train> getTrains()
        {
            List<Train> trains = new List<Train>();

            Console.WriteLine(_origin);
            string apiUrl = _apiStart + _apiVersion + _apiMiscTrain + "origin=" + _origin + "&departure_date=" + _departureDay.ToString("yyyy-MM-dd") + "&apikey=" + _apiKey;
            Console.WriteLine(apiUrl);
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(apiUrl);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            JObject jo = getJsonObj(content);

            if (jo["results"].Count() > 0)
            {
                trains = parseTrain(jo["results"][0]);
            }
            return trains;
        }

        private List<Train> parseTrain(JToken jToken)
        {
            List<Train> trains = new List<Train>();
            for (int i = 0; i < jToken["services"].Count(); ++i)
            {
                trains.Add(new Train(jToken["services"][i]["destination_station_id"].ToString(), jToken["services"][i]["departure_times"][0].ToString()));
            }
            return trains;
        }

        public JObject getJsonObj(String json)
        {
            JObject o2 = new JObject();
            using (JsonTextReader reader = new JsonTextReader(new StringReader(json)))
            {
                o2 = (JObject)JToken.ReadFrom(reader);
                //Console.WriteLine(o2["results"]);
            }
            return o2;
        }

        public void jsonTest()
        {
            //Train train = new Train();
            //string json = train.apiComTest();
            //Console.WriteLine(json);

            
            //using (JsonTextReader reader = new JsonTextReader(new StringReader(json)))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);                
            //    Console.WriteLine(o2["results"][0]);
            //    //Console.WriteLine(o2["results"][0]["services"][0]);
            //}

            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(User));
            //User user = (User)serializer.ReadObject(responseStream);

            //bool isMember = user.IsMember;
            //string name = user.Name;
            //int age = user.Age;
        }

    }
}
