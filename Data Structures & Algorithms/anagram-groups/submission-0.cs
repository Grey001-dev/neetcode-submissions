public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string,List<string>> Anagrams=new Dictionary <string,List<string>>();
        for(int i=0;i<strs.Length;i++){
            string s=strs[i];
            string sorteds=new string(s.OrderBy(c=>c).ToArray());
            if(!Anagrams.ContainsKey(sorteds)){
                Anagrams[sorteds]=new List<string>();
            }
            Anagrams[sorteds].Add(s);
        }
        List<List<string>> arrs = new List<List<string>>();
        foreach(var (s,arr) in Anagrams){
            arrs.Add(arr);
        }
        return arrs;
        
        
    }
}
