using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0;
            int a = 0;
            int battaris = 0;
            int num_of_purches = 0;
            double money = 0;
            Console.WriteLine("enter the num of battaris");
            battaris = int.Parse(Console.ReadLine());
            while (battaris >= 10)
            {
                Console.WriteLine("how many battarais do u need");
                a = int.Parse(Console.ReadLine());
                b = a * 2.5;
                Console.WriteLine(b);
                battaris = battaris - a;
                num_of_purches = num_of_purches + 1;
                money = money + b;
            }
            Console.WriteLine("the num of purchess is {0}",num_of_purches);
            Console.WriteLine("the num of money that we got is {0}",money);

        }
    }
}
