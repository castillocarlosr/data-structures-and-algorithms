using System;
using System.Collections.Generic;
using HashTables.Classes;
using System.Text;

namespace HashTables.Classes
{
    public class Hashtables
    {
        //private Hashtable hashtable = new Hashtable();

        /// <summary>
        /// New Hash Table with 1024 buckets
        /// </summary>
        public LinkedList[] Bucket = new LinkedList[1024];
        //public Node[] bucket = new Node[1024];

        public Hashtables()
        {
            //empy constructor
        }

        public int GetHash(string key)
        {
            byte[] bytesASCII = Encoding.ASCII.GetBytes(key);
            int hashValue = 0;
            for (int i = 0; i < bytesASCII.Length; i++)
            {
                hashValue += bytesASCII[i];
            }
            hashValue = (hashValue * 599) % Bucket.Length;
            return hashValue;
        }

        /// <summary>
        /// Adds key/value to the hash table
        /// </summary>
        /// <param name="key">key being hashed</param>
        /// <param name="value">the value asscoiated to the key</param>
        public void Add(string key, object value)
        {
            int index = GetHash(key);

            Node node = new Node(key, value);
            if(Bucket[index] == null)
            {
                LinkedList list = new LinkedList(node);
                Bucket[index] = list;
            }
            else
            {
                Bucket[index].Append(node);
            }
            /*
            else
            {
                Node current = bucket[index];
                while(current != null)
                {
                    current = current.Next;
                    //for collisions
                    if(current.Key.ToString() == key)
                    {
                        current.Value = value;
                        return;
                    }
                }
                current.Next = node;
            }*/
        }

        /// <summary>
        /// To return the value when given a key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>value</returns>
        public object GetValue(string key)
        {
            int index = GetHash(key);

            if (Bucket[index] == null)
            {
                return null;
            }
            else if(Bucket[index].Head.Key.ToString() == key)
            {
                return Bucket[index].Head.Value;
            }
            else if(Bucket[index].Head.Next != null)
            {
                while(Bucket[index].Current != null)
                {
                    if(Bucket[index].Current.Key.ToString() == key)
                    {
                        return Bucket[index].Current.Value;
                    }
                    Bucket[index].Current = Bucket[index].Current.Next;
                }
            }
            //else
            //{
                return null;
            //}
        }

        public bool Contains(string key)
        {
            int index = GetHash(key);

            if (Bucket[index] == null)
            {
                return false;
            }
            else if (Bucket[index].Head.Key.ToString() == key)
            {
                return true;
            }
            else if (Bucket[index].Head.Next != null)
            {
                while (Bucket[index].Current != null)
                {
                    if (Bucket[index].Current.Key.ToString() == key)
                    {
                        return true;
                    }
                    Bucket[index].Current = Bucket[index].Current.Next;
                }
            }
            return false;
        }
    }
}
