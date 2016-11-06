using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Audi : Car
    {
        public int vitezometru(int acceleratie)
        {
            if (acceleratie == 1)
            {
                return 50;
            }
            else if (acceleratie == 3)
            {
                return 100;
            }
            else if (acceleratie == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}
