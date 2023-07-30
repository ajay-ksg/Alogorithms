using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Algorithms.Sorting;

public class BubbleSort : ISort
{
    private Stopwatch timer = new Stopwatch();
    public List<int> Sort(List<int> input)
    {
        timer.Start();
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
        timer.Stop();
        Console.WriteLine("BubbleSort Time in ms :: "+ timer.ElapsedMilliseconds);
        return input;
    }

    private void Swap(ref int a, ref int  b)
    {
        a = a * b;
        b = a / b;
        a = a / b;
    }
}