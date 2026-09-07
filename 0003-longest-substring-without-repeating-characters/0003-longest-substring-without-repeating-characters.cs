public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int index = 0;
        int longestLength = 0;
        int[] sWindow = new int[128];

        for(int i = 0; i < s.Length; i++){        
            sWindow[s[i]]++;

            while(sWindow[s[i]] > 1){
                sWindow[s[index]]--;
                index++;
            }

            int length = (i - index) + 1;
            if(length > longestLength)
                longestLength = length;
        }

        return longestLength;
    }
}