using System;

public class NasaCountdownKata : INasaCountdownKata
{
    public int[] Countdown(int start)
    {
        int[] countdown = new int[start+1];
        for (int i = 0; i < countdown.Length; i++ )
        {
            countdown[i] = start--;
        }
            return countdown;
        //throw new NotImplementedException();
    }
}

public interface INasaCountdownKata
{
    /// <summary>
    /// Issue the NASA countdown
    /// </summary>
    /// <param name="start">number to start with</param>
    /// <returns>array with numbers from 'start' to 0</returns>
    int[] Countdown(int start);
}