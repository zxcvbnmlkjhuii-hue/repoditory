using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool _bool = true;
            int att = 5;
            int dex = 6;
            //이렇게 된 if 문구는 한세트이다
            // 그리고 단 하나의 if 만이 실행된다
            //그리고 if 가 실행되지 ㅏㅇㄴㅎ는다면
            //else 실행된다.

            if (dex * 2 < att)
            {
                Console.WriteLine("크리티컬");
            }
            else if (dex < att)
            {
                Console.WriteLine("공격");
            }

            else if (dex > att)
            {
                {
                    Console.WriteLine("회피했다");
                }

                int num = 0;
                switch (num)
                {
                    case 0:
                        Console.WriteLine("0");
                        break;
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");

                        break;
                    default:        //else 같은
                        Console.WriteLine("다 아님");
                        Console.WriteLine(num);
                        break;

                }

            }
        }
    }
}
// 