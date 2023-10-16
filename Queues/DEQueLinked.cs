using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class DEQueLinked
    {
        private Node front;
        private Node rear;
        private int size;

        public DEQueLinked()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }
        public int First { get => IsEmpty ? -1 : front.element; }
        public int Last { get => IsEmpty ? -1 : rear.element; }

        public void AddFirst(int element)
        {
            Node newest = new Node(element, null);
            if (IsEmpty)
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front;
                front = newest;
            }
            size++;
        }

        public void AddLast(int element)
        {
            Node newest = new Node(element, null);

            if (IsEmpty) front = newest;
            else rear.next = newest;

            rear = newest;
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            int element = front.element;
            front = front.next;
            size--;

            if (IsEmpty) rear = null;
            return element;
        }

        public int RemoveLast()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            Node p = front;
            int i = 1;

            while (i <= size - 1)
            {
                p = p.next;
                i++;
            }

            int element = p.element;
            rear = p;
            p = p.next;
            rear.next = null;
            size--;

            return element;
        }

        public int Search(int key)
        {
            Node p = front;
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
            Node p = front;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
