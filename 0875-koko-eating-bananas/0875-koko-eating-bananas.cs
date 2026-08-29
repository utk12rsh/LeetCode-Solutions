public class Solution
{
    public int FindMaximumInPiles(int[] piles)
    {
        int maxVal = piles[0];

        for (int i = 1; i < piles.Length; i++)
        {
            if (piles[i] > maxVal)
                maxVal = piles[i];
        }

        return maxVal;
    }

    public bool CanBananaBeFinished(int[] piles, int givenHour, int mid)
    {
        int hour = 0;

        for (int i = 0; i < piles.Length; i++)
        {
            int hourPerPile =
                (int)Math.Ceiling((double)piles[i] / mid);

            hour += hourPerPile;
        }

        return hour <= givenHour;
    }

    public int MinEatingSpeed(int[] piles, int h)
    {
        int start = 1;
        int end = FindMaximumInPiles(piles);

        while (start < end)
        {
            int mid = start + (end - start) / 2;

            if (CanBananaBeFinished(piles, h, mid))
                end = mid;
            else
                start = mid + 1;
        }

        return start;
    }
}