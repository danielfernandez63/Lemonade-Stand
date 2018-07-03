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
            int min = 40;
            int max = 100;

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
            else if (weather.condition == "Toxic Smog (LOL)")
            {
                min -= 15;
                max -= 15;

            }
            else if (weather.condition == "Cloudy")
            {
                min -= 0;
                max -= 0;

            }
            else if (weather.condition == "Drought like")
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

            player.CupsSold = 0;
            for (i = 0; i < customers.Count; i++)
            {
                customers[i].ChanceBasedOnTemperature(weather);
                customers[i].ChanceBasedOnPrice(player.recipe);

                if (player.Ice < player.recipe.ice)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Oh no, you ran out of ice and had to stop selling for the day! Plan ahead and purchase what you may need for the day!");
                    Console.ReadLine();
                    break;
                }
                if (player.Sugar < player.recipe.sugar)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Oh no, you ran out of sugar and had to stop selling for the day! Plan ahead and purchase what you may need for the day!");
                    Console.ReadLine();
                    break;
                }
                if (player.Lemons < player.recipe.lemons)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Oh no, you ran out of lemons and had to stop selling for the day! Plan ahead and purchase what you may need for the day!");
                    Console.ReadLine();
                    break;
                }
                if (player.Cups < player.recipe.cups)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Oh no, you ran out of cups and had to stop selling for the day! Plan ahead and purchase what you may need for the day!");
                    Console.ReadLine();
                    break;
                }

                int chanceToSale = rnd.Next(1, 101);
               
                 if ((customers[i].percentChanceToBuy > chanceToSale))
                {
                    player.MakeSell();
                }
                else
                {

                }
            }

        }

    }

}
