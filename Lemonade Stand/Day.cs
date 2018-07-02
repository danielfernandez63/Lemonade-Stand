using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        public Weather weather;

        List <Customers> customers;

        public Day(RNG rnd)
        {
            weather = new Weather();
            customers = new List<Customers>();
            GenerateCustomers(rnd);
            weather.GetForecast();
            weather.GetActualWeather();
        }

     
        public void GenerateCustomers(RNG Rnd)
        {
            int min = 60;
            int max = 125;

            if(weather.condition == "Sunny")
            {
                min += 10;
                max += 10;

            }

            else if (weather.condition == "Rainy")
            {
                min -= 10;
                max -= 10;

            }
            else if (weather.condition == "Toxic Smog LOL")
            {
                min -= 15;
                max -= 15;

            }
            else if (weather.condition == "Cloudy")
            {
                min -= 0;
                max -= 0;

            }
            else if (weather.condition == "Drought")
            {
                min += 15;
                max += 15;

            }

            int numberOfCustomers = Rnd.GenerateRandomNumber(min, max);

            for (int i = 0; i < numberOfCustomers; i++)
            {
                customers.Add(new Customers(Rnd));


            }



        }
        
               
        public void StartSelling(Player player)
        {
            int i;
            Random rnd = new Random();
            

            for (i = 0; i < customers.Count; i++)
            {

                //if()
                //{
                //    break;
                //}

                int chanceToSale = rnd.Next(1, 101);

               
                 if ((customers[i].percentChanceToBuy < chanceToSale))
                {
                    player.MakeSell();

                }
                else
                {


                }

            }


        }


        // if ((customers[i].percentChanceToBuy % chanceToSale) != 0)



    }
}
