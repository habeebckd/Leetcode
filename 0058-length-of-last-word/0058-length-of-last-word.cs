public class Solution {
    public int LengthOfLastWord(string s) {
        // s = s.Trim() if use here reduse twise use trim
        string b = s.Trim().Split(" ").Last().Trim();
        return b.Length;
            }
}