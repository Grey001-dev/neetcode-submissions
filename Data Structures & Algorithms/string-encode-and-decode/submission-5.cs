public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count==0){
            return "";
        }
        int[] len=new int[strs.Count];
        int count=0;
        foreach(string s in strs){
            len[count]=s.Length;
            count++;
        }
        string encoded=string.Join(",",len);
        encoded+="#";
        string join=string.Join("",strs);
        encoded+=join;
        return encoded;
    }

    public List<string> Decode(string s) {
        if(s==""){
            return [];
        }
        if(s is null) return [];
        List<int> len=new List<int>();
        List<string> decoded=new List<string>();
        bool word=false;
        int start=0;
        string nums="";
        for(int i=0;i<s.Length;i++){
            if(!word){
                if(char.IsDigit(s[i])){
                    nums+=s[i];
                }
                if(s[i]==','){
                    int num=int.Parse(nums);
                    len.Add(num);
                    nums="";
                }
                if (s[i] == '#')
                    {
                        int num=int.Parse(nums);
                        len.Add(num);
                        nums="";
                        word = true;
                        start = i + 1;
                    }
            }
            
            
        }
        for(int i=0;i<len.Count;i++){
            int size=len[i];
            string substring=s.Substring(start,size);
            start+=size;
            decoded.Add(substring);
        }
        return decoded;
   }
}
