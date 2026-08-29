/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int start = 1;
        int end = n;

        int mid = start + (end - start)/2;

        while(start <= end){
            mid = start + (end - start)/2;
            int guessed = guess(mid);
            if(guessed == -1){
               end = mid - 1; 
            }
            else if(guessed == 1){
                start = mid + 1;
            }
            else{
                break;
            }
        }
        return mid;
    }
}