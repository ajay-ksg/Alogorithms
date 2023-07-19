namespace Algorithms.AlgoApplications;

public class SortingApplication
{
    public List<int> GetMinUnSortedSubarray(List<int> input)
    {
        int i = 0,j = input.Count-1;
        while (i+1 < input.Count && input[i] < input[i+1])
        {
            i++;
        }
        while (j > 0 && input[j] > input[j-1])
        {
            j--;
        }

        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        for (int k = i; k <= j; k++)
        {
            if (min > input[k])
                min = input[k];
            if (max < input[k])
                max = input[k];
        }

        int leftIndex = -1, rightIndex = -1;
        for(int k = i; k >= 0; k--)
        {
            if (min > input[k])
            {
                leftIndex = k+1;
                break;
            }
            
        }
        
        for(int k = input.Count-1; k >= j; k--)
        {
            if (max > input[k])
            {
                rightIndex = k;
                break;
            }
            
        }

        return new List<int>() { leftIndex, rightIndex };
    }
}