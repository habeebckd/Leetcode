public class Solution {
    public string ComplexNumberMultiply(string num1, string num2) {
        // Parse the first complex number
        string[] parts1 = num1.Split(new char[] {'+', 'i'}, StringSplitOptions.RemoveEmptyEntries);
        int a = int.Parse(parts1[0]);
        int b = int.Parse(parts1[1]);
        
        // Parse the second complex number
        string[] parts2 = num2.Split(new char[] {'+', 'i'}, StringSplitOptions.RemoveEmptyEntries);
        int c = int.Parse(parts2[0]);
        int d = int.Parse(parts2[1]);
        
        // Compute the real and imaginary parts of the product
        int realPart = a * c - b * d;
        int imagPart = a * d + b * c;
        
        // Return the result as a string
        return $"{realPart}+{imagPart}i";
    }
}