using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class HashChain
    {
        int hashTableSize;
        SinglyLinkedList[] hashTable;

        public HashChain()
        {
            hashTableSize = 10;
            hashTable = new SinglyLinkedList[hashTableSize];
            for (int i = 0; i < hashTableSize; i++)
                hashTable[i] = new SinglyLinkedList();
        }

        public int HashCode(int key) => key % hashTableSize;

        public void Insert(int element)
        {
            int i = HashCode(element);
            hashTable[i].AddSorted(element);
        }

        public bool Search(int key)
        {
            int i = HashCode(key);
            return hashTable[i].Search(key) != -1;
        }

        public void Display()
        {
            for (int i = 0; i < hashTableSize; i++ )
            {
                Console.Write("[" + i + "]");
                hashTable[i].Display();
            }
            Console.WriteLine();
        }
    }
}
