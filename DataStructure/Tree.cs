namespace DataStructure;

public class Tree
{
    private readonly List<int> _elements;
    public static readonly int InvalidValue = Int32.MaxValue;

    public Tree(List<int> elements)
    {
        _elements = elements;
    }

    public int ValueAt(int index)
    {
        if (_elements.Count <= index || index < 0) return InvalidValue;
        return _elements[index];
    }

    public int Size() => _elements.Count;

    public int LeftChildOf(int index)
    {
        var leftIndex = 2 * index + 1;
        return leftIndex < Size() ? ValueAt(leftIndex) : InvalidValue;
    }
    
    public int RightChildOf(int index)
    {
        var rightIndex = 2 * index + 2;
        return rightIndex < Size() ? ValueAt(rightIndex) : InvalidValue;
    }
}