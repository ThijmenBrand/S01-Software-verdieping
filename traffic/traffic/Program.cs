using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traffic
{
    internal class program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            // color has to be "Red".
            Console.WriteLine(trafficLight.GetCurrentcolor());
            trafficLight.NextState();
            // color has to be "green".
            Console.WriteLine(trafficLight.GetCurrentcolor());
            trafficLight.NextState();
            // color has to be "oranje".
            Console.WriteLine(trafficLight.GetCurrentcolor());
            trafficLight.NextState();
            // and 'red' again!
            Console.WriteLine(trafficLight.GetCurrentcolor());
        }
    }
}
