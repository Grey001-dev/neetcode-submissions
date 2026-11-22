public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int i=0;
        int j=i+1;
        if(nums.Length==0 || nums.Length==1){
            return false;
        }
        while(i<nums.Length-1){
            if(nums[i]==nums[j] && Math.Abs(i-j)<=k){
                return true;
            }
            j++;
            if(j==nums.Length){
                i++;
                j=i+1;
            }
        }
        return false;
    }
}