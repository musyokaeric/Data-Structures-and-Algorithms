using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Stacks
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n) 
        {
            element = e;
            next = n;
        }
    }

    public class StackLinked
    {
        Node top;
        int size;

        public StackLinked()
        {
            top = null;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }

        public void Push(int value)
        {
            Node newest = new Node(value, null);
            if (IsEmpty)
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }
            size++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty/underflow.");
                return -1;
            }
            int value = top.element;
            top = top.next;
            size--;
            return value;
        }

        public int Peek() => IsEmpty ? -1 : top.element;

        public void Display()
        {
            Node p = top;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
