using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public Recipe recipe;
        double lemons = 0;
        double ice = 0;
        double cups = 0;
        double sugar = 0;
        double money = 20.00;
        double cupsSold = 0.00;
        double totalCupsSold = 0.00;
      
        public Player ()
        {
            recipe = new Recipe();
        }

        public double TotalCupsSold
        {
            get
            {
                return totalCupsSold;
            }

            set
            {
                totalCupsSold = value;
            }

        }
        public double Lemons
        {
            get
            {
                return lemons;        
            }

            set
            {
                lemons = value;
            }

        }

        public double CupsSold
        {
            get
            {
                return cupsSold;
            }

            set
            {
                cupsSold = value;
            }

        }

        public double Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
            }

        }

        public double Cups
        {
            get
            {
                return cups;
            }

            set
            {
                cups = value;
            }

        }

        public double Sugar
        {
            get
            {
                return sugar;
            }

            set
            {
                sugar = value;
            }

        }

        public double Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }

        }

        public void GetInventory()
        {
            Console.WriteLine("Current Inventory is:   Lemons: " + Lemons + "      Ice: " + Ice  +  "      Cups: " + Cups + "      Sugar: " + Sugar + "      Money: " + Money);

        }
        
        public void MakeSell()
        {

            lemons -= recipe.lemons;
            Ice -= recipe.ice;
            Sugar -= recipe.sugar;
            Cups -= recipe.cups;
            Money += recipe.price;
            CupsSold += 1;
            TotalCupsSold += 1;
        }
        
        public void DisplayWeeklyAmount()
        {
            double response = money; 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You sold a total of " + TotalCupsSold + " cups of lemonade so far! ");
            Console.WriteLine("");
            Console.WriteLine("Total amount of money you have made so far: " + (response-=20).ToString("C"));
            Console.ReadLine();
        }

        public void DisplayFinalAmount()
        {
            Console.WriteLine("");
            Console.WriteLine("Congratulations, you have finished the game!");
            Console.WriteLine("");
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }

        public void DisplayDailyAmount()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You sold a total of " + CupsSold + " cups today! Wow");
            Console.WriteLine("");
            Console.WriteLine("You made a total of $" + (CupsSold * recipe.price) + " today!");
            Console.WriteLine("");
        }
        

    }
}
