using System;
using System.Collections.Generic;
namespace CustomLinkedListPractice

{
    public class Node<T>
    {
        internal T Value { get; set; }
        internal Node<T> prev { get; set; }
        internal Node<T> next { get; set; }
        public Node() { }
        public Node(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

