using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i1 = a; i1 <= b; i1++)
            {
                for (int i2 = a; i2 <= b; i2++)
                {
                    for (int i3 = a; i3 <= b; i3++)
                    {
                        for (int i4 = a; i4 <= b; i4++)
                        {
                            for (int i5 = a; i5 <= b; i5++)
                            {
                                if (i1 < i2 && i2 < i3 && i3 < i4 && i4 < i5)
                                {

                                    Console.WriteLine($"{i1} {i2} {i3} {i4} {i5}");
                                 }
                         //       else if (Math.Abs(a - b) < 5)
                         //       {
                         //           Console.WriteLine("No");
                         //           break;
                         //       }
                              
                            }
                        }
                    }
                }
            }
        }
    }
}
