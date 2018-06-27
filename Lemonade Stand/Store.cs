using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        
        //buying more items and adding to inventory

        public Store()
        {
            //this.player = player;

            //Console.WriteLine("you have " + player.Lemons);

            

        }
        
        public void BuyLemons(Player player)
        {
            string response;
            Console.WriteLine("Do you want to buy ten lemons for 10 cents? yes or no?");
            response = Console.ReadLine().ToString().Trim();

                if (response == "yes")
            {
                player.Lemons += 10;
                player.Money -= 10;

            }
                else if ( response == "no")
            {
                //go to next option. 

            }
                else
            {
                Console.WriteLine("Answer is invalid, read prompt and answer accordingly");
                Console.ReadLine();
                BuyLemons(player);
            }


        }





    }
}
