using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    public class Fruit
    {
        int calories;

        public virtual int GetCalories()
        {

            return 1;
        }

        public Fruit()
        {
            Console.WriteLine("Fruit class has been created");
        }
    }
}
