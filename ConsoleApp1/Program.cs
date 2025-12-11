using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Monster
    {
        public int lv = 1;
        public int hp = 1;
        public int att = 1;

        public void Damage(int _damage)
        {

        }

    }
    internal class Program
    {
        static void TextPrint(int temp)
        {
            Console.WriteLine("gkgkgk");
        }
        static void Main(string[] args)
        {
            Monster monA = new Monster();
            Monster monB = new Monster();
            Monster monC = new Monster();
            Console.WriteLine();

            monA.hp = monA.hp - 5;
            Console.WriteLine(monA.hp);
            Console.ReadLine();

        }
        static void TextPrint()
        {
            Console.WriteLine("안녕");

        }

    }
}
