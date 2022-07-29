using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hash1 = new HashSet<int>();
            hash1.Add(10);
            hash1.Add(20);
            hash1.Add(30);
        
       


            HashSet<int> hash2 = new HashSet<int>();
            hash2.Add(40);
            hash2.Add(50);
            hash2.Add(60);
            hash2.Add(20);


            var u= hash1.Union(hash2);
            var e= hash1.Except(hash2);
            var i = hash1.Intersect(hash2);

            foreach (var item in i)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
