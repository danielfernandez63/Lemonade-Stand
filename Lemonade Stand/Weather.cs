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
        public string actualCondition;



        public void GetForecast()
        {
            Random rnd = new Random();
            temperature = rnd.Next(50, 105);
            int cond = rnd.Next(1, 4);



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

        }

        public void GetActualWeather()
        {
            Random rnd = new Random();
            actualTemperature = rnd.Next(temperature - 10, temperature + 10);

            int cond = rnd.Next(1, 4);



            if (cond == 1)
            {
                actualCondition = "Hazy";

            }
            else if (cond == 2)
            {
                actualCondition = "Sunny and Clear";

            }
            else if (cond == 3)
            {
                actualCondition = "Rainy";

            }
            else
            {
                actualCondition = "Cloudy and Overcast";

            }

            Console.WriteLine("The actual weather is " + actualTemperature + "° F, with a " + actualCondition + " condition. ");

        }

    }
}
