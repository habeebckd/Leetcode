public class Solution {
    public int RemoveDuplicates(int[] nums) {
           HashSet<int> seen = new HashSet<int>();
        int idx = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (!seen.Contains(nums[i])) {
                seen.Add(nums[i]);
                nums[idx++] = nums[i];
            }
        }

        return seen.Count;
    }
}