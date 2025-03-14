using System;
using System.Collections.Generic;

class HashMap<TKey, TValue>
{
    private const int InitialSize = 10;
    private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;

    public HashMap()
    {
        buckets = new LinkedList<KeyValuePair<TKey, TValue>>[InitialSize];
        for (int i = 0; i < InitialSize; i++)
        {
            buckets[i] = new LinkedList<KeyValuePair<TKey, TValue>>();
        }
    }

    private int GetBucketIndex(TKey key)
    {
        int hashCode = key.GetHashCode();
        return Math.Abs(hashCode % buckets.Length);
    }

    public void Insert(TKey key, TValue value)
    {
        int bucketIndex = GetBucketIndex(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = buckets[bucketIndex];

        foreach (var kvp in bucket)
        {
            if (kvp.Key.Equals(key))
            {
                throw new ArgumentException("Key already exists in the hash map.");
            }
        }

        bucket.AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

    public void Delete(TKey key)
    {
        int bucketIndex = GetBucketIndex(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = buckets[bucketIndex];

        KeyValuePair<TKey, TValue> foundKvp = default(KeyValuePair<TKey, TValue>);
        bool found = false;
        
        foreach (var kvp in bucket)
        {
            if (kvp.Key.Equals(key))
            {
                foundKvp = kvp;
                found = true;
                break;
            }
        }

        if (found)
        {
            bucket.Remove(foundKvp);
        }
        else
        {
            throw new KeyNotFoundException("Key not found in the hash map.");
        }
    }

    public TValue Retrieve(TKey key)
    {
        int bucketIndex = GetBucketIndex(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = buckets[bucketIndex];

        foreach (var kvp in bucket)
        {
            if (kvp.Key.Equals(key))
            {
                return kvp.Value;
            }
        }

        throw new KeyNotFoundException("Key not found in the hash map.");
    }

    public void Display()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            Console.Write("Bucket " + i + ": ");
            foreach (var kvp in buckets[i])
            {
                Console.Write("(" + kvp.Key + ", " + kvp.Value + ") ");
            }
            Console.WriteLine();
        }
    }
}

class CustomHashMap
{
    static void Main()
    {
        HashMap<string, int> hashMap = new HashMap<string, int>();

        hashMap.Insert("apple", 1);
        hashMap.Insert("banana", 2);
        hashMap.Insert("cherry", 3);

        hashMap.Display();

        Console.WriteLine("Retrieve 'banana': " + hashMap.Retrieve("banana"));

        hashMap.Delete("banana");

        hashMap.Display();

        try
        {
            Console.WriteLine("Retrieve 'banana': " + hashMap.Retrieve("banana"));
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}