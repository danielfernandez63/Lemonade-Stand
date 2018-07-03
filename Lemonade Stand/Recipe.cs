using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        public double lemons = 1;
        public double ice = 2;
        public double cups = 1;
        public double sugar = .5;
        public double price = 0.30;
        public Recipe()
        {

        }
        public void DisplayCurrentRecipe(Player player)
        {
             
            Console.WriteLine("Current Recipe per cup of lemonade is:       Cups: " + cups    + "        Ice per cup: " + ice + "         Lemons per cup: " + lemons + "          Cups of sugar per cup of lemonade: " + sugar + "           Price per cup: " + price);

        }    
        public void SetRecipe(Player player)
        {
            string response;
            Console.Clear();
            player.GetInventory();
            Console.WriteLine("");
            DisplayCurrentRecipe(player);
            Console.WriteLine("");
            Console.WriteLine("What would you like to change from the recipe above? You do not have to use whole numbers! 'Ice', 'Lemons' " +
                " 'Sugar' 'Price' or 'Done'.");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "ice")
            {
                Console.WriteLine("How much ice per cup? ");
                ice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Change was succesful!");
                Console.ReadLine();
                SetRecipe(player);
            }
        else if (response == "lemons")
            {
                Console.WriteLine("How many lemons per cup? ");
                lemons = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Change was succesful!");
                Console.ReadLine();
                SetRecipe(player);
            }
            else if (response == "sugar")
            {
                Console.WriteLine("How much sugar per cup? ");
                sugar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Change was succesful!");
                Console.ReadLine();
                SetRecipe(player);
            }
            else if (response == "price")
            {
                Console.WriteLine("Price per cup of lemonade? ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Change was succesful!");
                Console.ReadLine();
                SetRecipe(player);
            }
            else if (response == "done")
            {

            }
            else 
            {
                Console.WriteLine("You did not follow directions and enter a valid response. Please alter answer and respond.");
                Console.ReadLine();
                SetRecipe(player);
            }

        }

    }

}
