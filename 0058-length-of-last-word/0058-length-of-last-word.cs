public class Solution {
    public int LengthOfLastWord(string s) {
        s=s.Trim();
        string b = s.Split(" ").Last();
        return b.Length;
            }
}