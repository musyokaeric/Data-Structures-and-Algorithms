namespace LinkedList
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n)
        {
            element = e; next = n;
        }
    }

    // Node for the circly linked list.
    public class NodeCircly
    {
        public int element;
        public NodeCircly next;
        public NodeCircly previous;

        public NodeCircly(int e, NodeCircly n, NodeCircly p)
        {
            element = e; next = n; previous = p;
        }
    }
}
