public class Solution {
    public int LongestConsecutive(int[] nums) {
        // int partition(int[] nums, int low ,int high){
        //     int pivot=nums[high];
        //     int i=low-1;
        //     for(int j=low;j<nums.Length;j++){
        //         if(nums[j]<pivot){
        //             i++;
        //             int temp=nums[j];
        //             nums[j]=nums[i];
        //             nums[i]=temp;
        //         }
        //     }
        //     int save=nums[high];
        //     nums[high]=nums[i+1];
        //     nums[i+1]=save;
        //     return i+1;
        // }
        // void quickSort(int[] nums,int low,int high){
        //     if(high<=low){
        //         return;
        //     }
        //     int p=partition(nums,low,high);
        //     quickSort(nums,low,p-1);
        //     quickSort(nums,p+1,high);
        // }
        if(nums.Length==0){
            return 0;
        }
        // quickSort(nums,0,nums.Length-1);
        Array.Sort(nums);
        int count=1;
        int prev=nums[0];
        int longest=1;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==prev+1){
                count++;
                prev=nums[i];
                if(count>longest){
                    longest=count;
                }
            }else if(nums[i]<prev+1){
                continue;
            }else{
                prev=nums[i];
                count=1;
            }
        }
        return longest;
    }
}
