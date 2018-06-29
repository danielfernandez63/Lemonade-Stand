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

        }
        
        public void StartShopping(Player player)
        {
            string response;
            Console.Clear();
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            Console.WriteLine("Welcome to Dan's Mega Store Emporium. What would you like to buy? Options are 'lemons', 'ice', 'cups', sugar' or 'done'.");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "lemons")
            {
                BuyLemons(player);

            }

            else if (response == "ice")
            {
                BuyIce(player);

            }

            else if (response == "cups")
            {
                BuyCups(player);

            }

            else if (response == "sugar")
            {
                BuySugar(player);

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
            Console.Clear();
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            Console.WriteLine("Lemons are currently on sale! Check out these crazy TART looking deals!");   
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
                    Console.ReadLine();
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
                    Console.ReadLine();
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
                    Console.ReadLine();
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

        public void BuyIce(Player player)
        {
            string response;
            Console.Clear();
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            Console.WriteLine("Ice is currently on sale! Check out these wacky shockingly HOT deals!");
            Console.WriteLine("100 ice cubes for 0.88$.");
            Console.WriteLine("250 ice cubes for 2.00$.");
            Console.WriteLine("500 cubes for 3.66$.");
            Console.WriteLine("");
            Console.WriteLine(" Enter the number you would like to purchase, '100','250','500', or 'return'.");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "100")
            {
                if (player.money > 0.88)
                {
                    player.Ice += 100;
                    player.Money -= 0.88;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyIce(player);
                }

            }
            else if (response == "250")
            {
                if (player.money > 2.00)
                {
                    player.Ice += 250;
                    player.Money -= 2.00;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyIce(player);
                }

            }
            else if (response == "500")
            {

                if (player.money > 3.66)
                {
                    player.Ice += 500;
                    player.Money -= 3.66;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyIce(player);
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
                BuyIce(player);
            }

        }

        public void BuyCups(Player player)
        {
            string response;
            Console.Clear();
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            Console.WriteLine("Cups are currently on sale! Check out these super awesome DRINKABLE deals!");
            Console.WriteLine("25 cups for 0.86$.");
            Console.WriteLine("50 cups for 1.63$.");
            Console.WriteLine("100 cups for 2.75$.");
            Console.WriteLine("");
            Console.WriteLine(" Enter the number you would like to purchase, '25','50','100', or 'return'.");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "25")
            {
                if (player.money > 0.86)
                {
                    player.Cups += 25;
                    player.Money -= 0.86;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyCups(player);
                }

            }
            else if (response == "50")
            {
                if (player.money > 1.63)
                {
                    player.Cups += 50;
                    player.Money -= 1.63;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyCups(player);
                }

            }
            else if (response == "100")
            {

                if (player.money > 2.75)
                {
                    player.Cups += 100;
                    player.Money -= 2.75;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuyCups(player);
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
                BuyCups(player);
            }

        }

        public void BuySugar(Player player)
        {
            string response;
            Console.Clear();
            Console.WriteLine("");
            player.GetInventory();
            Console.WriteLine("");
            Console.WriteLine("Sugar is currently on sale! Check out these SWEET and yummy deals!");
            Console.WriteLine("8 cups of sugar for 0.51.");
            Console.WriteLine("20 cups of sugar  for 1.64$.");
            Console.WriteLine("48 cups of sugar for 3.28$.");
            Console.WriteLine("");
            Console.WriteLine(" Enter the number you would like to purchase, '8','20','48', or 'return'.");
            response = Console.ReadLine().ToLower().Trim();

            if (response == "8")
            {
                if (player.money > 0.51)
                {
                    player.Sugar += 8;
                    player.Money -= 0.51;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuySugar(player);
                }

            }
            else if (response == "20")
            {
                if (player.money > 1.64)
                {
                    player.Sugar += 20;
                    player.Money -= 1.64;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuySugar(player);
                }

            }
            else if (response == "48")
            {

                if (player.money > 3.28)
                {
                    player.Sugar += 48;
                    player.Money -= 3.28;
                    Console.WriteLine("Purchase was succesful! You will now return to the store menu. ");
                    Console.ReadLine();
                    StartShopping(player);
                }
                else
                {
                    Console.WriteLine("You do not have the sufficient funds, alter amount or return.");
                    BuySugar(player);
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
                BuySugar(player);
            }

        }













    }
}
