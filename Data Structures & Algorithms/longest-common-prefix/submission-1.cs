public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string first=strs[0];
        int index=200;
        if(strs.Length==1){
            return strs[0];
        }
        int j=0;
        for(int i=1;i<strs.Length;i++){
            for(j=0;j<Math.Min(first.Length,strs[i].Length);j++){
                if(first[j]!=strs[i][j]){
                    break;
                }
            }
            j++;
            index=Math.Min(index,j);
        }
        return first.Substring(0,index-1);
    }

}