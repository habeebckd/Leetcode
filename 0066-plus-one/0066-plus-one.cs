public class Solution {
    public int[] PlusOne(int[] digits) {
        string first = string.Concat(digits);
        BigInteger second = BigInteger.Parse(first);
        BigInteger third = second+1;
        string forth = third.ToString(); 
        return forth.Select(c => int.Parse(c.ToString())).ToArray();
    }
}