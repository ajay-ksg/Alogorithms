namespace DataStructure.UnitTests;

public class HeapTests
{
    [Fact]
    public void ShouldIncreaseElementsCountWhenAddCalledToHeap()
    {
        var myHeap = new Heap();
        var elementsBeforeAdd = myHeap.Count();
        myHeap.Add(1);
        var elementsAfterAdd = myHeap.Count();
        
        Assert.Equal(elementsBeforeAdd+1,elementsAfterAdd);

    }
    
    [Fact]
    public void ShouldReturnMinElementWhenTopCalledOnHeap()
    {
        var myHeap = new Heap();
        myHeap.Add(2);
        myHeap.Add(1);
        myHeap.Add(-1);
        myHeap.Add(-1);
        myHeap.Add(5);
        myHeap.Add(-7);
        myHeap.Add(-8);
        myHeap.Add(10);
        
        var minElement = myHeap.Top();
        Assert.Equal(minElement, -8);

    }
    
    [Fact]
    public void ShouldRemoveAndReturnRemovedElementWhenDeleteCalledOnHeap()
    {
        var myHeap = new Heap();
        myHeap.Add(2);
        myHeap.Add(1);
        myHeap.Add(-1);
        myHeap.Add(-1);
        myHeap.Add(5);
        myHeap.Add(-7);
        myHeap.Add(-8);
        myHeap.Add(10);
        var deletedEle = myHeap.Delete();
        
        var minElement = myHeap.Top();
        Assert.Equal(minElement, -7);
        Assert.Equal(deletedEle, -8);

    }
}