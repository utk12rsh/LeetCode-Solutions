/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int start = 1;
        int end = n;
        int badVersion = 0;
        while(start <= end){
            int mid = start + (end - start)/2;
            bool isBadVersion = IsBadVersion(mid);
            if(isBadVersion){
                badVersion = mid;
                end = mid - 1;
            }
            else{
                start = mid + 1;
            }
        }
        return badVersion;
    }
}