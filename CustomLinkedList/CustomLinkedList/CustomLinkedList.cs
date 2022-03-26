using System;
using System.Collections;
using System.Collections.Generic;
using CustomLinkedListPractice;
namespace CustomLinkedListPractice
{
    public class CustomLinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Current { get; private set; }
        public Node<T> Last { get; private set; }

        public void Add(T value)
        {
            Node<T> newValue = new Node<T>(value);
            if (Current == null)
            {
                First = newValue;
                Current = newValue;
            }
            else
            {
                Current.next = newValue;
                newValue.prev = Current;
                Current = newValue;
            }
            Last = newValue;
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.next;
            }
        }
        public IEnumerable GetEnumerableDESC()
        {
            Node<T> current = Last;
            while (current != null)
            {
                yield return current.Value;
                current = current.prev;
            }
        }
    }
}

