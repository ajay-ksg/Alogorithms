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
        var lastOccurrence = _binarySearch.SearchLastOccurrence(input,number);
        return (lastOccurrence - firstOccurrence) + 1;
    }
}