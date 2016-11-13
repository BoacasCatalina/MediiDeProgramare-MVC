using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Car
    {
        string name;
        public string carStart()
        {
            name = "something";
            Console.WriteLine("This car is Audi" + name);
            return name;
        }
    }
}
