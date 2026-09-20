public class Solution {
    public int ReverseDegree(string s) {
        int reverseDegree = 0;
        for(int i = 0; i < s.Length; i++){
            int reverseDegreePerChar = 26 - (s[i] - 'a');
            reverseDegreePerChar = reverseDegreePerChar * (i + 1);
            reverseDegree = reverseDegree + reverseDegreePerChar;
        }
        return reverseDegree;
    }
}