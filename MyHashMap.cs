using System;
using System.Collections.Generic;

// Custom HashMap Implementation
class MyHashMap<K, V>
{
    private class HashNode
    {
        public K Key;
        public V Value;
        public HashNode Next;

        public HashNode(K key, V value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private int capacity;
    private List<HashNode> buckets;

    public MyHashMap(int size = 10)
    {
        capacity = size;
        buckets = new List<HashNode>(new HashNode[capacity]);
    }

    private int GetBucketIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % capacity;
    }

    // Insert or Update key-value pair
    public void Put(K key, V value)
    {
        int index = GetBucketIndex(key);
        HashNode head = buckets[index];

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                head.Value = value; // Update existing key
                return;
            }
            head = head.Next;
        }

        // Insert new node at the head
        HashNode newNode = new HashNode(key, value);
        newNode.Next = buckets[index];
        buckets[index] = newNode;
    }

    // Retrieve value by key
    public V Get(K key)
    {
        int index = GetBucketIndex(key);
        HashNode head = buckets[index];

        while (head != null)
        {
            if (head.Key.Equals(key))
                return head.Value;
            head = head.Next;
        }

        throw new KeyNotFoundException("Key not found.");
    }

    // Remove key-value pair
    public bool Remove(K key)
    {
        int index = GetBucketIndex(key);
        HashNode head = buckets[index];
        HashNode prev = null;

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                if (prev != null)
                    prev.Next = head.Next;
                else
                    buckets[index] = head.Next;

                return true;
            }
            prev = head;
            head = head.Next;
        }

        return false; // Key not found
    }

    // Display HashMap contents
    public void Display()
    {
        for (int i = 0; i < capacity; i++)
        {
            Console.Write("Bucket " + i + ": ");
            HashNode head = buckets[i];

            while (head != null)
            {
                Console.Write(String.Format("[{0}: {1}] -> ", head.Key, head.Value));
                head = head.Next;
            }

            Console.WriteLine("NULL");
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        MyHashMap<int, string> hashMap = new MyHashMap<int, string>();

        hashMap.Put(1, "One");
        hashMap.Put(2, "Two");
        hashMap.Put(3, "Three");
        hashMap.Put(12, "Twelve"); // Collision with index 2

        Console.WriteLine("HashMap after insertions:");
        hashMap.Display();

        Console.WriteLine("\nGet key 2: " + hashMap.Get(2));

        hashMap.Remove(2);
        Console.WriteLine("\nHashMap after removing key 2:");
        hashMap.Display();

        try
        {
            Console.WriteLine("\nGet key 2: " + hashMap.Get(2));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
