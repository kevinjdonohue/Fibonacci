using System.Collections.Generic;

namespace FibonacciCalculators
{
    public class IterativeCalculator
    {
        public uint Compute(uint i)
        {
            if (i == 0 || i == 1)
            {
                return i;
            }

            uint minusOneResult = Compute(i - 1);
            uint minusTwoResult = Compute(i - 2);

            return minusOneResult + minusTwoResult;
        }

        public string ComputeSequence(uint numberOfResults)
        {
            List<uint> fibonacciSequence = new List<uint>();

            for (uint i = 0; i < numberOfResults; i++)
            {
                fibonacciSequence.Add(Compute(i));
            }

            return string.Join(" ", fibonacciSequence.ToArray());
        }
    }
}