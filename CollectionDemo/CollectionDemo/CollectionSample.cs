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
            Console.WriteLine("In setDemo DataCollection :\n");
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
            Console.WriteLine("\nIn ListDemo DataCollection :\n");
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
            Console.WriteLine("\nIn DictionaryDemo DataCollection :\n");
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
            Console.WriteLine("\nIn doStackDemo DataCollection :\n");
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
        public static void queueDemo()
        {
            Console.WriteLine("\nIn QueueDemo DataCollection :\n");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Ral");
            queue.Enqueue("Jaishankar");
            Console.WriteLine($"\nHere: {queue.Peek()}\n");
            Console.WriteLine("\nInteracting the queue elements : \n");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine($"\nDequeue element: {dequeue}\n");
            Console.WriteLine("\nInteracting the queue elements after dequeue one element :\n");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}