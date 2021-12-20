using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traffic
{
    class trafficLight_enums
    {
        public static void Main()
        {
            TrafficLight TrafficLight = new TrafficLight();

            Console.WriteLine(TrafficLight.GetCurrentcolor());

            TrafficLight.NextState();

            Console.WriteLine(TrafficLight.GetCurrentcolor());

            TrafficLight.NextState();

            Console.WriteLine(TrafficLight.GetCurrentcolor());
        }
    }
}