public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int start = 0;
        int end = arr.Length - k;

        while (start < end) {
            int mid = start + (end - start) / 2;

            if (x - arr[mid] > arr[mid + k] - x)
                start = mid + 1;
            else
                end = mid;
        }

        List<int> resultList = new List<int>();

        int i = start;

        while (i < start + k) {
            resultList.Add(arr[i]);
            i++;
        }

        return resultList;
    }
}