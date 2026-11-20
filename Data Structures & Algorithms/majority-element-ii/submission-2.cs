public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int frequency = nums.Length / 3;
        HashSet<int> major=new HashSet<int>();
        List<int> answer=new List<int>();
        for(int i=0;i<nums.Length;i++){
            if(major.Contains(nums[i])){
                continue;
            }
            if(nums.Count(x=>x==nums[i])>frequency){
                major.Add(nums[i]);
            }
        }
        foreach(int n in major){
            answer.Add(n);
        }
        return answer;
    }
}