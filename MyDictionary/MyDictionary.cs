using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] Keys;
        Value[] Values;
        Key[] TempKeys = new Key[0];
        Value[] TempValues = new Value[0];

        public MyDictionary()
        {
            Keys = new Key[0];
            Values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            TempKeys = Keys;
            TempValues = Values;
            Keys = new Key[Keys.Length + 1];
            Values = new Value[Values.Length + 1];
            for (int i = 0; i < TempKeys.Length; i++)
            {
                Keys[i] = TempKeys[i];
                Values[i] = TempValues[i];
            }
            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;
        }

        public void Read()
        {
            for (int i = 0; i < Keys.Length; i++)
            {
                Console.WriteLine("Student = " + Keys[i] + ", Number = " + Values[i]);
            }
        }
    }
}