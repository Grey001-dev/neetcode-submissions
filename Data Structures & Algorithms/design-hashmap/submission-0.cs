public class MyHashMap {
    List<(int,int)> myMap;
    public MyHashMap() {
        myMap=new List<(int,int)>();
    }
    
    public void Put(int key, int value) {
        myMap.RemoveAll(x=>x.Item1==key);
        myMap.Add((key,value));
        return;
    }
    
    public int Get(int key) {
        foreach(var (first,second) in myMap){
            if(first==key){
                return second;
            }
        }
        return -1;
    }
    
    public void Remove(int key) {
        foreach(var (first,second) in myMap){
            if(first==key){
                myMap.Remove((first,second));
                return;
            }
        }
        return;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */