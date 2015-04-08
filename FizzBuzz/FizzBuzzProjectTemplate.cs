using System;

public class FizzBuzzKata : IFizzBuzzKata
{
    public string Answer(int i)
    {
        if (i % 3 == 0 && i % 5 == 0) return "fizzbuzz";
        if (i % 3 == 0) return "fizz";
        if (i % 5 == 0) return "buzz";
        return i.ToString();
        //throw new NotImplementedException();
    }
}

public interface IFizzBuzzKata
{
    /// <summary>
    /// Give an answer to the current game
    /// </summary>
    /// <param name="number">current number in the game sequence</param>
    /// <returns>appropriate answer to the current number</returns>
    string Answer(int number);
}