using Algorithms.Recursion;
using Xunit.Abstractions;

namespace Algorithms.UnitTest.Recursion;

public class RecursionApplicationTests
{
    private RecursionApplications _recursion;
    private readonly ITestOutputHelper _testOutputHelper;

    public RecursionApplicationTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _recursion = new RecursionApplications();
    }

    [Theory]
    [MemberData(nameof(FibonacciTestInputs))]
    public void ShouldReturnNthFibonacciNumber(string testCase, int n, int expected)
    {
        _testOutputHelper.WriteLine($"Input for {testCase} is : "+ n);
        var actual = _recursion.GetNthFibonacciNumber(n);
        Assert.Equal(expected,actual);

    }

    private static IEnumerable<object[]> FibonacciTestInputs()
    {
        return new List<object[]>
        {
            new object[] { "InputSet 1", 2, 1 },
            new object[] { "InputSet 2", 0, 0 },
            new object[] { "InputSet 3", 5, 5 },
            new object[] { "InputSet 4", 4, 3 },
            new object[] { "InputSet 5", 10, 55 },
        };
    }
}