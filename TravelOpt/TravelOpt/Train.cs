using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOpt 
{
    class Train : Transportation, Create
    {
        public void create()
        {
            Console.WriteLine("Must create a train");
        }
    }
}
