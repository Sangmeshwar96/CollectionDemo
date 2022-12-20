using CollectionsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# collection!");
            CollectionSample.setDemo();
            CollectionSample.ListDemo();
            CollectionSample.DictionaryDemo();
            CollectionSample.StackDemo();
        }
    }
}
