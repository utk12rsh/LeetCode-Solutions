public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> anagramIndices = new List<int>();

        if(p.Length > s.Length)
            return anagramIndices;
        
        int k = p.Length;
        int[] pWindow = new int[26];
        int[] sWindow = new int[26];

        // Frequency mapping for the p string
        for(int i = 0; i < p.Length; i++){
            pWindow[p[i] - 'a']++;
        }

        // First window of the s string
        for(int j = 0; j < k; j++){
            sWindow[s[j] - 'a']++;
        }

        // Check if first window is anagram
        if(IsAnagram(sWindow, pWindow))
            anagramIndices.Add(0);
        
        for(int l = k; l < s.Length; l++){
            // Remove previous character
            sWindow[s[l - k] - 'a']--;

            // Add new character
            sWindow[s[l] - 'a']++;

            if(IsAnagram(sWindow, pWindow))
                anagramIndices.Add(l - k + 1);
        }

        return anagramIndices;
    }

    public bool IsAnagram(int[] sWindow, int[] pWindow){
        for(int m = 0; m < 26; m++){
            if(sWindow[m] != pWindow[m])
                return false;
        }
        return true;
    }
}