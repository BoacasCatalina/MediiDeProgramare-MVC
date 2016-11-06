using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static int counter;
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            Audi audi = new Audi();
            Console.WriteLine("Viteza e: "+ audi.vitezometru(1));
            audi.carStart();
            ShowRemainingNoOfKM(1000, 5);
            StartEngine();
            EngineStruct engineStruct = new EngineStruct();
            ICar car = new Mercedes();
            Console.WriteLine("This is my first C# project");
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);
            PrintLogo();
            PrintMax(2, 3);
            Console.ReadKey();
        }
        public struct EngineStruct
        {
        }
        public static void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }
        static void PrintLogo()
        {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C# is great!");
        }
        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            if (number2 > number1)
                max = number2;
            Console.WriteLine("Maximal number: {0}", max);
        }
        static void PrintLogo(int i)
        {
            Console.WriteLine("I am another PrintLogo");
        }

        static void PrintLogo2()
        {
            Console.WriteLine("This is from Logo2");

            if (counter == 3)
            {
                counter++;
                PrintLogo2();
                return;
            }
        }
        public static double ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        {
            double result = 0;
            result = noOfFuelLiters / Consumption * 100;
            Console.WriteLine("Remaining km: " + noOfFuelLiters / Consumption * 100);
            return result;
        }



    }


}
