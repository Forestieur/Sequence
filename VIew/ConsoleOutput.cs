using Sequencee.BL;

namespace Sequencee.VIew
{
    class ConsoleOutput
    {
        private readonly Sequence _sequence;

        public  ConsoleOutput(double number)
        {
            _sequence = new Sequence(number);
        }

        public void ShowNumbers()
        {           
            double maxNumber = _sequence.CountNumbers();
            View.DisplayNumbers(maxNumber);

        }
    }
}
