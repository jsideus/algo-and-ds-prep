using System.Globalization;
using Microsoft.VisualBasic;

public class Solutions
{
    //You are given a binary array numbers, return the maximum number of consecutive 1's in the array.
    public int FindMaxConsecutiveOnes(int[] numbers)
    {
        int maxConsecutiveOnes = 0;
        int currentConsecutiveOnes = 0;

        for (var i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 1) { currentConsecutiveOnes = currentConsecutiveOnes + 1; }
            
            if (numbers[i] != 1)
            {
                if (currentConsecutiveOnes > maxConsecutiveOnes)
                {
                    maxConsecutiveOnes = currentConsecutiveOnes;
                }

                currentConsecutiveOnes = 0;
            }
        }

        if (currentConsecutiveOnes > maxConsecutiveOnes) { maxConsecutiveOnes = currentConsecutiveOnes; }

        return maxConsecutiveOnes;

    }
}