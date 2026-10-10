public class Solution {
    public string ReverseWords(string s) {
        int j = s.Length - 1;
        int i = j;
        StringBuilder reversedWords = new StringBuilder();

        while(i >= 0 && j >= 0){
            StringBuilder word = new StringBuilder();

            while(j >= 0 && s[j] == ' '){
                j--;
            }

            if(j < 0)
                return reversedWords.ToString().Trim();
        
            i = j;
            while(i >= 0 && s[i] != ' '){
                i--;
            }

            for(int k = i + 1; k <= j; k++){
                word.Append(s[k]);
            }    
            
            j = i;

            reversedWords.Append(word.ToString());
            reversedWords.Append(' ');
        }
        return reversedWords.ToString().Trim();   
    }
}