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
            mercedes.StartEngine();
            mercedes.ShowRemainingNoOfKM(100, 50);
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();
            Console.WriteLine("This is my first application");
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);
            Console.WriteLine(mercedes.StartEngine(1000));
            Console.WriteLine("The consumption is " + mercedes.CalculateConsumption(12, 25, 35));
            Console.ReadKey();
            
        }
    }
}
