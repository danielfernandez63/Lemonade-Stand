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
      
        public Player ()
        {
            recipe = new Recipe();
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

        }
        



    }
}
