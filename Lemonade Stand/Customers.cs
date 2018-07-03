using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customers
    {
        public int percentChanceToBuy;



        //   ChanceBasedOnTemperature(weather);
        // ChanceBasedOnPrice();


        public Customers(RNG Rnd)
        {
            percentChanceToBuy = Rnd.GenerateRandomNumber(30, 61);
        }

        public void ChanceBasedOnTemperature(Weather weather) 
        {
            if (weather.actualTemperature < 61 )
            {
                percentChanceToBuy -= 6;
            }
            else if (weather.actualTemperature > 60 && weather.actualTemperature < 81)
            {
                percentChanceToBuy += 0;
            }
            else if (weather.actualTemperature > 80 && weather.actualTemperature < 96)
            {
                percentChanceToBuy += 5;
            }
            else if (weather.actualTemperature > 95)
            {
                percentChanceToBuy += 10;
            }
            
        }

        public void ChanceBasedOnPrice(Recipe recipe)
        {
            if (recipe.price < 0.06)
            {
                percentChanceToBuy = 100;
            }
            else if (recipe.price > 0.05 && recipe.price < 0.16)
            {
                percentChanceToBuy += 20;
            }
            else if (recipe.price > 0.15 && recipe.price < 0.21)
            {
                percentChanceToBuy += 15;
            }
            else if (recipe.price > 0.20 && recipe.price < 0.26)
            {
                percentChanceToBuy += 10;
            }
            else if (recipe.price > 0.25 && recipe.price < 0.31)
            {
                percentChanceToBuy += 5;
            }
            else if (recipe.price > 0.30 && recipe.price < 0.41)
            {
                percentChanceToBuy += 0;
            }
            else if (recipe.price > 0.40 && recipe.price < 0.46)
            {
                percentChanceToBuy -= 5;
            }
            else if (recipe.price > 0.45 && recipe.price < 0.51)
            {
                percentChanceToBuy -= 10;
            }
            else if (recipe.price > 0.50 && recipe.price < 0.61)
            {
                percentChanceToBuy -= 15;
            }
            else if (recipe.price > 0.60 && recipe.price < 0.71)
            {
                percentChanceToBuy -= 20;
            }
            else if (recipe.price > 0.70)
            {
                percentChanceToBuy = 0;
            }

        }

    }
}
