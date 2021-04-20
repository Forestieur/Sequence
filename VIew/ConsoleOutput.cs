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
            if(Math.Floor(maxNumber) == 1)
            {
                Console.Write($"{maxNumber} ");
            }

            if(maxNumber - Math.Floor(maxNumber) < 0.01)
            {
                for (double i = 1; i < Math.Floor(maxNumber); i++)
                {
                    Console.Write($"{i}, ");
                }
            }
            else
            {
                for (double i = 1; i <= maxNumber; i++)
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
