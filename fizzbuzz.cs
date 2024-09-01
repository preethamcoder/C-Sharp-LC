public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<String> res = new List<String>();
        for(int ind = 1; ind < n+1; ind++){
            if(ind % 15 == 0){
                res.Add("FizzBuzz");
            }else if(ind % 5 == 0){
                res.Add("Buzz");
            }else if(ind % 3 == 0){
                res.Add("Fizz");
            }else{
                res.Add(ind.ToString());
            }
        }
        return res;
    }
}
