using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Algorithms.Searching;

namespace Algorithms.AlgoApplications;

public class BinarySearchApplications
{
    private readonly BinarySearch _binarySearch;

    public BinarySearchApplications()
    {
        _binarySearch = new BinarySearch();
    }

    public int GetOccurrenceOfNumber(List<int> input, int number)
    {
        var firstOccurrence = _binarySearch.SearchFirstOccurrence(input, number);
        var lastOccurrence = _binarySearch.SearchLastOccurrence(input, number);
        return (lastOccurrence - firstOccurrence) + 1;
    }

    public int SearchInRotatedSortedArray(List<int> input, int number)
    {
        if (input.Count() == 1)
            return input[0] == number ? 0 : -1;
        var pivot = 0;
        for (var i = 1; i < input.Count(); i++)
        {
            if (input[i - 1] <= input[i]) continue;
            pivot = i;
            break;
        }

        var index = _binarySearch.Search(input, number, 0, pivot - 1);
        return index == -1 ? _binarySearch.Search(input, number, pivot) : index;
    }

    public int SearchNumberWithSingleOccurrence(List<int> input)
    {
        var low = 0;
        var high = input.Count() - 1;
        if (high % 2 != 0)
            return -1;
        while (low <= high)
        {
            var mid = GetMid(low, high);
            if (mid == 0 && input[mid] != input[mid + 1])
                return mid;
            if (mid == input.Count() - 1 && input[mid] != input[mid - 1])
                return mid;
            if (input[mid] != input[mid - 1] && input[mid] != input[mid + 1])
                return mid;

            if (input[mid] != input[mid - 1])
            {
                if ((mid) % 2 == 0)
                    low = mid;
                else
                {
                    high = mid - 1;
                }
            }
            else
            {
                if ((mid) % 2 == 0)
                    high = mid;
                else
                {
                    low = mid + 1;
                }
            }
        }

        return -1;
    }

    private int GetMid(int low, int high)
    {
        return low + (high - low) / 2;
    }

    public int SearchDuplicatedNumberInSortedArrayHavingUniqueElementsFrom1ToNMinus1(List<int> input)
    {
        var low = 0;
        var high = input.Count() - 1;
        while (low < high)
        {
            var mid = GetMid(low, high);
            if (mid == 0 && input[mid + 1] == input[mid])
                return input[mid];
            if (mid == input.Count() - 1 && input[mid - 1] == input[mid])
                return input[mid];
            if (input[mid] == input[mid - 1] || input[mid] == input[mid + 1])
                return input[mid];


            if (mid == input[mid])
                high = mid;
            else
            {
                low = mid+1;
            }
        }

        return -1;
    }
}