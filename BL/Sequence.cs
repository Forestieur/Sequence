using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Sequencee.BL
{
    

    class Sequence 
    {
        private double _number;
        private double _maxNumber;
        public Sequence(double number)
        {
            _number = number;
            CountNumbers();
        }

        public double CountNumbers()
        {
             _maxNumber = _number / 2;
            double eps = 0.1;
            while (_maxNumber - _number / _maxNumber > eps)
            {
                _maxNumber = 0.5 * (_maxNumber + _number / _maxNumber);
            }
            return _maxNumber;
        }
    }
}
