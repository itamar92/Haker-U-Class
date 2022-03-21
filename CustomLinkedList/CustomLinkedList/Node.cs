using System;
using System.Collections.Generic;
namespace CustomLinkedListPractice

{
	public class Node
	{

		internal Object Value { get; set; }
		internal Node prev;
		internal Node next { get; set; }


		public Node(Object value)
		{
			Value = value;
			prev = null;
			next = null;
		}
	}
}

