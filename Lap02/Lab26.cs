using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap02
{
    internal class Lab26
    {
        public void InTamGiac()
        {
            int n = 10;
            int x = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    x++;
                    Console.Write(x % 10);
                }

                for (int j = i - 1; j >= 1; j--)
                {
                    x--;
                    Console.Write(x % 10);
                }

                Console.WriteLine();
            }
        }
    }
}
