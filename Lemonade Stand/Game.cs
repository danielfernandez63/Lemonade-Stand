using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Lemonade_Stand
{
    class Game
    {
        RNG rnd;
        Store store;
        Player player;
        Day day;
        int numberOfDays = 7;
        int currentDay = 1;

        public Game()
        {
            player = new Player();
            store = new Store();
            rnd = new RNG();
        }

        public void RunGame()
        {
            GameDirections();
            while (currentDay <= numberOfDays)
            {
                StartDayPrompt();
                currentDay++;
            }
            //finish game method-display
        
        }

        public void GameDirections()
        {
          Console.WriteLine("");
          Console.WriteLine("");
          Console.WriteLine("");
          Console.WriteLine("Welcome to the lemonade stand game. ");
          Console.WriteLine("");
          Console.WriteLine("The object here is to make the maximum amount of money in this game. You will " +
              "start out with $20.00 and will have to purchase your ingredients at the store. Make sure to make smart choices in buying enough" +
              " ingredients to make enough what you need to sell but not too much and waste money. Your recipe you create will be a factor in sales" +
              " so change your recipe to boost sales. Weather will be forecasted but maybe be different during the day and will alter sales as well. " +
              " Sale price will also be a factor in making sales. Use these factors to plan ahead and try and boost sales accordingly. ");
          Console.WriteLine("");
          Console.WriteLine("GOOD LUCK");
          Console.ReadLine();
          Console.Clear();
        }

        public  void StartDayPrompt()
        {
            Console.WriteLine(" Here are the starting details for day:    " + currentDay);
            day = new Day(rnd);
            PurchaseMaterials();
            SetRecipe();
            day.weather.DisplayActualWeather();
            day.StartSelling(player);
            //display results and notify for next day
        }

        public  void PurchaseMaterials()
        {
            string response;
            Console.WriteLine("");
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            player.recipe.DisplayCurrentRecipe(player);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Would you like to purchase more materials. 'yes' 'no' before you start for the day. ");
            response = Console.ReadLine().ToLower().Trim();


            if (response == "yes")
            {
                store.StartShopping(player);
               
            }
            else if (response == "no")
            {
                
            }
            else if (response == "")
            {
                Console.Clear();
                PurchaseMaterials();
            }
            else
            {
                Console.WriteLine("Please follow directions and enter a valid input");
                PurchaseMaterials();
            }

        }

        public  void SetRecipe()
        {
            string response;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            player.recipe.DisplayCurrentRecipe(player);
            Console.WriteLine("");  
            day.weather.DisplayForecastWeather();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Would you like to change  your recipe or price before you start for the day. 'yes' 'no' ");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "yes")
            {
                player.recipe.SetRecipe(player);
                
            }
            else if (response == "no")
            {
                
            }
            else if (response == "")
            {
                //Console.Clear();
                SetRecipe();
            }
            else
            {
                Console.WriteLine("Please follow directions and enter a valid input");
                SetRecipe();
            }

        }




        


    }
}
