public class MyQueue {
    Stack<int> s;
    Stack<int> st;
    public MyQueue() {
        s=new Stack<int>();
        st=new Stack<int>();
    }
    
    public void Push(int x) {
        st=new Stack<int>();
        s.Push(x);
        foreach(int num in s){
            st.Push(num);
        }
    }
    
    public int Pop() {
        int num=st.Pop();
        s=new Stack<int>();
        foreach(int n in st){
            s.Push(n);
        }
        return num;
        

    }
    
    public int Peek() {
        return st.Peek();
    }
    
    public bool Empty() {
        if(st.Count==0){
            return true;
        }
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */