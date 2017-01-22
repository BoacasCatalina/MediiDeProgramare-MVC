using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    internal class Mercedes:AbstractCar
    {
        public string Description;
        public int Price;
        private string _description;
        private int _price;
        protected string colour;
        protected int year;
        internal string mark;
        internal int age;
        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }

        public string _Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "My first car";
            }
        }

        public int _Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = 50;
            }
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine started");
            //return "Engine started";
        }

        public void ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        {
            Console.WriteLine("Remaining km: " + noOfFuelLiters / Consumption * 100);
            //return noOfFuelLiters / Consumption * 100;
        }

        public string StartEngine(int noOfMiliseconds)
        {
                return "The car is starting in {" + noOfMiliseconds + "}";
            
        }

        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }
    }
}
