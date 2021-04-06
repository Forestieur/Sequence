using System;

namespace Sequencee.VIew
{
    class View
    {
        public static void DisplayNumbers(double maxNumber)
        {
            for(double i = 1; i < maxNumber; i++)
            {               
                if (i == (int)maxNumber)
                {
                    Console.Write($"{i}");
                    break;
                }
                Console.Write($"{i}, ");
            }
        }
    }
}
