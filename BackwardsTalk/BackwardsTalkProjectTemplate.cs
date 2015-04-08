using System;
using System.Collections.Generic;

public class BackwardsTalkKata : IBackwardsTalkKata
{
    public string Revert(string word)
    {
        char[] splitter = word.ToCharArray();
        char[] reverse = new char[splitter.Length];
        for (int i = 0; i < splitter.Length; i++ )
        {
            reverse[(splitter.Length - 1) - i] = splitter[i];
        }
        return reverse.ToString();
        //throw new NotImplementedException();
    }
}

public interface IBackwardsTalkKata
{
    /// <summary>
    /// Revert a word in 'backward talk' to understand it
    /// </summary>
    /// <param name="word">the backwards word</param>
    /// <returns>the regular word</returns>
    string Revert(string word);
}