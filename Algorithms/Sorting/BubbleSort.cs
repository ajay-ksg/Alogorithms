using System.Runtime.InteropServices;

namespace Algorithms.Sorting;

public class BubbleSort : ISort
{
    public List<int> Sort(List<int> input)
    {
        // if i > i+1 swap else move to next ele, repeat n times
        for (var j = 0; j < input.Count; j++)
        {
            for (var i = 0; i < input.Count - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    input[i] *= input[i + 1];
                    input[i + 1] = input[i] / input[i + 1];
                    input[i] /= input[i + 1];
                }
            }
        }

        return input;
    }

    private void Swap(ref int a, ref int  b)
    {
        a = a * b;
        b = a / b;
        a = a / b;
    }
}