public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k=nums.Length-nums.Count(x=>x==val);
        int i=0;
        int j=nums.Length-1;
        while(j>=i){
            if(nums[i]!=val){
                i++;
                continue;
            }
            if(nums[i]==val && nums[j]!=val){
                int temp=nums[i];
                nums[i]=nums[j];
                nums[j]=temp;
                i++;
            }
            j--;
        }
        return k;
    }
}