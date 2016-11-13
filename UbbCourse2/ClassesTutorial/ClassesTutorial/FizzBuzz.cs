using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class FizzBuzz
    {
        public static string ShowFizzBuzz(int ReceivedNumber)
        {
           if(ReceivedNumber % 15 ==0)
            {
                return "Fizz Buzz";
            }
           if(ReceivedNumber % 3 == 0)
            {
                return "Fiz";
            }
           if(ReceivedNumber % 5 == 0)
            {
                return "Buz";
            }
           else
            {
                return "" + ReceivedNumber;
            }
        }
    }
}
