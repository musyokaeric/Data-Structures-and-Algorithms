using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class StacksArray
    {
        int[] data;
        int top;

        public StacksArray(int length)
        {
            data = new int[length];
            top = 0;
        }

        public int Length { get => top; }
        public bool IsEmpty { get => top == 0; }
        public bool IsFull { get => top == data.Length; }

        public void Push(int value)
        {
            if (IsFull)
            {
                Console.WriteLine("Stack is full.");
                return;
            }
            data[top] = value;
            top++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty/underflow.");
                return -1;
            }
            int value = data[top - 1];
            top--;
            return value;
        }

        public int Peek() => IsEmpty ? -1 : data[top - 1];

        public void Display()
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write(data[i]+" - ");
            }
            Console.WriteLine();
        }
    }
}
