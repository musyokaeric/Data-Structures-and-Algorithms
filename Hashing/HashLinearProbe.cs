using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class HashLinearProbe
    {
        int hashTableSize;
        int[] hashTable;

        public HashLinearProbe()
        {
            hashTableSize = 10;
            hashTable = new int[hashTableSize];
        }

        public int HashCode(int key) => key % hashTableSize;

        public int LinearProbe(int element)
        {
            int i = HashCode(element);
            int j = 0;
            while (hashTable[(i + j) % hashTableSize] != 0)
            {
                j++;
            }
            return (i + j) % hashTableSize;
        }

        public void Insert(int element)
        {
            int i = HashCode(element);
            if (hashTable[i] == 0)
            {
                hashTable[i] = element;
            }
            else
            {
                i = LinearProbe(element);
                hashTable[i] = element;
            }
        }

        public bool Search(int key)
        {
            int i = HashCode(key);
            int j = 0;
            while (hashTable[(i + j) % hashTableSize] != key)
            {
                if (hashTable[(i + j) % hashTableSize] == 0)
                    return false;
                j++;
            }
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < hashTableSize; i++)
                Console.Write(hashTable[i] + " - ");
            Console.WriteLine();
        }
    }
}
