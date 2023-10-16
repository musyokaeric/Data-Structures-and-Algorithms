using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CircularLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }

        public void AddLast(int element)
        {
            Node newest = new Node(element, null);

            if (IsEmpty)
            {
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }
            tail = newest;
            size++;
        }

        public void AddFirst(int element)
        {
            Node newest = new Node(element, null);

            if (IsEmpty)
            {
                newest.next = newest;
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void AddAny(int element, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position.");
                return;
            }

            Node newest = new Node(element, null);
            Node p = head;
            int i = 1;

           while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            newest.next = p.next;
            p.next = newest;
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            int element = head.element;
            tail.next = head.next;
            head = head.next;
            size--;

            if (IsEmpty)
            {
                head = null;
                tail = null;
            }
            return element;
        }

        public int RemoveLast()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            Node p = head;
            int i = 1;

            while (i < size - 1)
            {
                p = p.next;
                i++;
            }

            tail = p;
            p = p.next;
            tail.next = head;
            size--;

            return p.element;
        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position.");
                return -1;
            }

            Node p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            int element = p.next.element;
            p.next = p.next.next;
            size--;

            return element;
        }

        public void Display()
        {
            Node p = head;
            int i = 0;

            while (i < Length)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
                i++;
            }
            Console.WriteLine();
        }
    }
}
