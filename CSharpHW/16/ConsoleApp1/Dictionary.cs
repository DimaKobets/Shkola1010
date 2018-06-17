using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dictionary<TKey, TValue>
    {
        private int Count = 0;
        private TKey[] Key = new TKey[0];
        private TValue[] Value = new TValue[0];

        public void Add(TKey newKey, TValue newValue)
        {

            TKey[] newKeyArray = new TKey[Count + 1];
            newKeyArray[0] = newKey;
            for (int i = 0; i < newKeyArray.Length - 1; i++)
            {
                newKeyArray[i + 1] = Key[i];
            }
            Key = newKeyArray;

            TValue[] newValueArray = new TValue[Count + 1];
            newValueArray[0] = newValue;
            for (int i = 0; i < newValueArray.Length - 1; i++)
            {
                newValueArray[i + 1] = Value[i];
            }
            Value = newValueArray;

            Count++;
        }

        public void RemoveByKey(TKey key)
        {
            bool flag = true;
            for (int i = 0; i < Count; i++)
            {
                if (Key[i].Equals(key))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        Key[j] = Key[j + 1];
                    }

                    TKey[] newKeyArray = new TKey[Count - 1];
                    for (int j = 0; j < newKeyArray.Length; j++)
                    {
                        newKeyArray[j] = Key[j];
                    }

                    for (int j = i; j < Count - 1; j++)
                    {
                        Value[j] = Value[j + 1];
                    }

                    TValue[] newValueArray = new TValue[Count - 1];
                    for (int j = 0; j < newValueArray.Length; j++)
                    {
                        newValueArray[j] = Value[j];
                    }

                    Console.WriteLine(key + " was remover");
                    Key = newKeyArray;
                    Value = newValueArray;
                    Count--;
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("There is no such key");
            }
        }

        public bool ConteinsKey(TKey key)
        {
            foreach (var keys in Key)
            {
                if (keys.Equals(key))
                    return true;
            }
            return false;
        }

        public bool ConteinsValue(TValue value)
        {
            foreach (var values in Value)
            {
                if (values.Equals(value))
                    return true;
            }
            return false;
        }

        public void Clear()
        {
            Key = new TKey[0];
            Value = new TValue[0];
            Count = 0;
        }

        public TValue GetByKey(TKey key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Key[i].Equals(key))
                    return Value[i];
            }

            return default(TValue);
        }

        public void Show()
        {
            foreach (var some in Value)
            {
                Console.WriteLine(some);
            }
        }
    }  
}
