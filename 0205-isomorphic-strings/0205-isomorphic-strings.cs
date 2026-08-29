public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length)
            return false;

        Dictionary<char, char> map = new Dictionary<char,char>();
        HashSet<char> values = new HashSet<char>();

        for(int i = 0; i < s.Length; i++){
            if(map.ContainsKey(s[i])){
                if(map[s[i]] != t[i])
                    return false;
            }
            else{
                if(values.Contains(t[i]))
                    return false;

                map[s[i]] = t[i];
                values.Add(t[i]);
            }
        }
        return true;
    }
}