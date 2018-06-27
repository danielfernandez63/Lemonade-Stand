using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        Weather weather;
        // list of customers


        public void GetDailyForecast()
        {
            weather = new Weather();
            weather.GetForecast();

        }
        
       

        //run weather 

        

    }
}
