using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {      
        public int temperature;
        public string condition;
        public int actualTemperature;

        internal Day Day
        {
            get => default(Day);
            set
            {
            }
        }

        public void GetForecast()
        {
            Random rnd = new Random();
            temperature = rnd.Next(40, 106);
            int cond = rnd.Next(1, 5);

            if (cond == 1)
            {
                condition = "Toxic Smog (LOL)";
            }
            else if (cond == 2)
            {
                condition = "Sunny";
            }
            else if (cond == 3)
            {
                condition = "Rainy";
            }
            else if (cond == 4)
            {
                condition = "Drought like";
            }
            else
            {
                condition = "Cloudy";
            }
        }

        public void DisplayForecastWeather()
        {
            Console.WriteLine("The forecast is " + temperature + "° F, with a " + condition + " condition. ");
        }

        public void GetActualWeather()
        {
            Random rnd = new Random();
            actualTemperature = rnd.Next(temperature - 10, temperature + 10);
        }

        public void DisplayActualWeather()
        {
           Console.Clear();
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("Oh no, the actual weather was slightly different! This may have impacted sales today! " );
           Console.WriteLine("");
           Console.WriteLine("The actual weather today was " + actualTemperature + "° F, and " + condition + ". ");
        }

    }

}
