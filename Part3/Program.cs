using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        //FIFO  First In First Out
        static void Main(string[] args)
        {
            Queue<int> ls = new Queue<int>();
            ls.Enqueue(10);
            ls.Enqueue(20);
            ls.Enqueue(30);
            Console.WriteLine("peek " + ls.Peek());
            Console.WriteLine(ls.Dequeue());
            Console.WriteLine(ls.Dequeue());
            Console.WriteLine("peek " + ls.Peek());
            Console.WriteLine(ls.Dequeue());

            Console.ReadKey();

        }
    }
}
