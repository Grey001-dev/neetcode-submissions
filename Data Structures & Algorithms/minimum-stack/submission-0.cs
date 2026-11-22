public class MinStack {
    List<int> myStack;
    public MinStack() {
        myStack=new List<int>();
    }
    
    public void Push(int val) {
        myStack.Add(val);
    }
    
    public void Pop() {
        if(myStack.Count==0){
            return;
        }
        myStack.RemoveAt(myStack.Count-1);
    }
    
    public int Top() {
        if(myStack.Count==0){
            return 0;
        }
        return myStack[myStack.Count-1];
    }
    
    public int GetMin() {
        if(myStack.Count==0){
            return 0;
        }
        return myStack.Min();
    }
}
