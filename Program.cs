using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensarEj7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100, j=0;

            for(int i=2; (i <= n); i++)
            {
                j = 0;
                for (int k = 1; (k <= n); k++)
                {
                    if ((i % k) == 0)
                    {
                        j++;
                        if (i == k && j == 2)
                        {
                            Console.WriteLine(i.ToString());
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
