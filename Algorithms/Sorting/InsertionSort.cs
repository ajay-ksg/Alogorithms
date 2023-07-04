namespace Algorithms.Sorting;

public class InsertionSort : ISort
{
    public List<int> Sort(List<int> input)
    {
        for (var i = 1; i < input.Count; i++)
        {
            PutEleAtRightPlace(input, i);
        }

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