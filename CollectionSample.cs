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
            Console.WriteLine(list[1
                ]);
        }

    }
}
