using System.CodeDom;
using System.Collections.Generic;

namespace FibonacciCalculators
{
    public class RecursiveCalculator
    {
        readonly List<uint> _fibonacciSequence = new List<uint>();

        public string ComputeSequence(uint a, uint b, uint counter, uint number)
        {
            _fibonacciSequence.Add(a);
            if (counter < number)
            {
                ComputeSequence(b, a + b, counter + 1, number);
            }

            return string.Join(" ", _fibonacciSequence.ToArray());
        } 
    }
}
