using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOpt
{
    public class ApiParser
    {

        public void jsonTest()
        {
            Train train = new Train();
            string json = train.apiComTest();
            Console.WriteLine(json);

            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(User));
            //User user = (User)serializer.ReadObject(responseStream);

            //bool isMember = user.IsMember;
            //string name = user.Name;
            //int age = user.Age;
        }
    }
}
