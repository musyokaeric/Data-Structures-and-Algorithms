namespace Trees
{
    public class QueuesLinked
    {
        QNode front;
        QNode rear;
        int size;

        public QueuesLinked()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public int Length { get => size; }
        public bool IsEmpty { get => size == 0; }

        public void Enqueue(object value)
        {
            QNode newest = new QNode(value, null);
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

        public object Dequeue()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty/underflow.");
                return -1;
            }
            object value = front.element;
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
            QNode p = front;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
