using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Teststru  // 값으 구할때 많이 사용 안에 클레스를 넣어 사용 할 수 도 있지만 지양한다
{
    
    

    public struct MyStruct
    {
        public int testA;
        private int testB;

        public void TestFunc()
        {
            Console.WriteLine("호출시 출력");
        }
    }
    public class Monster  // 기능을 구현 할 때 주로 사용
    {
        public int testA;
        private int testB;

        public void TestFunc()
        {
            Console.WriteLine("호출시 출력");
        }
    }
    internal class Program
    {

        static int TestFunc(int a) 
        {
            a = 400;  // i 400으로 바꾼다 하지만 값만 받은 거기 때문에 함수 종료시 사라진다 고로 Main의 값은 변하지 않는다\
            return a; // a의 값을 돌려준다
        }
        static void Main(string[] args)
        {
            int i = 10; // i ==10 입력

            //TestFunc(i); // 함수 호출 i 값을 받겠다
            i = TestFunc(i); // return을 해서 값을 다시 받아 왔기 때문에 값은 400이 된다
            Console.WriteLine("i : " + i);
                Monster monster = new Monster();
            Monster monsterA = new Monster();
            MyStruct Mystruct = new MyStruct();
            MyStruct MystructA = new MyStruct();
            monster.testA = 200;    // 레퍼런스 타임 : 객체 자체를 줘서 값이 똑같아짐
            monsterA = monster;
            monsterA.testA = 22200;

            Console.WriteLine(" monster.testA : " + monster.testA);
            Console.WriteLine(" monster.testA : " + monsterA.testA);

            Mystruct.testA = 200;  // 부도체 : 값이 전달 될때 자신의 값을 복제해서 보내주어 서로 다른 값으 가짐
            MystructA = Mystruct;
            MystructA.testA = 700;
            Console.WriteLine(" MystructA.testA : " + Mystruct.testA);
            Console.WriteLine(" MystructA.testA : " + MystructA.testA);
        }
    }
}
