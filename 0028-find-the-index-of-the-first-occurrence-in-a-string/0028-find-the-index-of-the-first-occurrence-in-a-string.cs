public class Solution {
    public int StrStr(string haystack, string needle) {
        int hLength = haystack.Length;
        int nLength = needle.Length;
        int i = 0;

        while(i+(nLength-1) < hLength){
            int s = i;
            int t = 0;
            while(t < nLength){
                if(haystack[s] != needle[t]){
                    i++;
                    break;
                }
                else{
                    s++;
                    t++;
                }
            }

            if(t == nLength)
                return i;
        }
        return -1;
    }
}