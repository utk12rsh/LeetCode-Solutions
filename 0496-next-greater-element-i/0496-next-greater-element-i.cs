public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];

        Stack<int> s = new Stack<int>();
        Dictionary<int, int> map = new Dictionary<int, int>();

        s.Push(nums2[nums2.Length - 1]);
        map[nums2[nums2.Length - 1]] = -1;

        for(int i = nums2.Length-2; i>=0; i--){
            map[nums2[i]] = -1;
            if(nums2[i] <  s.Peek()){
                map[nums2[i]] = s.Peek();
                s.Push(nums2[i]);
            }
            else{
                while(s.Count > 0 && s.Peek() <= nums2[i])
{
    s.Pop();
}

if(s.Count > 0)
    map[nums2[i]] = s.Peek();
else
    map[nums2[i]] = -1;

s.Push(nums2[i]);
            }
        }

        for(int j = 0; j < nums1.Length; j++){
            result[j] = map[nums1[j]];
        }

        return result;
    }
}