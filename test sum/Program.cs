using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기");
            Console.WriteLine("첫번째 숫자를 입력해 주세요.");
            string strA = Console.ReadLine();

            Console.WriteLine("두번쨰 숫자를 입력해 주세요.");
            string strB = Console.ReadLine();


            
            double a = Convert.ToDouble(strA);
            double b = Convert.ToDouble(strB);
            int i = (int)a;
            int j = (int)b;

            Console.WriteLine(i + j);
            Console.WriteLine(i - j);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(i * j);
            Console.WriteLine(i / j);
            Console.WriteLine(i + j);
            Console.WriteLine(i - j);

            

            string sss = i.ToString();

            Console.WriteLine("다시 문자로 바꿨습니다");
            Console.WriteLine(sss);
            Console.ReadLine();

            //string str = Console.ReadLine();
            //int a = 10;
            //long b = 20;

            //int result = a + (int)b;

            //a = 1;
            //string Test = "55";

            //a = 1 + 1;

            //a = Convert.ToInt32(Test);

            //Test = int.Parse


            //Console.WriteLine(a);
            //    Console.WriteLine(Test);
            //Console.ReadLine();
        }
    }
}
