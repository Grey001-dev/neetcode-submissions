public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hash=new Dictionary<int,int>();
        int subtraction=0;
        int index=0;
        for(int i=0;i<nums.Length;i++){
            subtraction=target-nums[i];
            if(hash.ContainsKey(subtraction)){
                index=i;
                break;
            }
            hash[nums[i]]=i;
        }
        return [hash[subtraction],index];
    }
}
