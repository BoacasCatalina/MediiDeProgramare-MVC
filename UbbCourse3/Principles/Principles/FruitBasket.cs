using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    class FruitBasket
    {
        public List<Fruit> listaDeFructe;

       public FruitBasket()
        {
            listaDeFructe = new List<Fruit>();
        }

        public void addFruit(Fruit fruit)
        {
            listaDeFructe.Add(fruit);
        }
        public void displayFruit()
        {
            foreach( var i  in listaDeFructe)
            {
                Console.WriteLine(i.ToString());
            }
            
        }
    }
}
