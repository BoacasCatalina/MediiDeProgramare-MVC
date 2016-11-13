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
            Mercedes m1 = new Mercedes();
            double numberOfKMLeft;
            numberOfKMLeft = mercedes.ShowRemainingNoOfKM(1000, 5);
            Console.WriteLine("Remaining km" + numberOfKMLeft);
            
            Console.WriteLine(FizzBuzz.ShowFizzBuzz(9));
           // m1.PrintNewMercedes(Mercedes.counter);
            Mercedes m2 = new Mercedes();
            Mercedes.StartEngine();
            //m2.PrintNewMercedes(Mercedes.counter++)
            //mercedes.MercedesLogo();
            //AbstractCar aCar = new AbstractCar(); nu se poate instantia
            ICar car = new Mercedes();
            //AbstractCar car2 = new AbstractCar(); nu se poate instantia
            EngineStruct engineStruct = new EngineStruct();
            //Console.WriteLine("This is my first C# application");
            // Console.ReadKey();
           // Mercedes.ShowRemainingNoOfKM(1000, 4);
            PrintLogo();
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);
            Console.ReadKey();
            
            
        }

        static void PrintLogo()
        {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C# is great!");
            PrintLogo2();
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

    }

    public class Mercedes:AbstractCar
    {
        //protected int year;
        //protected string customer;
       static int counter2;
        internal int year;
        internal string colour;
        private string _description;
        private int _price;
        private int counter;

        
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "This is a car";
            }
        }

        public double ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        { 
            double result = 0;
            result = noOfFuelLiters / Consumption * 100;
            return result;
        }
        public void MercedesLogo()
        {
            Console.WriteLine("This is from Mercedes");
           
            if(counter == 3)
            {
                counter++;
                MercedesLogo();
                return;
            }
        }

        public static void StartEngine()
        {

        }

        public void PrintNewMercedes(int c)
        {
            if (c == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("Mercedes No." + c);
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = 67000;
            }
        }
        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }
    }

    interface ICar
    {

    }
    public abstract class AbstractCar:ICar
    {

    }

    public struct EngineStruct
    {

    }

    

}
