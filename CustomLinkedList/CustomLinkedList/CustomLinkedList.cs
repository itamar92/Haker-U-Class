using System;
using System.Collections.Generic;
using CustomLinkedListPractice; 
namespace CustomLinkedListPractice
{
    public class CustomLinkedList<Node>
    {
        private Node head;
        public Node First { get; set; }
        public Node Current { get { return head; } }
        public Node Last { get; set; }

       public void Add(Object value)
        {
            Node toAdd = new Node();

            toAdd.Value = value;
            toAdd.next = head;
        }



    }


}

