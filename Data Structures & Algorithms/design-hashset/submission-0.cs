public class MyHashSet {
    List<int> mySet;
    public MyHashSet() {
        mySet=new List<int>();
    }
    
    public void Add(int key) {
       if (mySet.Contains(key)){
            return;
       }
       mySet.Add(key);
       return;
    }
    
    public void Remove(int key) {
        mySet.Remove(key);
    }
    
    public bool Contains(int key) {
        if(mySet.Contains(key)){
            return true;
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */