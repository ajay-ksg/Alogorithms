using System.Runtime.InteropServices;

namespace DataStructure;

public class Heap
{
    private List<Int16> values;

    public Heap()
    {
        this.values = new List<Int16>();
    }

    public int Count()
    {
        return values.Count;
    }

    public void Add(Int16 value)
    {
        values.Add(value);
        Heapify();
    }

    private void Heapify()
    {
        if(values.Count < 2) return;
        for (int parent = values.Count / 2; parent >= 0; parent--)
        {
            var left = 2 * parent;
            var right = left + 1;
            var minChildIndex = 0;
            if (left < values.Count)
                minChildIndex = left;
            if(right < values.Count)
                minChildIndex = values[left] < values[right] ? left : right;
            if (values[parent] > values[minChildIndex])
                (values[parent], values[minChildIndex]) = (values[minChildIndex], values[parent]);
        }
    }

    public int Top()
    {
        return values.FirstOrDefault();
    }

    public int Delete()
    {
        var minElement = this.Top();
        if (values.Count == 0)
            throw new InvalidOperationException("No Elemt Exist in heap to delete");
        values.RemoveAt(0);
        Heapify();
        return minElement;
    }
}