using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class CollectionSample
    {
        public static void setDemo()
        {
            Console.WriteLine("In setDemo Data :\n");
            HashSet<string> set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add(null);
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void ListDemo()
        {
            Console.WriteLine("\nIn ListDemo Data :\n");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(list[1]);
        }
        public static void DictionaryDemo()
        {
            Console.WriteLine("\nIn DictionaryDemo Data :\n");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine($"Access value using key(key=100): {dictionary[100]}");
            Console.WriteLine("\nInteracting Dictionary\n");
            foreach (var element in dictionary)
            {
                Console.WriteLine($"keys ={element.Key} & value ={element.Value}");
            }
            Dictionary<int, string>.Enumerator obj = dictionary.GetEnumerator();
            while (obj.MoveNext())
            {
                Console.WriteLine("\n"+obj.Current);
            }
        }
        public static void StackDemo()
        {
            Console.WriteLine("\nIn doStackDemo Data :\n");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garina");
            stack.Push("Ayush");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"\nPoped element: {pop}");
        }

    }
}