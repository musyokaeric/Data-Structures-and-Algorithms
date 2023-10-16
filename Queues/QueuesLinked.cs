namespace Queues
{
    public class QueuesLinked
    {
        Node front;
        Node rear;
        int size;

        public QueuesLinked()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }

        public void Enqueue(int value)
        {
            Node newest = new Node(value, null);
            if (IsEmpty)
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }
            rear = newest;
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty/underflow.");
                return -1;
            }
            int value = front.element;
            front = front.next;
            size--;

            if (IsEmpty)
            {
                rear = null;
            }
            return value;
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
