using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Testable t;
            t = new Testable();
            t.pushI(1);
            if (1 != t.popI())
                Console.Write("MISMATCH");
            t.pushD(1.1);
            if(1.1 != t.popD())
                Console.Write("MISMATCH");
            t.pushS("String");
            if("String" != t.popS())
                Console.Write("MISMATCH");

        }
    }
}
