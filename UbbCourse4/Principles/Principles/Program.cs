using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Orange orange = new Principles.Orange();
            Ionatan ionatan = new Ionatan();
            Fruit fruit = new Ionatan();
            Console.WriteLine(fruit.GetCalories());
            Console.WriteLine(ionatan.GetCalories());
            Apple apple1 = new Ionatan();
            Apple mar = new Apple();
            FruitBasket frBascket = new FruitBasket();
            frBascket.addFruit(mar);
            frBascket.displayFruit();
            Console.WriteLine(apple1.GetCalories());
            Console.ReadKey();
        }
    }
}
