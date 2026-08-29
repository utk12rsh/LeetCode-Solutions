/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
       int length = mountainArr.Length();

       int start = 0;
       int end = length-1;

       while(start < end){
        int mid = start + (end - start) / 2;
        int val = mountainArr.Get(mid);
        int valplusone = mountainArr.Get(mid + 1);

        if(val < valplusone)
            start = mid + 1;
        else
            end = mid;
       }

       int peakIndex = start;
       start = 0;
       end = peakIndex;

       while(start <= end){
        int mid = start + (end - start) / 2;
        int val = mountainArr.Get(mid);

        if(val == target)   
            return mid;
        else if(val < target)
            start = mid + 1;
        else
            end = mid - 1;
       }

       if(peakIndex < length){
            start = peakIndex + 1;
            end = length - 1;

            while(start <= end){
                int mid = start + (end - start) / 2;
                int val = mountainArr.Get(mid);

                if(val == target)   
                    return mid;
                else if(val < target)
                    end = mid - 1;
                else
                    start = mid + 1;
            }  
        }

        return -1;
    }
}