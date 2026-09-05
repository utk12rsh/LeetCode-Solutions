public class Solution {
    public int StrStr(string haystack, string needle) {
        int hLength = haystack.Length;
        int nLength = needle.Length;
        int i = 0;

        while(i+(nLength-1) < hLength){
            StringBuilder sb = new StringBuilder();

            for(int k = i; k <= i+(nLength-1); k++){
                sb.Append(haystack[k]);
            }

            if(sb.ToString() == needle)
                return i;
            i++;
        }
        return -1;
    }
}