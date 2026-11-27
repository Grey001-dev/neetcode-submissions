public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int avg=0;
        int i=0;
        int j=nums.Length-1;
        int res=0;
        while(j>=i){
            avg=(j+i)/2;
            if(nums[avg]==target){
                return avg;
            }
            if(nums[avg]<target){
                i=avg+1;
                res=avg+1;
            }
            if(nums[avg]>target){
                j=avg-1;
            }
        }
        return res;
    }
}