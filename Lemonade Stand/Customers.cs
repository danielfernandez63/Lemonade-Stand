using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customers
    {
        public int percentChanceToBuy;


        public Customers(RNG Rnd)
        {
            percentChanceToBuy = Rnd.GenerateRandomNumber(30, 61);

        }

        public void ChanceBasedOnTemperature()
        {
            

//weather  chacne for price   


        }












    }
}
