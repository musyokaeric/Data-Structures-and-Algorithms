using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoublyLinkedList
    {
        private NodeCircly head;
        private NodeCircly tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }

        public void AddLast(int element)
        {
            NodeCircly newest = new NodeCircly(element, null, null);

            if (IsEmpty)
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.previous = tail;
                tail = newest;
            }
            size++;
        }

        public void AddFirst(int element)
        {
            NodeCircly newest = new NodeCircly(element, null, null);

            if (IsEmpty)
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.previous = newest;
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

            NodeCircly newest = new NodeCircly(element, null, null);
            NodeCircly p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            newest.next = p.next;
            p.next.previous = newest;
            p.next = newest;
            newest.previous = p;

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
            head = head.next;
            size--;

            if (IsEmpty) tail = null;
            else head.previous = null;

            return element;
        }

        public int RemoveLast()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            int element = tail.element;
            tail = tail.previous;
            tail.next = null;

            size--;

            return element;
        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position.");
                return -1;
            }

            NodeCircly p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            int element = p.next.element;
            p.next = p.next.next;
            p.next.previous = p;

            size--;

            return element;
        }

        public void Display()
        {
            NodeCircly p = head;

            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
