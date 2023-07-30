using System.Diagnostics;

namespace Algorithms.Sorting;

public class InsertionSort : ISort
{
    private Stopwatch timer = new Stopwatch();
    public List<int> Sort(List<int> input)
    {
        timer.Start();
        for (var i = 1; i < input.Count; i++)
        {
            PutEleAtRightPlace(input, i);
        }
        timer.Stop();
        Console.WriteLine("Insertion Sort Time in ms :: "+ timer.ElapsedMilliseconds);
        return input;
    }

    private void PutEleAtRightPlace(List<int> input, int index)
    {
        int i = 0;
        for (; i < index; i++)
        {
            if (input[index] < input[i]){ break;}

        }

        if (i < index)
        {
            var prevEle = input[i];
            input[i] = input[index];
            i++;
            while (i < index)
            {
                var curr = input[i];
                input[i] = prevEle;
                prevEle = curr;
                i++;
            }

            input[index] = prevEle;
        }
    }
}