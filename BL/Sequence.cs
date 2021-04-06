using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Sequence.BL
{
    

    class Sequence : ICount
    {
        private double _number;
        private long max_number;

        public Sequence(double number)
        {
            _number = number;
        }

        public void CountArr(out long[] numbers)
        {
            numbers = new long[(long)_number];

            for (double i = 0; i * i < _number; i++)
            {
                 numbers[(int)i] = (int)i;

            }           
        }

        public void CountList(out List<double> Numbers)
        { 
            Numbers = new List<double>();
            for (int i = 0; i * i < _number; i++)
            {
                Numbers.Add(i);
            }
        }

        public void CountNumbers()
        {
           

            

          
      



        }
    }
}
