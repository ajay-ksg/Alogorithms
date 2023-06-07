using Algorithms.Recursion;

namespace Algorithms.UnitTest.Recursion;

public class BacktrackingTests
{
    /*
     * https://www.geeksforgeeks.org/rat-in-a-maze/ 
     */
    private readonly Backtracking _backtracking = new Backtracking();
    public void FindPathFromSourceToDest()
    {
        List<List<int>> maze = getInputMaze();
        bool expectedAnswer = true;
        //source {0,0}
        //Destination {N-1,M-1}
        var result = Backtracking.DoesPathExistFromSourceToDest(maze);
        Assert.Equal(expectedAnswer,result);
    }

    private List<List<int>> getInputMaze()
    {
        return new List<List<int>>()
        {
            new List<int>(){ 1,1,1,0,1,1,1 },
            new List<int>(){ 1,0,1,0,1,0,1 },
            new List<int>(){ 1,0,1,1,0,1,1 },
            new List<int>(){ 1,1,0,1,0,1,0 },
            new List<int>(){ 0,1,0,1,1,1,1 },
            new List<int>(){ 1,1,1,0,1,1,1 },
        };
    }
}