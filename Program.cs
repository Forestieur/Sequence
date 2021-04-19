using Sequencee.VIew;
using Sequencee.BL;

namespace Sequencee
{
    class Program
    {
        static void Main()
        {
            ISequence sequence = new Sequence(0_999_999_999);
            ConsoleOutput output = new(sequence);
            output.ShowNumbers();                  
        }
    }
}