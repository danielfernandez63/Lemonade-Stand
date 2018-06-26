using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        Weather weather = new Weather();


        public void RunGame()
        {
            GameDirections();
            StartGamePrompt();
            
        }

        public void GameDirections()
        {
          Console.WriteLine("Welcome to the lemonade stand game. The object here is to make the maximum amount of money possible in the game... etc");
          Console.ReadLine();

        }

        public void StartGamePrompt()
        {
            Console.WriteLine(" Here are some starting details for the day. ");
            weather.GetForecast();
            Console.ReadLine();
            Console.WriteLine("Current inventory is" );
            Console.WriteLine("");



        }





    }
}
