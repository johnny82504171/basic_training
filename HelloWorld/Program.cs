using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {            
            if (args.Length == 0)
            {
                Console.WriteLine("HelloWorld");
                return;
            }

            Console.WriteLine($"args count : {args.Length}");
            
            for (int i = 0; i <= args.Length - 1; i++)
            {
                Console.WriteLine($"args[{i}] info : {args[i]}");
            }
        }
    }
}
