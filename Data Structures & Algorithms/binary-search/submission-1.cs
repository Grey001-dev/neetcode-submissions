public class Solution {
    public int Search(int[] nums, int target) {
        int i=0;
        int j=nums.Length-1;
        int avg=0;
        while(j>=i){
            avg=(i+j)/2;
            if(nums[avg]==target){
                return avg;
            }
            if(nums[avg]>target){
                j=avg-1;
            }
            if(nums[avg]<target){
                i=avg+1;
            }
        }
        return -1;
    }
}
