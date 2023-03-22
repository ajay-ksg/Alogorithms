namespace Algorithms.Searching;

#region Important Points On BinarySearch
/*
 1. While thinking about BinarySearch , always think in way `which part of input can be rejected`
   
 
*/
#endregion
public class BinarySearch
{
    public int Search(List<int> input, int searchEle,int start = 0,int end = -1)
    {
        var index = -1;
        var low = 0;
        var high = input.Count() - 1;
        if (start != 0)
            low = start;
        if (end != -1)
            high = end;
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
                high = mid-1;
                continue;
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

    public int SearchLastOccurrence(List<int> input, int searchEle)
    {
        var index = -1;
        var low = 0;
        var high = input.Count() - 1;
        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            if (input[mid] == searchEle )
            {
                if (mid == input.Count()-1 || input[mid + 1] > searchEle)
                {
                    index = mid;
                    break;
                }
                low = mid+1;
                continue;
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