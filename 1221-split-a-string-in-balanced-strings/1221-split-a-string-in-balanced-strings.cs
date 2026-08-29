public class Solution {
    public int BalancedStringSplit(string s) {
        int count = 0;
        int balance = 0;

        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'L')
                balance++;
            else
                balance--;

            if(balance == 0)
                count++;
        }
        return count;
    }
}