namespace Trees
{
    public class BinarySearchTreeRecursive : TreeTraversals
    {
        public BinarySearchTreeRecursive()
        {
            root = null;
        }

        public Node Insert(Node tempRoot, int element)
        {
            if (tempRoot != null)
            {
                if (element < tempRoot.element)
                    tempRoot.left = Insert(tempRoot.left, element);
                else if (element > tempRoot.element)
                    tempRoot.right = Insert(tempRoot.right, element);
            }
            else
            {
                Node n = new Node(element, null, null);
                tempRoot = n;
            }
            return tempRoot;
        }

        public bool Search(Node tempRoot, int key)
        {
            if (tempRoot != null)
            {
                if (key == tempRoot.element) return true;
                else if (key < tempRoot.element)
                    return Search(tempRoot.left, key);
                else if (key > tempRoot.element)
                    return Search(tempRoot.right, key);
            }
            return false;
        }

        public int Count(Node tempRoot)
        {
            if (tempRoot != null)
            {
                int x = Count(tempRoot.left);
                int y = Count(tempRoot.right);
                return x + y + 1;
            }
            return 0;
        }

        public int Height(Node tempRoot)
        {
            if (tempRoot != null)
            {
                int x = Height(tempRoot.left);
                int y = Height(tempRoot.right);

                if (x > y) return x + 1;
                else return y + 1;
            }
            return 0;
        }
    }
}
