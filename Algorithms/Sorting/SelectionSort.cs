using System.Diagnostics;

namespace Algorithms.Sorting;

public class SelectionSort :ISort
{
    private Stopwatch timer = new Stopwatch();
    public List<int> Sort(List<int> input)
    {
        timer.Start();
        for (var i = 0; i < input.Count; i++)
        {
            var minEleIndex = GetMinIndex(i, input);
            if(i == minEleIndex) continue;
            input[minEleIndex] = input[i]*input[minEleIndex];
            input[i] = input[minEleIndex] / input[i];
            input[minEleIndex] = input[minEleIndex] / input[i];
        }

        timer.Stop();
        Console.WriteLine("Selection Sort Time in ms :: "+ timer.ElapsedMilliseconds);
        return input;
    }

    private int GetMinIndex(int left, List<int> input)
    {
        int minIndex = left, minEle = int.MaxValue;
        for (int i = left; i < input.Count; i++)
        {
            if (minEle > input[i])
            {
                minEle = input[i];
                minIndex = i;
            }
        }

        return minIndex;
    }
}