using System;

namespace Sequencee.BL
{
    class Sequence : ISequence
    {
        private readonly double _number;
        private double _maxNumber;

        public Sequence(double number)
        {
            _number = number;
        }

        public double CountNumbers()
        {
            _maxNumber = _number / 2;
            double eps = 0.001;
            while (_maxNumber - _number / _maxNumber > eps)
            {
                _maxNumber = 0.5 * (_maxNumber + _number / _maxNumber);
            }
            return _maxNumber;
        }
    }
}
