namespace Sequencee
{
    class ConsoleOutput
    {
        private Sequence _sequence;
        private View _view;

        public  ConsoleOutput(double number)
        {
            _sequence = new Sequence(number);
        }

        public void ShowNumbers()
        {           
            _view = new View();
            double maxNumber = _sequence.CountNumbers();
            _view.DisplayNumbers(maxNumber);

        }
    }
}
