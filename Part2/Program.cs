using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        // LIFO  Last IN First Out
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("item1");
            st.Push("item2");
            st.Push("item3");
            Console.WriteLine("peek "+st.Peek());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine("peek " + st.Peek());
            Console.WriteLine(st.Pop());
            
            Console.ReadKey();
        }
    }
}
