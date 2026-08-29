public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>> ();

        foreach(string word in strs){
            char[] charArray = word.ToCharArray();
            
            int[] freq = new int[26];
            foreach(var c in charArray){
                int index = c - 'a';
                freq[index]++;
            }

            string key = string.Join("#", freq);

            if(!dict.ContainsKey(key)){
                dict[key] = new List<string>();
            }
            dict[key].Add(word);
        }

        return dict.Values.ToList();
    }
}