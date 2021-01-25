using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> students = new MyDictionary<string, string>();
            students.Add("Ceren Susuz", "1234564");
            students.Add("Asya Susuz", "12345648");
            students.Read();

        }
    }
}