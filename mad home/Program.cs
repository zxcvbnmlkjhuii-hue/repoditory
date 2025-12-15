using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mad_home
{
    internal class Program
    {
        // 매개 변수
        static int TestFunc(int a)
        {
            a = 500;
            return 30;
        }
        static void Main(string[] args)
        {
            // 지역 변수 
            int i = 10;
            i = TestFunc(i);

            Console.WriteLine(i);

            Console.ReadLine();

        }
    }
}
