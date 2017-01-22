using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    struct EngineStruct { };
    class Program
    {
        static void Main(string[] args)
        {
            // AbstractCar aCar = new AbstractCar(); Nu se poate instantia
            Mercedes mercedes = new Mercedes();
            EngineStruct engine = new EngineStruct();
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();
            Console.WriteLine("This is my first application");
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);
            Console.ReadKey();
        }
    }
}
