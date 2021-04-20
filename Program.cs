using Sequencee.VIew;
using Sequencee.BL;

namespace Sequencee
{
    class Program
    {
        //7.Программа выводит ряд натуральных чисел через запятую, квадрат которых меньше заданного n. Программа запускается через вызов главного класса с параметрами.
        static void Main()
        {
            ISequence sequence = new Sequence(0_999);
            ConsoleOutput output = new(sequence);
            output.ShowNumbers();          
        }
    }
}
