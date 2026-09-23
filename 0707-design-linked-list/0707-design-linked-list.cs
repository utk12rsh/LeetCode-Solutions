public class MyLinkedList {
    Node head = null;

    public MyLinkedList() {
        
    }
    
    public int Get(int index) {
        Node temp = head;
        int count = 0;

        while(count < index && temp != null && temp.next != null){
            temp = temp.next;
            count++;
        }

        if(temp == null || count != index)
            return -1;

        return temp.val;
    }
    
    public void AddAtHead(int val) {
        Node node = new Node(val);
        
        node.next = head;
        if(head != null)
            head.prev = node;

        head = node;
    }
    
    public void AddAtTail(int val) {
        Node node = new Node(val);

        if(head == null){
            head = node;
        }
        else{
            Node temp = head;

            while(temp.next != null){
                temp = temp.next;
            }

            temp.next = node;
            node.prev = temp;
        }
    }
    
    public void AddAtIndex(int index, int val) {
        int length = GetLinkedListLength();

        if(index > length)
            return;

        if(index == 0){
            AddAtHead(val);
        }
        else if(index == length){
            AddAtTail(val);
        }
        else{
            Node temp = head;
            int count = 0;

            while(count < index - 1){
                temp = temp.next;
                count++;
            }

            Node node = new Node(val);
            node.next = temp.next;
            temp.next.prev = node;
            temp.next = node;
            node.prev = temp;
        }
    }
    
    public void DeleteAtIndex(int index) {
        int length = GetLinkedListLength();

        if(index < 0 || index > length - 1)
            return;
        
        if(index == 0){
            head = head.next;

            if(head != null)
                head.prev = null;

            return;
        }    
        else if(index == length - 1){
           Node tailTemp = head;

            while(tailTemp.next.next != null){
                tailTemp = tailTemp.next;
            }

            tailTemp.next = null;
            return;
        }

        Node temp = head;
        int count = 0;

        while(count < index - 1){
            temp = temp.next;
            count++;
        }

        temp.next.next.prev = temp;
        temp.next = temp.next.next;
    }

    public int GetLinkedListLength(){
        Node temp = head;
        int length = 0;

        while(temp != null){
            length++;
            temp = temp.next;
        }

        return length;
    }

    public class Node{
        public int val;
        public Node? prev;
        public Node? next;

        public Node(int val){
            this.val = val;
            this.prev = null;
            this.next = null;
        }
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