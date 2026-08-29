public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0;
        int end = s.Length - 1;
    
        while(start < end){
            while((start < end) && !IsLetterOrDigit(char.ToLower(s[start]))){
                start++;
            }
            
            while((start < end) && !IsLetterOrDigit(char.ToLower(s[end]))){
                end--;
            }

            if(char.ToLower(s[start]) != char.ToLower(s[end]))
                return false;
            
            start++;
            end--;
        }
        return true;
    }

    public bool IsLetterOrDigit(char ch){
        if((ch>='a' && ch<='z') || (ch >= '0' && ch <= '9'))
            return true;
        return false;
    }
}