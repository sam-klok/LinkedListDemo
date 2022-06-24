using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2, 3, 8, 15, 19, 20 };
            var l = new LinkedList(a);
            l.Print();

            Console.WriteLine($"l[0] - {l[0]}");
            Console.WriteLine($"l[1] - {l[1]}");
            Console.WriteLine($"l[5] - {l[5]}");

            Console.WriteLine();
            Console.WriteLine("Deliting 3");
            l.Delete(3);
            l.Print();

            Console.WriteLine();
            Console.WriteLine("Add first 44");
            l.AddFirst(44);
            l.Print();

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
