public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product=1;
        int zeroCount=0;
        int[] productArr=new int[nums.Length];
        foreach(int num in nums){
            if(num==0){
                zeroCount+=1;
                continue;
            }
            product *=num;
        }
        for(int i=0;i<nums.Length;i++){
            if(zeroCount>1){
                productArr[i]=0;
                continue;
            }
            if(zeroCount==1){
                if(nums[i]==0){
                    productArr[i]=product;
                }else{
                    productArr[i]=0;
                }
                continue;
            }
            productArr[i]=product/nums[i];

        }
        return productArr;
    }
}
