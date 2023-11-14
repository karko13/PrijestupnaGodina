using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitVjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Startgod = 1900, endGod = 2100;
            for (int i = Startgod; i <= endGod; i++)
            {
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}