using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencee.BL 
{
    class View
    {
        public void DisplayNumbers(double maxNumber)
        {
            for(double i=1; i<maxNumber;i++)
            {               
                if (i == (int)maxNumber )
                {
                    Console.Write($"{i}");
                    break;
                }
                Console.Write($"{i}, ");
            }
        }
    }
}
