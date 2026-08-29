public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int start = 0;
        int end = letters.Length - 1;
        char smallestGreater = letters[0];

        while(start <= end){
            int mid = start + (end - start)/2;

            if(letters[mid] <= target){
                start = mid + 1;
            }
            else{
                smallestGreater = letters[mid];
                end = mid - 1;
            }
        }

        return smallestGreater;
    }
}