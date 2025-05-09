public class Solution {
    public int MaximumWealth(int[][] accounts) {
        return accounts.Max(a=>a.Sum());

    }
}