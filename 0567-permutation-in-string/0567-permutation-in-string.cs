public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)
            return false;

        int k = s1.Length; // Window size of s1 for s2

        int[] s1Window = new int[26]; // For frequeny mapping of s1
        int[] s2Window = new int[26]; // For frequeny mapping of s2

        int charIndex = 0;

        // Store frequency of the s1 string
        for(int i = 0; i < s1.Length; i++){
            charIndex = s1[i] - 'a';
            s1Window[charIndex]++;
        }
        
        // First window of the s2
        for(int j = 0; j < k; j++){
            charIndex = s2[j] - 'a';
            s2Window[charIndex]++;
        }

        // Check if first window is permutation? If Yes, Return True, else Move Ahead.
        if(IsPermutation(s1Window, s2Window))
            return true;

        // If the first window not permutation, window will be moved ahead by one and then checked everytime
        for(int m = k; m < s2.Length; m++){
            // Remove previous character from window
            charIndex = s2[m - k] - 'a';
            s2Window[charIndex]--;

            // Add new character to window
            charIndex = s2[m] - 'a';
            s2Window[charIndex]++;

            // Check if is permutation? 
            if(IsPermutation(s1Window, s2Window))
                return true;
        }

        return false;
    }

    public bool IsPermutation(int[] s1Window, int[] s2Window){
        for(int l = 0; l < 26; l++){
            if(s1Window[l] != s2Window[l])
                return false;
        }
        return true;
    }
}