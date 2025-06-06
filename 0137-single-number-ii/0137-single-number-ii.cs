public class Solution {
    public int SingleNumber(int[] nums) {
     var uniqueNumbers = nums
            .GroupBy(x => x)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key)
            .First();

        return uniqueNumbers;
        
    }
}