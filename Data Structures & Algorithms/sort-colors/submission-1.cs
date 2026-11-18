public class Solution {
    public void SortColors(int[] nums) {
        quickSort(nums,0,nums.Length-1);

        void quickSort(int[] nums, int low, int high){
            if(high<=low){
                return;
            }
            int p=partition(nums,low,high);
            quickSort(nums,low,p-1);
            quickSort(nums,p+1,high);
        }

        int partition(int[] nums, int low, int high){
            int pivot=nums[high];
            int i=low-1;
            for(int j=low;j<high;j++){
                if(nums[j]<pivot){
                    i++;
                    int temp=nums[i];
                    nums[i]=nums[j];
                    nums[j]=temp;
                }
            }
            int save=nums[i+1];
            nums[i+1]=pivot;
            nums[high]=save;
            return i+1;
        }
    }
}