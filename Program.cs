using System;
using System.Collections.Generic;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> mydictionary = new MyDictionary<int, string>();
            mydictionary.Add(1, "Kaan");
            mydictionary.Add(2, "Ali");
            mydictionary.List();
        }
    }
    class MyDictionary<K, V>
    {
        K[] keyArray;
        K[] tempkeyArray;
        V[] valueArray;
        V[] tempvalueArray;
        public MyDictionary()
        {
            keyArray = new K[0];
            valueArray = new V[0];
        }
        public void Add(K keyitem, V valueitem)
        {
            tempkeyArray = keyArray;
            tempvalueArray = valueArray;


            keyArray = new K[keyArray.Length + 1];
            for (int i = 0; i < tempkeyArray.Length; i++)
            {
                keyArray[i] = tempkeyArray[i];
            }
            keyArray[keyArray.Length - 1] = keyitem;


            valueArray = new V[valueArray.Length + 1];
            for (int i = 0; i < tempvalueArray.Length; i++)
            {
                valueArray[i] = tempvalueArray[i];
            }
            valueArray[valueArray.Length - 1] = valueitem;

        }

        public void List()
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                Console.WriteLine(keyArray[i] + " key --> " + valueArray[i]+" value");
            }
        }

    }
}
