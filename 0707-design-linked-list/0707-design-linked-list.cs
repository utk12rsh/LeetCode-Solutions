public class MyLinkedList {

    Node head;
    Node tail;
    public MyLinkedList() {
        
    }
    
    public int Get(int index) {
        Node current = head;
        int position = 0;
        
        while(current != null){
            if(position == index){
                return current.data;
            }
            current = current.next;
            position++;
        }
        return -1;
    }
    
    public void AddAtHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
    }
    
    public void AddAtTail(int val) {
        Node newNode = new Node(val);

        if(head == null){
            head = newNode;
            return;
        }
        
        Node tail = head;
        while(tail.next != null){
            tail = tail.next;
        }
        tail.next = newNode;
    }
    
    public void AddAtIndex(int index, int val) {
        if(index < 0)
            return;

        if(index == 0){
            AddAtHead(val);
        }
        else{
            Node newNode = new Node(val);
            int position = 0;
            Node current = head;
            while(current != null){
                if(position == index-1){
                    newNode.next = current.next;
                    current.next = newNode;
                    return;
                }
                current = current.next;
                position++;
            }
        }
    }
    
    public void DeleteAtIndex(int index) {
        if(index < 0 || head == null)
            return;
        
        if(index == 0 && head != null){
            Node nodeToBeDeleted = head;
            head = head.next;
            nodeToBeDeleted.next = null;
            return ;
        }

        Node current = head;
        int position = 0;

        while(current != null){
            if(position == index-1 && current.next != null){
                Node nodeToBeDeleted = current.next;
                current.next = current.next.next;
                nodeToBeDeleted.next = null;
            }
            current = current.next;
            position++;
        }
    }
}

public class Node{
    public int data;
    public Node next;

    public Node(int data){
        this.data = data;
        this.next = null;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */