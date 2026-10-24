public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] combined = nums.Concat(nums).ToArray();
        return combined;
    }
}