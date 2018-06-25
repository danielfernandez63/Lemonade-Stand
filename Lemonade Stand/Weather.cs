using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public string temperature;
        public string condition;



        public void GetForecast()
        {
            Random rnd = new Random();
            int temp = rnd.Next(50, 105);
            int cond = rnd.Next(1, 4);

            temperature = temp.ToString();

            if (cond == 1)
            {
             condition = "Hazy";
    
            }
            else if (cond == 2)
            {
             condition = "Sunny and Clear";

            }
            else if (cond == 3)
            {
             condition = "Rainy";

            }
            else
            {
                condition = "Cloudy and Overcast";
                
            }

            Console.WriteLine("The forecast is " + temperature + "° F, with a " + condition + " condition. ");
            Console.ReadLine();

        }

    }
}
