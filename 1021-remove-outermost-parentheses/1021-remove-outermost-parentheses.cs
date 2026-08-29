public class Solution {
    public string RemoveOuterParentheses(string s) {
        int count = 0;
        var sb = new StringBuilder();
        foreach(char c in s){
            if(c == '('){
                count++;
                if(count > 1)
                    sb.Append(c);
            }
            else{
                count--;
                if(count > 0)
                    sb.Append(c);
            }
        }
        return sb.ToString();
    }
}