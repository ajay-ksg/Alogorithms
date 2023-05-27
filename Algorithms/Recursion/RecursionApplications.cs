namespace Algorithms.Recursion;

public class RecursionApplications
{
    #region Notes
    /*********** Recursion *****************
     * Def: Function calling function
     * It has 3 main steps
     *   - Initialisation
     *   - Termination
     *   - Recursive call
     */

    #endregion


    /*
     * N is a non negative number
     * Fib(0) == 0
     * Fib(1) == 1
     * Fib(n) = Fib(n-1)+Fib(n-2)
     */
    public int GetNthFibonacciNumber(int n)
    {
        if (n == 0 || n == 1)
            return n;
        return GetNthFibonacciNumber(n - 1) + GetNthFibonacciNumber(n - 2);
    }

    /*
     * Approach: pick the current char and get permutation of remaining chars in string
     * Time Complexity: O(n!*n*n)
     */
    public void GetStringPermutationHavingUniqueChars(string prefix, string input, List<string> permutations)
    {
        if (input.Length == 0)
        {
            permutations.Add(prefix);
            return;
        }

        for (int i = 0; i < input.Length; i++)
        {
            var c = input[i];
            var remainingStr = input.Substring(0,i-0) + input.Substring(1+i, input.Length-i-1);
            GetStringPermutationHavingUniqueChars((prefix + c), remainingStr, permutations);
            
        }
    }

    public void GetUniquePermutationOfStrHavingRepeatedChars(string prefix, string input, List<string> permutations)
    {
        var frequency = new int[26];
        foreach (var c in input)
        {
            frequency[c - 'a']++;
        }
        GetUniquePermutationHelper(prefix,frequency,input.Length,permutations);
        
    }

    private void GetUniquePermutationHelper(string prefix, int[] frequency, int inputLength, List<string> permutations)
    {
        if (inputLength == 0)
        {
            permutations.Add(prefix);
            return;
        }

        for (int i = 0; i < 26; i++)
        {
            if(frequency[i] <= 0) continue;
            var ch = (char)(i + ('a' - 0));
            frequency[i]--;
            inputLength--;
            GetUniquePermutationHelper(prefix + ch, frequency, inputLength,permutations);
            frequency[i]++;
            inputLength++;

        }
    }
}