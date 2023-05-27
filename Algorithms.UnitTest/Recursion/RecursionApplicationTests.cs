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

    [Theory]
    [MemberData(nameof(PermutationWithUniqueCharInputs))]
    public void ShouldReturnAllPermutationOfStringGivenAllCharacterAreUnique(string testCase,string input,List<string> expected)
    {
        _testOutputHelper.WriteLine($"Executing Testcase: {testCase} ");
        var actual = new List<string>();
        _recursion.GetStringPermutationHavingUniqueChars("",input,permutations: actual);
        
        actual.ForEach(x => Assert.Contains(x,expected));
        Assert.Equal(expected.Count(),actual.Count());
    }
    
    [Theory]
    [MemberData(nameof(PermutationWithUniqueCharInputs))]
    public void ShouldReturnAllUniquePermutationOfStringGivenStringCanContainsDuplicateChars(string testCase,string input,List<string> expected)
    {
        _testOutputHelper.WriteLine($"Executing Testcase: {testCase} ");
        var actual = new List<string>();
        _recursion.GetUniquePermutationOfStrHavingRepeatedChars("",input,actual);
        
        actual.ForEach(x => Assert.Contains(x,expected));
        Assert.Equal(expected.Count(),actual.Count());
    }

    #region TestInputs
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

    private static IEnumerable<object[]> PermutationWithUniqueCharInputs()
    {
        return new List<object[]>
        {
            new object[]{"TestCase1","abc",new List<string>{"abc", "acb", "bac", "bca", "cab", "cba"}},
            new object[]{"TestCase2","ab",new List<string>{"ab", "ba"}},
            new object[]{"TestCase3","abcd",new List<string>
            {
                "abcd", "abdc", "acbd", "acdb", "adbc", "adcb",
                "bacd","badc", "bcad","bcda","bdac","bdca",
                "cabd","cadb","cbad","cbda","cdab","cdba",
                "dabc", "dacb", "dbac", "dbca", "dcab", "dcba"
            }}
        };
    }
    #endregion
}