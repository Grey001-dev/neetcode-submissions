public class Solution {
    public bool ValidPalindrome(string s) {
        int i=0;
        int j=s.Length-1;
        int count=0;
        int previ=0;
        int prevj=0;
        while(j>i){
            if(s[j]!=s[i]){
                count++;
                if(count==1){
                    previ=i;
                    prevj=j-1;
                }
                if(s[i+1]!=s[j]){
                   return checkRight(s,previ,prevj);
                }
                
            }

            i++;
            j--;
            
        }
        return true;

        bool checkRight(string s,int left,int right){
            while(right>left){
                if(s[right]!=s[left]){
                    return false;
                }
                right--;
                left++;
            }
            return true;
        }
    }
}