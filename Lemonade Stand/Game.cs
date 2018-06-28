using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Lemonade_Stand
{
    class Game
    {
        Store store;
        Player player;

        public Game(){

            //Day day = new Day();
            player = new Player();
            store = new Store();
        }

        public void RunGame()
        {
            GameDirections();
            StartDayPrompt();
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

            Console.WriteLine(" Here are you starting details: ");
            Day day = new Day();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            day.GetDailyForecast();
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            PurchaseMaterials();
        }


        public  void PurchaseMaterials()
        {
            string response;

            Console.WriteLine("Would you like to purchase more materials. 'yes' 'no' before you start for the day. ");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "yes")
            {
                

                store.StartShopping(player);
                SetRecipe();
            }
            else if (response == "no")
            {
                SetRecipe();

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
            player.GetInventory();
            //Day.GetDailyForecast();
            //display current recipe

            Console.WriteLine("Would you like to change  your recipe before you start for the day. 'yes' 'no' ");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "yes")
            {
                //update recipe and from there continue


            }
            else if (response == "no")
            {

                SetPrice();
            }
            else
            {

                Console.WriteLine("Please follow directions and enter a valid input");
                SetRecipe();

            }

        }
        public  void SetPrice()
        {
            string response;
            //display current price

            Console.WriteLine("Would you like to change  your set price of the product before you start for the day. 'yes' 'no' ");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "yes")
            {
                //update price and from there continue


            }
            else if (response == "no")
            {
                //continue 

            }
            else
            {

                Console.WriteLine("Please follow directions and enter a valid input");
                SetPrice();

            }


        }




    }
}
