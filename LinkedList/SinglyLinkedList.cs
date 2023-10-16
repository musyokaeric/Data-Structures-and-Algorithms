using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SinglyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }

        public void AddFirst(int element)
        {
            Node newest = new Node(element, null);
            if (IsEmpty)
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void AddLast(int element)
        {
            Node newest = new Node(element, null);

            if (IsEmpty) head = newest;
            else tail.next = newest;

            tail = newest;
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

        public void AddSorted(int e)
        {
            Node newest = new Node(e, null);

            if (IsEmpty)
            {
                head = newest;
                tail = newest;
            }
            else
            {
                Node p = head;
                Node q = head;

                while (p != null && p.element < e)
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
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
            tail.next = null;
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

        public int Search(int key)
        {
            Node p = head;
            int index = 0;

            while (p != null)
            {
                if (p.element == key)
                    return index;
                p = p.next;
                index++;
            }
            return -1;
        }

        public void Display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
