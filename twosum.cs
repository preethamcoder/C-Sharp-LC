public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Hashtable hashtable = new Hashtable();
        Dictionary<int, int> mp = new Dictionary<int, int>();
        int[] res = new int[2];
        int length = nums.Length;
        for(int ind = 0; ind < length; ind++){
            int diff = target-nums[ind];
            if(mp.ContainsKey(diff)){
                res[0] = ind;
                res[1] = mp[diff];
                // return res;
            }else{
                mp[nums[ind]] = ind;
            }
        }
        return res;
    }
}
