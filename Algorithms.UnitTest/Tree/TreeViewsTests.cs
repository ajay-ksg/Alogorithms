using Algorithms.Tree;
using FluentAssertions;

namespace Algorithms.UnitTest.Tree;

public class TreeViewsTests
{
    [Theory]
    [MemberData(nameof(LeftViewTestData))]
    public void LeftView_GivenBinaryTree_ShouldReturnLeftViewOfTree(DataStructure.Tree inputTree, List<int> expectedLeftView)
    {
        var treeView = new TreeViews();
        var actualLeftView = treeView.LeftView(inputTree);
        actualLeftView.Should().BeEquivalentTo(expectedLeftView);
    }

    private static List<object[]> LeftViewTestData()
    {
        return new List<object[]>()
        {
            new object[] { new DataStructure.Tree(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }),
                new List<int>() { 1, 2, 4, 8 } },
            new object[] { new DataStructure.Tree(new List<int>() { 1, 2, 3, DataStructure.Tree.InvalidValue, 5, 6, 7, 
                    DataStructure.Tree.InvalidValue,DataStructure.Tree.InvalidValue,10,11,12,13 }),
                new List<int>() { 1, 2, 5, 10 } }
        };
    }

  
}