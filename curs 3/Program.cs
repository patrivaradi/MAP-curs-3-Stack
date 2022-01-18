using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack tempRPN = new Stack();
            string s="5 1 + 3 * 2 5 * 3 4 2 + * - +";
            //stack
            string [] local = s.Split(' ');
            foreach (string st in local)
            {
                if (st[0] >= '0' && st[0] <= '9')
                    tempRPN.Push(int.Parse(st));
                else
                {
                    int t1 = tempRPN.Pop();
                    int t2 = tempRPN.Pop();
                    switch(st[0])
                    {
                        case '+':tempRPN.Push(t2 + t1);break;
                        case '-': tempRPN.Push(t2 - t1); break;
                        case '*': tempRPN.Push(t2 * t1); break;
                        case '/': tempRPN.Push(t2 / t1); break;
                    }
                }
            }
            tempRPN.view();
            Console.ReadKey();

        }
    }
}
