using DataStructure.Tree.ArrayRepresentation;
using Xunit.Sdk;

namespace DataStructure.UnitTests.Tree.ArrayRepresentation;

public class BinaryTreeTests
{
    [Fact]
    public void ValueAt_ShouldReturnInvalidValue_WhenCalledOnEmptyTree()
    {
        var tree = new BinaryTree(new List<int?>());
        var value = tree.ValueAt(0);
        Assert.Equal(BinaryTree.InvalidValue, value);
    }
    
    [Fact]
    public void ValueAt_ShouldReturnInvalidValue_WhenCalledWithNegativeIndex()
    {
        var tree = new BinaryTree(new List<int?>(){1,2,3,4});
        var value = tree.ValueAt(-1);
        Assert.Equal(BinaryTree.InvalidValue, value);
    }
    
    [Fact]
    public void ValueAt_ShouldReturnInvalidValue_WhenValueAtCalledWithIndexGreaterThanSize()
    {
        var tree = new BinaryTree(new List<int?>(){1,2,3,4});
        var value = tree.ValueAt(4);
        Assert.Equal(BinaryTree.InvalidValue, value);
    }
    
    [Fact]
    public void ValueAt_ShouldReturnElementAtGivenIndex_WhenCalledWithValidIndex()
    {
        var tree = new BinaryTree(new List<int?>(){1,2,3,4});
        var value = tree.ValueAt(2);
        Assert.Equal(3, value);
    }
    
    [Fact]
    public void Size_ShouldReturnZero_WhenCalledOnEmptyTree()
    {
        var tree = new BinaryTree(new List<int?>());
        var size = tree.Size();
        Assert.Equal(0, size);
    }
    
    [Fact]
    public void Size_ShouldReturnSizeOfTree_WhenCalledOnNonEmptyTree()
    {
        var tree = new BinaryTree(new List<int?>(){1,2,3,4});
        var size = tree.Size();
        Assert.Equal(4, size);
    }
    
    [Theory]
    [MemberData(nameof(LeftChildOfTestData))]
    public void LeftChildOf_ShouldReturnExpectedValue_WhenCalledOnBinaryTree(
        string scenario,
        List<int?> elements,
        int index,
        int? expectedValue)
    {
        var tree = new BinaryTree(elements);
        var leftChild = tree.LeftChildOf(index);
        Assert.Equal(expectedValue, leftChild);
    }
    
    [Theory]
    [MemberData(nameof(RightChildOfTestData))]
    public void RightChildOf_ShouldReturnExpectedValue_WhenCalledBinaryTree(
        string scenario,
        List<int?> elements,
        int index,
        int? expectedValue)
    {
        var tree = new BinaryTree(elements);
        var rightChild = tree.RightChildOf(index);
        Assert.Equal(expectedValue, rightChild);
    }
    
    [Fact]
    public void Insert_ShouldInsertElementInTheTree_WhenCalledOnBinaryTree()
    {
        var tree = new BinaryTree(new List<int?>(){1,2,3,4});
        tree.Insert(5);
        Assert.Equal(5, tree.Size());
    }
    
    [Fact]
    public void Insert_ShouldInsertElementAtGivenIndex_WhenCalledOnBinaryTree()
    {
        var tree = new BinaryTree(new List<int?>(){1,2,3,4});
        tree.Insert(5, 2);
        Assert.Equal(5, tree.Size());
        Assert.Equal(5, tree.ValueAt(2));
    }
    
    public static TheoryData<string, List<int?>, int, int?> LeftChildOfTestData =>
        new()
        {
            { 
                "LeftChildOf_ShouldReturnInvalidValue_WhenCalledOnEmptyTree",
                new List<int?>(),
                0,
                BinaryTree.InvalidValue
            },
            { 
                "LeftChildOf_ShouldReturnInvalidValue_WhenCalledWithNegativeIndex",
                new List<int?>(){1,2,3,4},
                -1,
                BinaryTree.InvalidValue
            },
            { 
                "LeftChildOf_ShouldReturnInvalidValue_WhenLeftChildOfCalledWithIndexGreaterThanSize",
                new List<int?>(){1,2,3},
                4,
                BinaryTree.InvalidValue
            },
            { 
                "LeftChildOf_ShouldReturnLeftChildOfGivenIndex_WhenCalledWithValidIndex",
                new List<int?>(){1,2,3,4},
                1,
                4
            },
           
        };

    public static TheoryData<string, List<int?>, int, int?> RightChildOfTestData =>
        new()
        {
            { 
                "RightChildOf_ShouldReturnInvalidValue_WhenCalledOnEmptyTree",
                new List<int?>(),
                0,
                BinaryTree.InvalidValue
            },
            { 
                "RightChildOf_ShouldReturnInvalidValue_WhenCalledWithNegativeIndex",
                new List<int?>(){1,2,3,4},
                -1,
                BinaryTree.InvalidValue
            },
            { 
                "RightChildOf_ShouldReturnInvalidValue_WhenCalledWithIndexGreaterThanSize",
                new List<int?>(){1,2,3},
                4,
                BinaryTree.InvalidValue
            },
            { 
                "RightChildOf_ShouldReturnLeftChildOfGivenIndex_WhenCalledWithValidIndex",
                new List<int?>(){1,2,3,4},
                0,
                3
            },
        };

}