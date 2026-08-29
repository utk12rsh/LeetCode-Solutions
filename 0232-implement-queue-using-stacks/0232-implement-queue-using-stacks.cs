public class MyQueue {
    Stack<int> s1;
    Stack<int> s2;
    public MyQueue() {
        s1 = new Stack<int>();
        s2 = new Stack<int>();
    }
    
    public void Push(int x) {
        s2.Push(x);
    }
    
    public int Pop() {
        MoveIfNeeded();
        return s1.Pop();
    }
    
    public int Peek() {
        MoveIfNeeded();
        return s1.Peek();
    }
    
    public bool Empty() {
        // MoveIfNeeded();
        // return s1.Count == 0;

        return s1.Count == 0 && s2.Count == 0;
    }

    public void MoveIfNeeded(){
        if(s1.Count == 0 && s2.Count > 0){
            while(s2.Count > 0){
                s1.Push(s2.Pop());
            }
        }
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