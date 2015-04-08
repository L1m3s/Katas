using System;

public class GreatestCommonDivisorKata : IGreatestCommonDivisorKata
{
    public int CalcGcd(int number1, int number2)
    {
        int zahl1 = number1;
        int zahl2 = number2;
        int temp = 0;
        int ggt = 0;
        
        while (zahl1 % zahl2 != 0)
        {
            temp = zahl1 % zahl2;
            zahl1 = zahl2;
            zahl2 = temp;
        }

        ggt = zahl2;

        return ggt;
        //throw new NotImplementedException();
    }
}

public interface IGreatestCommonDivisorKata
{
    /// <summary>
    /// Calculate the 'greatest common divisor'
    /// </summary>
    /// <param name="number1">the first number ('numerator')</param>
    /// <param name="number2">the second number ('denominator')</param>
    /// <returns>GCD of number1 and number2</returns>
    int CalcGcd(int number1, int number2);
}