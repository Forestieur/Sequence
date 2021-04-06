using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencee.BL
{
    class ConsoleOutput
    {
        private Sequence _sequence;
        private View _view;

        public  ConsoleOutput(double number)
        {
            _sequence = new Sequence(number);
        }

        public void StartBoard()
        {           
            _view = new View();
            double maxNumber = _sequence.CountNumbers();
            _view.DisplayNumbers(maxNumber);

        }
    }
}
