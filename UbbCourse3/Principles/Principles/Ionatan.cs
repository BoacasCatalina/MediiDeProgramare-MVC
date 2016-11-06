using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    class Ionatan:Apple
    {
        public override int  GetCalories()
        {

            return 3;
        }
        public Ionatan()
        {
            Console.WriteLine("A new Ionatan has been created");
        }
    }
}
