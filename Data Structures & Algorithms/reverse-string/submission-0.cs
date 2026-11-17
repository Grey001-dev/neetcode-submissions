public class Solution {
    public void ReverseString(char[] s) {
        int i=0;
        int j=s.Length-1;
        while(j>i){
            char save=s[i];
            s[i]=s[j];
            s[j]=save;
            i++;
            j--;
        }
    }
}