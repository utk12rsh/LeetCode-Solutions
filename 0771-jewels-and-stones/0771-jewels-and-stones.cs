public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> jewelSet = new HashSet<char>();
        int count = 0;

        foreach(char jewel in jewels){
            jewelSet.Add(jewel);
        }

        foreach(char stone in stones){
            if(jewelSet.Contains(stone)){
                count++;
            }
        }
        return count;
    }
}