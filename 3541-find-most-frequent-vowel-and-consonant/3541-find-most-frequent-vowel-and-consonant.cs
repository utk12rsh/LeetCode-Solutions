public class Solution {
    public int MaxFreqSum(string s) {
        int[] freq = new int[26];

        for(int i = 0; i < s.Length; i++){
            int index = s[i] - 'a';
            freq[index]++;
        }
        
        int maxVowel = 0;
        int maxConstant = 0;
        for(int j = 0; j < 26; j++){
            char ch = (char)(j + 'a');

            if(IsVowel(ch)){
                maxVowel = Math.Max(maxVowel, freq[j]);
            }
            else{
                maxConstant = Math.Max(maxConstant, freq[j]);
            }
        }
    return maxVowel + maxConstant;
    }

    public bool IsVowel(char ch)
{
    switch (ch)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            return true;

        default:
            return false;
    }
}
}