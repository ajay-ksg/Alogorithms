namespace Algorithms.Searching;

public class BinarySearch
{
    public int Search(List<int> input, int searchEle)
    {
        var index = -1;
        var low = 0;
        var high = input.Count() - 1;
        while (low < high)
        {
            var mid = low + (high - low) / 2;
            if (input[mid] == searchEle)
            {
                index = mid;
                break;
            }

            if (searchEle < input[mid])
                high = mid - 1;
            else
            {
                low = mid + 1;
            }
        }
        return index;
    }

    public int SearchFirstOccurrence(List<int> input, int searchEle)
    {
        var index = -1;
        var low = 0;
        var high = input.Count() - 1;
        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            if (input[mid] == searchEle )
            {
                if (mid == 0 || input[mid - 1] < searchEle)
                {
                    index = mid;
                    break;
                }
                else
                {
                    high = mid-1;
                    continue;
                }
            }

            if (searchEle < input[mid])
                high = mid - 1;
            else
            {
                low = mid + 1;
            }
        }
        return index;
        
    }
}