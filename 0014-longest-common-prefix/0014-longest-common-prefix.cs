public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int x = 0;
        while(x < strs[0].Length){
            char ch = strs[0][x];

            for(int i = 1; i < strs.Length; i++){
               if(x == strs[i].Length || strs[i][x] != ch){
                return strs[0].Substring(0, x);
               }
            }
            x++;
        }
        return strs[0];
    }
}