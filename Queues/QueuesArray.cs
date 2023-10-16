using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class QueuesArray
    {
        int[] data;
        int front;
        int rear;
        int size;

        public QueuesArray(int length)
        {
            data = new int[length];
            front = 0;
            rear = 0;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }
        public bool IsFull { get => size == data.Length; }

        public void Enqueue(int value)
        {
            if (IsFull)
            {
                Console.WriteLine("Queue is full.");
                return;
            }
            data[rear] = value;
            rear++;
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty.");
                return -1;
            }
            int element = data[front];
            front++;
            size--;
            return element;
        }

        public void Display()
        {
            for (int i = front; i < rear; i++)
            {
                Console.Write(data[i]+" - ");
            }
            Console.WriteLine();
        }
    }
}
