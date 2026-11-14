public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary <int,int> dict=new Dictionary<int,int>();
        int half=nums.Length/2;
        int save=0;
        for(int i=0; i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]+=1;
            }
            else
                {
                    dict[nums[i]]=1;
                }
        }
        foreach(var (key,value) in dict){
            if(value>=half){
                save=key;
                break;
            }
        }
        return save;

    }
}