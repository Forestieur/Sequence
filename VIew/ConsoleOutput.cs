using Sequencee.BL;
using System;

namespace Sequencee.VIew
{
    class ConsoleOutput
    {
         private double maxNumber;
        
        public  ConsoleOutput(ISequence sequence)
        {           
            maxNumber = sequence.CountNumbers();
        }

        public void ShowNumbers()
        {           
            for (double i = 1; i <= maxNumber; i++)
            {
                 Console.Write($"{i}, ");
            }
        }
    }
}
