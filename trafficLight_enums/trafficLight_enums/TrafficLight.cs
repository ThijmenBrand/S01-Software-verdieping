using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traffic
{
    public enum TrafficLightColors
    {
        Red,
        Orange,
        Green
    }

    class TrafficLight
    {

        public TrafficLightColors color;


        public TrafficLight()
        {
            color = TrafficLightColors.Red;
        }

        public void NextState()
        {
            switch (color)
            {
                case TrafficLightColors.Red:
                    color = TrafficLightColors.Green;
                    break;
                case TrafficLightColors.Green:
                    color = TrafficLightColors.Orange;
                    break;
                case TrafficLightColors.Orange:
                    color = TrafficLightColors.Red;
                    break;
            }
        }

        public TrafficLightColors GetCurrentcolor()
        {
            return this.color;
        }
    }
}

