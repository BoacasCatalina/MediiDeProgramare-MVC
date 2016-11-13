using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    class Apple:Fruit
    {
        string color;

        public override int GetCalories()
        {

            return 2;
        }
        public Apple()
        {
            Console.WriteLine("Apple class has been created");
        }
    }
}
