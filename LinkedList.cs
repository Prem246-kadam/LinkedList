public class LinkedList
{
    public Node head;



    public void AddNode(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
    }
    public void DisplayList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + "--->");
            current = current.next;
        }
        Console.WriteLine("Null");
    }
    public void length(){
        int count =0;
        Node currentNode = head;
        
        while(currentNode != null){
            count++;
           currentNode = currentNode.next;
        }
        Console.WriteLine(count);
    }
     public void RemoveFirstNode()
    {
        if (head != null)
        {
            head = head.next;
        }
    }
}
    
