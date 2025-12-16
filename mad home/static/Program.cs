using @static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static // static 전역 변수 전체에서 사용가능한 변수 하나의 값을 공유 
{
    public class FishBreadTool // 붕어빵 틀
    {
        public static int bell;
        //클레스 자체에서 사용하는 메서드
        public static void BellFunc()  //static class안에서 작동하도록 만들어짐
        {

        }

        int taste; // 붕어빵
        //만들어진 객체가 사용 할 수 있는 매서드
        public void FuncTest()
        {

            taste = 10;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                FishBreadTool fishA = new FishBreadTool();
                fishA.FuncTest();
                fishA.taste = 20;
                FishBreadTool.BellFunc();  // 


            }
        }
    }
}
