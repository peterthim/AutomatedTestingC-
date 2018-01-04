using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToTest
{
    public class Testable
    {
        Stack<double> d;
        Stack<int> i;
        Stack<string> s;


       public Testable()
        {
            d = new Stack<double>();
            i = new Stack<int>();
            s = new Stack<string>();
        }

        public void pushD(double dd)
        {
            d.Push(dd);
        }
        public double popD()
        {
            //forgot to checko for count<0 
            return d.Pop();
            
        }
        public void pushI(int ii)
        {
            i.Push(ii);
        }
        public int popI()
        {
            if (i.Count > 0)
                return i.Pop();
            else
                return -1;
        }
        public void pushS(string ss)
        {
            s.Push(ss);
        }
        public string popS()
        {
            if (s.Count > 0)
                return s.Pop();

            return "";
        }
    }
}
