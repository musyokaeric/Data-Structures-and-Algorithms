using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TreeTraversals
    {
        public Node root;

        public void InOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                InOrder(tempRoot.left);
                Console.Write(tempRoot.element + " ");
                InOrder(tempRoot.right);
            }
        }

        public void PreOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                Console.Write(tempRoot.element + " ");
                PreOrder(tempRoot.left);
                PreOrder(tempRoot.right);
            }
        }

        public void PostOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                PostOrder(tempRoot.left);
                PostOrder(tempRoot.right);
                Console.Write(tempRoot.element + " ");
            }
        }

        public void LevelOrder(Node tempRoot)
        {
            QueuesLinked q = new QueuesLinked();
            Node t = root;
            Console.Write(t.element + " ");
            q.Enqueue(t);
            while (!q.IsEmpty)
            {
                t = (Node)q.Dequeue();
                if (t.left != null)
                {
                    Console.Write(t.left.element + " ");
                    q.Enqueue(t.left);
                }
                if (t.right != null)
                {
                    Console.Write(t.right.element + " ");
                    q.Enqueue(t.right);
                }
            }
        }
    }
}
