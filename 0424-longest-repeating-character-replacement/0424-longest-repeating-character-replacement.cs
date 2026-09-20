public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];

        int left = 0;
        int maxWindowSize = 0;
        int maxCount = 0;

        for (int right = 0; right < s.Length; right++)
        {
            freq[s[right] - 'A']++;

            maxCount = Math.Max(maxCount, freq[s[right] - 'A']);
            int windowSize = right - left + 1;
            int kCurrVal = windowSize - maxCount;

            while (kCurrVal > k)
            {
                freq[s[left] - 'A']--;
                left++;

                windowSize = right - left + 1;
                kCurrVal = windowSize - maxCount;
            }

            if(windowSize > maxWindowSize)
                maxWindowSize = windowSize;
        }
        return maxWindowSize;
    }
}