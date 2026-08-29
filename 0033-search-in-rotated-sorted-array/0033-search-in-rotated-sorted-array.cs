public class Solution {
    public int Search(int[] arr, int target) {
        int start = 0;
        int end = arr.Length - 1;

        while(start <= end){
            int mid = start+(end-start)/2;
            
            if(arr[mid] == target)
                return mid;

            // Left array is sorted, Search in this part first
            if(arr[start] <= arr[mid]) 
            {
                if(target >= arr[start] && target < arr[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            // Right part is sorted, Search in this part first
            else
            {
                if(target > arr[mid] && target <= arr[end])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
        }

        return -1;
    }
}