using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {

        public int lemons = 0;
        public int ice = 0;
        public int cups = 0;
        public int sugar = 0;
        public double money = 20.00;

        //recipe 

        public int Lemons
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

        public int Ice
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

        public int Cups
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

        public int Sugar
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
        

        

        



    }
}
