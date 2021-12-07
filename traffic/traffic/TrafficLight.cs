using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traffic
{
    internal class TrafficLight
    {
        public string color { get; private set; }

        public TrafficLight()
        {
            this.color = "red";
        }

        public void NextState()
        {
            switch(color)
            {
                case "red": color = "green";
                    break;
                case "green": color = "orange";
                    break;
                case "orange": color = "red";
                    break;
            }
        }

        public string GetCurrentcolor()
        {
            return this.color;
        }
    }
}
