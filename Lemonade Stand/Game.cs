using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        public void RunGame()
        {
            GameDirections();
            GetWeather();
        }

        public void GameDirections()
        {
          Console.WriteLine("Welcome to the lemonade stand game. The object here is to make the maximum amount of money possible in the game... etc");
          Console.ReadLine();

        }

        public void GetWeather()
        {
            //this is to get the weather forecast for the day

            Weather weather = new Weather();
            weather.GetForecast();



        }



    }
}
