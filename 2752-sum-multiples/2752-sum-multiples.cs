public class Solution {
    public int SumOfMultiples(int n) {
        int count =0;
        for(int i=0;i<=n;i++){
            if(i%5==0||i%3==0||i%7==0){
                count+=i;
               
            }
           
        }
 return count;
    }
}