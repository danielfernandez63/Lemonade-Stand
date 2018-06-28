using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        
        

        public Store()
        {
            //this.player = player;

            //Console.WriteLine("you have " + player.Lemons);

            

        }
        
        public void StartShopping(Player player)
        {
            string response;
            Console.WriteLine("");
            Console.WriteLine("Welcome to Dan's Mega Store Emporium. What would you like to buy? Options are 'lemons', 'ice', 'cups', sugar' or 'done'.");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "lemons")
            {
                BuyLemons(player);

            }

            else if (response == "ice")
            {


            }

            else if (response == "cups")
            {


            }

            else if (response == "sugar")
            {


            }

            else if (response == "done")
            {


            }

            else 
            {
                Console.WriteLine("Answer is invalid, read prompt and answer accordingly");
                Console.ReadLine();
                StartShopping(player);
            }


        }

        public void BuyLemons(Player player)
        {
            string response;
            Console.WriteLine("");
            Console.WriteLine("Lemons are currently on sale! Check out these crazy deals!");   
            Console.WriteLine("10 lemons for 0.64$.");
            Console.WriteLine("30 lemons for 2.16$.");
            Console.WriteLine("75 lemons for 4.19$.");
            Console.WriteLine("");
            Console.WriteLine(" Enter the number you would like to purchase, '10','30','75', or 'return'.");        
            response = Console.ReadLine().ToLower().Trim();

            if (response == "10")
            {
                if (player.money > 0.64)
                {
                    player.Lemons += 10;
                    player.Money -= 0.64;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyLemons(player);
                }

            }
            else if ( response == "30")
            {
                if (player.money > 2.16)
                {
                    player.Lemons += 30;
                    player.Money -= 2.16;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyLemons(player);
                }

            }
            else if (response == "75")
            {
                
                if (player.money > 4.19)
                {
                    player.Lemons += 75;
                    player.Money -= 4.19;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyLemons(player);
                }


            }
            else if (response == "return")
            {
                StartShopping(player);

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Answer is invalid, read prompt and answer accordingly. Hit enter when ready");
                Console.ReadLine();
                BuyLemons(player);
            }


        }





    }
}
