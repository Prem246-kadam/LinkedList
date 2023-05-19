using System;
using Collection.Generic;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Adding nodes to the linked list
        list.AddNode(56);
        list.AddNode(30);
        list.AddNode(70);
         list.AddNode(80);

        // Displaying the linked list
        list.DisplayList();
     

     list.RemoveFirstNode();
        list.DisplayList();
list.length();
        Console.WriteLine();
    }
}
