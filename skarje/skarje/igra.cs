using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skarje
{
    public static class HelperClass
    {
        static Random rand = new Random();

        public static int GetState()
        {
            int r = rand.Next(0, 3);
            return r;
        }
    }
}
