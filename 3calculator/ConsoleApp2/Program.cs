using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> arr = new List<object>();
            char a = 'a';
            int b = 32;
            arr.Add(a);
            arr.Add(b);
            Console.WriteLine($"{arr[0].GetType()}\n{arr[1].GetType()}");


        }
    }
}
