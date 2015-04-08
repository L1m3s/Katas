using System;
using System.Collections.Generic;

public class FibonacciKillerKata : IFibonacciKillerKata
{
    public int Fibonacci(int n)
    {
        List<int> fiboList = new List<int>();
        
        if (n == 0) return 0;
        if (n == 1) return 1;
        fiboList.Add(0);
        fiboList.Add(1);

        for (int i = 2; i <= n; i++ )
        {

            fiboList.Add(fiboList[i - 1] + fiboList[i - 2]);
        }
        return fiboList[fiboList.Count-1];

        // throw new NotImplementedException();
    }

}

public interface IFibonacciKillerKata
{
    /// <summary>
    /// Calculate an element of the Fibonacci sequence
    /// </summary>
    /// <param name="n">element number</param>
    /// <returns>n-th element of the Fibonacci sequence</returns>
    int Fibonacci(int n);
}