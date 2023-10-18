namespace Trees
{
    public class QNode
    {
        public object element;
        public QNode next;

        public QNode(object e, QNode n)
        {
            element = e;
            next = n;
        }
    }
}
