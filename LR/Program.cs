using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    class Program
    {
        static void Main()
        {
            LR prob = new LR("input.txt");
            prob.Read();
            prob.Right();
            prob.Left();
            prob.Print();

            Console.ReadKey();
        }
    }
}
