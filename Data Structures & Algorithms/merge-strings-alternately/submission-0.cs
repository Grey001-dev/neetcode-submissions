public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int len1=word1.Length;
        int len2=word2.Length;
        int length=0;
        int j=0;
        int k=0;
        string merged="";

        if(len1>len2){
            length=len1;
        }else{
            length=len2;
        }
        for(int i=0;i<length;i++){
            if(j<word1.Length){
                merged+=word1[j];
                j++;
            }
            if(k<word2.Length){
                merged+=word2[k];
                k++;
            }
        }
        return merged;
    }
}