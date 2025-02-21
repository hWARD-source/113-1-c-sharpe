using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Rndgen = new Random();
            int dn, p, nd, i, r, q;
            int[]N = new int[10];
            Console.Write("輸入時進位數字dn(>0): ");
            dn = int .Parse(Console.ReadLine());
            Console.Write("採用幾進位p(0~9): ");
            p = int .Parse(Console.ReadLine());
            nd = -1; q = dn;
            while (q != 0)
            {
                r = q % p;
                N[++nd] = r;
                q = q / p;
                Console.Write($"{N[nd]}\n");
            }
            nd++;//因為陣列索引從0開始所以要+1
            Console.Write($"共幾個數字nd = {nd}\n", nd);
            for (i = nd  - 1; i >= 0; i--)
                Console.Write($"{N[i]}");

            Console.Write("/n程式即將結束,請按任意一鍵結束!  ");
            Console.Read();
        }
    }
}
