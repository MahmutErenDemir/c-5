using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__5
{
    internal class Program
    {
        public void fo(out int x)
        {
            int temp = 5;
            x = temp;
        }
        public void ca(out int sum)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            sum= a * b;

        }


        static void Main(string[] args)
        {
            // int b ;
            // Console.WriteLine("a"+a);

            // Program n = new Program();
            Program m = new Program();
            //   n.fo(out b);
            int o;
            m.ca(out o);
            Console.WriteLine("a" + o);
        }


    }
}
