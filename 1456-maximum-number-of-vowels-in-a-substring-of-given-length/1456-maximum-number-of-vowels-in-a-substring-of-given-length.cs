public class Solution {
    public int MaxVowels(string s, int k) {
        int maxVowels = 0;
        int vowelsCount = 0;

        var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        // First Window
        for(int i = 0; i < k; i++){
            if(vowels.Contains(s[i]))
                vowelsCount++;
        }

        maxVowels = vowelsCount;
        
        // Moving window ahead everytime by one till last character
        for(int j = k; j < s.Length; j++){
            if(vowels.Contains(s[j - k]))
                vowelsCount--;

            if(vowels.Contains(s[j]))
                vowelsCount++;

            if(vowelsCount > maxVowels)
                maxVowels = vowelsCount;
        }

        return maxVowels;
    }
}