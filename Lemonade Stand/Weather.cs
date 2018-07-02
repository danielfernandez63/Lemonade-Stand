using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
       
        public int temperature;
        public string condition;
        public int actualTemperature;

        public void GetForecast()
        {
            Random rnd = new Random();
            temperature = rnd.Next(50, 105);
            int cond = rnd.Next(1, 5);

            if (cond == 1)
            {
                condition = "Toxic Smog LOL";

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
                condition = "Drought";

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
            //Console.Clear();
           Console.WriteLine("The actual weather is " + actualTemperature + "° F, with a " + condition + " condition. ");

        }


    }
}
