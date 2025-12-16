using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WhileEx
{
    enum Place      // 장소 열거형 보기 편하라고 
    {
        start,
        town,
        river,
        plain
    }
    //private  - 내부에서만 접근이 가능하다
    //public   - 외부에서 접근이 가능하다
    //protected - 상속

    public class Monster
    {
        int lv = 3;
        int hp = 30;

        int maxHp = 30;

        public bool Damaged(int att)           // pubilc(어디서나 사용가는) bool (참 거짓 판별) Damaged(int _att)(Damaged 라는 메서드는 int==데이터는 _att을 받겠다 ) 
                                               // **att 값은 호출하는 쪾에서 받아오는 것 att 이라는 값은 호출하는 쪽에서 값은 잠시 가지고 있을 려고 만든 코드
        {


            hp -= att;         // hp = hp - _att;  // hp에서 플레이어의 공격력을 뺀다.

            if (hp > 0)         //  만약 hp가 0보다 크다면
                Console.WriteLine($"허수아비의 체력 : {hp} / {maxHp}");
            Console.ReadLine();                          // 허수아비의 체력을 출력해라.

            {
                if (hp <= 0)                // 만약 hp가 0보다 작거나 같다면
                {
                    Console.WriteLine("허수아비가 죽었습니다");       // 허수아비가 죽었습니다 출력
                    return true;               // true 반환 == 죽었다.
                }
            }
            return false;            // false 반환 == 죽지 않았다.



            ;
        }
    }




    class Player        // 플레이어 클래스
    {
        int lv = 3;
        int hp = 30;
        int att = 3;
        bool _bool = true;
        int maxHp = 30;

        public void StatusTextPrint()   // public(어디서나 사용가능) void(반환값이 없다) StatusTextPrint() (StatusTextPrint 라는 메서드)   
        {
            Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("플레이어의 lv : " + lv);
            //Console.WriteLine("플레이어의 Hp : " + hp + " / " + maxHp);
            //Console.WriteLine("플레이어의 att : " + att);
            Console.WriteLine($"플레이어의 lv : {lv}");
            Console.WriteLine($"플레이어의 Hp : {hp} / {maxHp}");
            Console.WriteLine($"플레이어의 att : {att}");
            Console.WriteLine("-----------------------------------------------");
        }

        public int GetAtt()     // public(어디서나 사용가능) int(정수형 반환) GetAtt() (GetAtt 라는 메서드)
        {
            return att;     // att 반환 == 플레이어의 공격력 반환 == GetAtt() 메서드를 호출하면 플레이어의 공격력을 알 수 있다.

        }



    }


    internal class Program          // 프로그램 클래스
    {

        static void StartTextPrint(Player _player) // static(정적) void(반환값이 없다) StartTextPrint(Player _player) (StartTextPrint 라는 메서드는 Player 클래스의 _player 객체를 받겠다)
        {
            Console.Clear();                    //  콘솔 화면을 지운다.
            _player.StatusTextPrint();          // _player 객체의 StatusTextPrint() 메서드 호출 == 플레이어의 상태 출력
            Console.WriteLine("-----------------------------");
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine("1 마을");
            Console.WriteLine("2 강");
            Console.WriteLine("3 평원");
            Console.WriteLine("-----------------------------");
        }

        static Place StartPoint()       //  static(정적) Place(Place 열거형 반환) StartPoint() (StartPoint 라는 메서드)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();     //  콘솔에서 키 입력을 받는다.

            switch (keyInfo.Key)  //    switch == keyInfo.Key 값에 따라 분기 하겠다
            {
                case ConsoleKey.D1:        //   case == 만약 keyInfo.Key 값이 D1 이라면
                    Console.WriteLine("마을로 향합니다.");
                    Console.ReadKey();
                    return Place.town;      // Place 열거형의 town 값을 반환 == StartPoint() 메서드를 호출하면 Place.town 값을 알 수 있다.

                case ConsoleKey.D2:
                    Console.WriteLine("강으로 향합니다.");
                    Console.ReadKey();
                    return Place.river;

                case ConsoleKey.D3:
                    Console.WriteLine("평원으로 향합니다.");
                    Console.ReadKey();
                    return Place.plain;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadKey();
                    return Place.start;
            }
        }

        static Place Town(Player _player)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusTextPrint();
                Console.WriteLine("-----------------------");
                Console.WriteLine("마을에 왔습니다. 무엇을 하시겠습니까?");
                Console.WriteLine("1 휴식");
                Console.WriteLine("2 트레이닝");
                Console.WriteLine("3 떠나기");
                Console.WriteLine("-----------------------");


                ConsoleKeyInfo keyInfo = Console.ReadKey();  // 콘솔에서 키 입력을 받는다.


                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1://  ConsoleKey 작성후 ctrl + spce 하면 목록 뜸 
                        Console.WriteLine("휴식을 했습니다.");
                        Console.ReadKey();
                        return Place.town;          // Place 열거형의 town 값을 반환 == Town() 메서드를 호출하면 Place.town 값을 알 수 있다.

                    case ConsoleKey.D2:
                        Console.WriteLine("트레이닝을 했습니다.");
                        Console.ReadKey();
                        return Place.town;

                    case ConsoleKey.D3:
                        Console.WriteLine("마을을 떠납니다.");
                        Console.ReadKey();
                        return Place.start;


                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.ReadKey();
                        return Place.town;
                }
            }
        }

        static Place River(Player _player)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusTextPrint();
                Console.WriteLine("-----------------------");
                Console.WriteLine("강에 도착했습니다. 무엇을 하시겠습니까?");
                Console.WriteLine("1 구경");
                Console.WriteLine("2 낚시");
                Console.WriteLine("3 떠나기");
                Console.WriteLine("-----------------------");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("강을 구경 했습니다.");
                        Console.ReadKey();
                        return Place.river;

                    case ConsoleKey.D2:
                        Console.WriteLine("낚시를 했습니다.");
                        Console.ReadKey();
                        return Place.river;

                    case ConsoleKey.D3:
                        Console.WriteLine("강을 떠납니다.");
                        Console.ReadKey();
                        return Place.start;

                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.ReadKey();
                        return Place.river;
                }
            }

        }

        static Place Plain(Player _player)
        {
            Monster mobA = new Monster();  // 몬스터 객체 생성
            while (true)        // 무한 루프
            {
                Console.Clear();
                _player.StatusTextPrint();      // 플레이어 상태 출력
                Console.WriteLine("-----------------------");
                Console.WriteLine("평원에 도착했습니다. 허수아비와 만났습니다.");
                Console.WriteLine("1 싸운다.");
                Console.WriteLine("2 평원에 서있는다.");
                Console.WriteLine("3 떠나기.");
                Console.WriteLine("-----------------------");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("허수아비와 싸운다.");
                        Console.ReadKey();
                        Fight(_player, mobA);           //  Fight 메서드 호출 값은 _player, mobA 에서 받아온다.
                        return Place.plain;

                    case ConsoleKey.D2:
                        Console.WriteLine("그냥 서있습니다.");
                        Console.ReadKey();
                        return Place.plain;

                    case ConsoleKey.D3:
                        Console.WriteLine("평원을 떠납니다.");
                        Console.ReadKey();
                        return Place.start;

                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.ReadKey();
                        return Place.plain;
                }
            }

        }

        static void Fight(Player _player, Monster _mobA)            //  Fight(Player _player, Monster _mobA) (Fight 라는 메서드는 Player 클래스의 _player 객체와 Monster 클래스의 _mobA 객체를 받겠다)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusTextPrint();
                Console.WriteLine("-----------------------");
                Console.WriteLine("허수아비와의 싸움.");
                Console.WriteLine("1 때린다.");
                Console.WriteLine("2 떠난다.");
                Console.WriteLine("-----------------------");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        // 허수아비가 죽었을 때.
                        // 파이트 함수가 끝나야한다.
                        Console.WriteLine("허수아비를 때린다.");
                        Console.ReadKey();
                        bool die = _mobA.Damaged(_player.GetAtt());     //  bool die = _mobA.Damaged          (_player.GetAtt() == 플레이어의 공격력)
                                                                        // 몬스터 객체의 Damaged 메서드에 플레이어의 공격력을 넣어서 호출한 후 반환값을 die 에 저장한다. 


                        if (die)                        // 만약 die 가 true 라면 == 몬스터가 죽었다면
                        {
                            return;                    // Fight 메서드 종료 == 싸움이 끝난다.
                        }
                        break;                    //  싸움이 계속된다.




                    case ConsoleKey.D2:

                        return;

                    default:

                        break;
                }


            }
        }


        static void Main(string[] args)
        {
            Place place = Place.start;          //  장소 열거형 변수 place 생성 후 start 값으로 초기화
            Player playerA = new Player();      // 플레이어 클래스 객체 playerA 생성 

            while (true)
            {

                if (place == Place.start)           //  만약 place 가 start 라면

                {
                    StartTextPrint(playerA);        // StartTextPrint 메서드 호출 값은 playerA 에서 받아온다.
                    place = StartPoint();           //  StartPoint 메서드 호출 후 반환값을 place 에 저장한다.
                }


                switch (place)                      //  switch == place 값에 따라 분기 하겠다
                {
                    case Place.start:
                        break;
                    case Place.town:
                        place = Town(playerA);
                        break;
                    case Place.river:
                        place = River(playerA);
                        break;
                    case Place.plain:
                        place = Plain(playerA);
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }

            }


        }
    }
}
