public class Solution {
    public string ReverseWords(string s) {
        Stack<char> words = new Stack<char>();
        StringBuilder reversedWords = new StringBuilder();

        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] != ' '){
                words.Push(s[i]);
            }
            else if (s[i] == ' ' && words.Count > 0){
                while(words.Count > 0){
                    reversedWords.Append(words.Pop());
                }
                reversedWords.Append(' ');
            }
        }

        while(words.Count > 0){
            reversedWords.Append(words.Pop());
        }

        return reversedWords.ToString().Trim();
    }
}