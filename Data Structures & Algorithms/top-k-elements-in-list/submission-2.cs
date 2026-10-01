public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequency=new Dictionary<int,int>();
        int count=0;
        foreach(int num in nums){
            if(!frequency.ContainsKey(num)){
                frequency[num]=0;
            }
            frequency[num]+=1;
        }
        Dictionary <int,int> sorted=frequency.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);
        List <int> result=new List<int>();
        foreach(var (key,value) in sorted){
            count++;
            if(count<=k){
                result.Add(key);
            }
        }
        int [] finalResult=result.ToArray();
        return finalResult;

    }
}
