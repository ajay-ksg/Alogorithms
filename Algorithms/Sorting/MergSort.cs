using System.Data;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Xml.Xsl;

namespace Algorithms.Sorting;

public class MergSort : ISort
{
    private Stopwatch timer = new Stopwatch();
    public List<int> Sort(List<int> input)
    {
        timer.Start();
        if (input.Count <= 1) return input;
        MSort(input,0,input.Count-1);
        timer.Stop();
        Console.WriteLine("Merge Time in ms :: "+ timer.ElapsedMilliseconds);
        return input;

    }

    private void MSort(List<int> input,int left, int right)
    {
        if(left >= right) return ;
        int mid = left + (right - left) / 2;
        
        //Console.Write($"Left: {{{left}, {mid} }}");
        MSort(input,left,mid);
        
        //Console.WriteLine($"Right: {{{mid+1}, {right} }}");
        MSort(input,mid+1,right);
        Merge(input, left, mid, right);
    }

    private void Merge(List<int> input,int leftIndex, int midIndex,int rightIndex )
    {
        var left = new List<int>();
        var right = new List<int>();
        for(int k = leftIndex; k <= midIndex; k++ )
            left.Add(input[k]);
        
        for (int k = midIndex+1; k <= rightIndex; k++)
        {
            right.Add(input[k]);
        }
        
        int i = 0, j = 0, l = leftIndex;

        
        while (i < left.Count && j < right.Count)
        {
            input[l++] = (left[i] <= right[j] ? left[i++] : right[j++]);
        }
        while(i < left.Count)
            input[l++] = (left[i++]);
        while (j < right.Count)
            input[l++] = (right[j++]);
        
    }
}