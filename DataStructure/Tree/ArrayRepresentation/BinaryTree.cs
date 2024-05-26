namespace DataStructure.Tree.ArrayRepresentation;

public class BinaryTree
{
    private readonly List<int?> _elements;
    public static readonly int? InvalidValue = null;

    public BinaryTree(List<int?> elements)
    {
        _elements = elements;
    }

    public int? ValueAt(int index)
    {
        if (_elements.Count <= index || index < 0) return InvalidValue;
        return _elements[index];
    }

    public int Size() => _elements.Count;

    public int? LeftChildOf(int index)
    {
        if (index < 0)
            return InvalidValue;
        var leftIndex = 2 * index + 1;
        return leftIndex < Size() ? ValueAt(leftIndex) : InvalidValue;
    }
    
    public int? RightChildOf(int index)
    {
        if (index < 0)
            return InvalidValue;
        var rightIndex = 2 * index + 2;
        return rightIndex < Size() ? ValueAt(rightIndex) : InvalidValue;
    }
    
    public int LeftChildIndexOf(int index)
    {
        return (2 * index + 1);
    }
    
    public int RightChildIndexOf(int index)
    {
        return  (2 * index + 2);
    }

    public void Insert(int value, int index = -1)
    {
        if(index < 0)
            _elements.Add(value);
        else
            _elements.Insert(index, value);
    }

    // will be used for BST
    private int FindInsertionIndex(int value)
    {
        var index = 0;
        if(Size() == 0) return index;
        
        while (index < _elements.Count)
        {
            index = _elements[index] <= value ? LeftChildIndexOf(index) : RightChildIndexOf(index);
        }

        return index == Size() ? -1 : index;
    }
    public bool Delete(int value)
    {
        return false;
    }
    
}