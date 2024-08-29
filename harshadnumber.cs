public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int res = 0;
        int n = x;
        while(n != 0){
            res += n % 10;
            n /= 10;
        }
        if(x % res == 0){
            return res;
        }
        return -1;
    }
}
