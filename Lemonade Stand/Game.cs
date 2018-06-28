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
          Console.WriteLine("Welcome to the lemonade stand game. The object here is to make the maximum amount of money possible in the game... etc");
          Console.ReadLine();
        }

        public  void StartDayPrompt()
        {

            Console.WriteLine(" Here are some starting details for the day use this to follow through. ");
            Day day = new Day();
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
