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

            Day day = new Day();
            player = new Player();
            store = new Store();
        }

        public void RunGame()
        {
            GameDirections();

            StartDayPrompt();

            //Store store = new Store();
           

        }

        public void GameDirections()
        {
          Console.WriteLine("Welcome to the lemonade stand game. The object here is to make the maximum amount of money possible in the game... etc");
          Console.ReadLine();

        }

        public static void StartDayPrompt()
        {

            Console.WriteLine(" Here are some starting details for the day use this to follow through. ");
            Day day = new Day();
            day.GetDailyForecast();
            Console.ReadLine();
            // Console.WriteLine("Current inventory is");
            //display inventory
            //Console.ReadLine();
            PurchaseMaterials();
        }


        public static void PurchaseMaterials()
        {
            string response;
            //current  amount of money
            Console.WriteLine("Would you like to purchase more materials. 'yes' 'no' before you start for the day. ");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "yes")
            {
                //update materials and from the end of that go to change recipe


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

        public static void SetRecipe()
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
        public static void SetPrice()
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
