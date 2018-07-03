using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class RNG
    {
        Random r = new Random();
        public RNG()
        { }             
        public int GenerateRandomNumber(int min, int max)
        {
            int output = r.Next(min, max);
            return output;
        }

    }
}
