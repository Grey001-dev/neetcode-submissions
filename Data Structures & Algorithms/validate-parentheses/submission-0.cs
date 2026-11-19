public class Solution {
    public bool IsValid(string s) {
        Stack <char> myStack=new Stack<char>();
        for(int i=0; i<s.Length;i++){
            if(myStack.Count==0){
                myStack.Push(s[i]);
            }else{
                if(myStack.Peek()=='{' && s[i]=='}'){
                    myStack.Pop();
                }else if(myStack.Peek()=='(' && s[i]==')'){
                    myStack.Pop();
                }else if(myStack.Peek()=='[' && s[i]==']'){
                    myStack.Pop();
                }else{
                    myStack.Push(s[i]);
                }
                
            }
        }
        if(myStack.Count<=0){
            return true;
        }
        return false;
        
    }
}
