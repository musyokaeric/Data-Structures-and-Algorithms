using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearchTreeIterative : TreeTraversals
    {
        public BinarySearchTreeIterative()
        {
            root = null;
        }

        public void Insert(Node tempRoot, int element)
        {
            Node temp = null;
            while (tempRoot != null)
            {
                temp = tempRoot;
                if (element == tempRoot.element)
                    return;
                else if (element < tempRoot.element)
                    tempRoot = tempRoot.left;
                else if (element > tempRoot.element)
                    tempRoot = tempRoot.right;
            }
            Node n = new Node(element, null, null);
            if (root != null)
            {
                if (element < temp.element)
                    temp.left = n;
                else temp.right = n;
            }
            else root = n;
        }

        public bool Search(int key)
        {
            Node tempRoot = root;
            while (tempRoot != null)
            {
                if (tempRoot.element == key) return true;
                else if (key < tempRoot.element)
                    tempRoot = tempRoot.left;
                else if (key > tempRoot.element)
                    tempRoot = tempRoot.right;
            }
            return false;
        }

        public bool Delete(int element)
        {
            Node p = root;
            Node pp = null;
            while (p != null && p.element != element)
            {
                pp = p;
                if (element < p.element)
                    p = p.left;
                else p = p.right;
            }
            if (p == null)
                return false;

            // Removing a node that has both the left and right subtree
            if (p.left != null && p.right != null) 
            {
                Node s = p.left;
                Node ps = p;
                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                p.element = s.element;
                p = s;
                pp = ps;
            }

            // Removing a node that has either left or right subtree
            Node c = null;
            if (p.left != null)
                c = p.left;
            else c = p.right;

            if (p == root) root = null;
            else
            {
                if (p == pp.left) pp.left = c;
                else pp.right = c;
            }
            return true;
        }
    }
}
