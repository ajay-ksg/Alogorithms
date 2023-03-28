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
}