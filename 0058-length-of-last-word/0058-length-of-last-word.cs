public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        s = s.Trim();
        string[] words = s.Split(' ');
        return words[words.Length-1].Length;
    }
}