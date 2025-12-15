using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2512135
{

    enum Place
    {
        Forest,
        Guild,
        Inn,
        start,
        fight

    }
    class Player
    {

        private string namem = "주인공";
        private int lv = 1;
        private int Maxhp = 30;
        private int hp = 30;
        private int mp = 30;
        private int att;
        private int dex;


        public Player()
        {
            att = lv * 2;
            dex = lv * 2;
        }
        public void CreatePlayer()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("플레이어 이름:" + namem);
            Console.WriteLine("플레이어 레벨:" + lv);
            Console.WriteLine("플레이어 체력:" + Maxhp + "/" + hp);
            Console.WriteLine("플레이어 공격력:" + att);
            Console.WriteLine("--------------------------------------");

        }
        public bool Damage(int att)
        {
            if (dex >= att)
            {
                Console.WriteLine("공격을 회피했다.");
                return false;
            }
            hp -= att - dex;   // h
            if (hp <= 0)
            {
                return true;
            }
            return false;
        }
        public int GetDamage()
        {
            return att;
        }

    }

    class Monster
    {

        private string namem = "Slime";
        private int lv = 3;
        private int Maxhp = 30;
        private int hp = 30;
        private int mp = 30;
        private int att;

        public Monster()
        {
            att = lv * 1;
        }
        public void CreateMonstor()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("슬라임 이름:" + namem);
            Console.WriteLine("슬라임 레벨:" + lv);
            Console.WriteLine("슬라임 체력:" + Maxhp + "/" + hp);
            Console.WriteLine("슬라임 공격력:" + att);
            Console.WriteLine("--------------------------------------");

        }
        public bool Damage(int att)
        {
            hp -= att;
            if (hp <= 0)
            {
                return true;
            }
            return false;
        }
        public int GetDamage()
        {
            return att;
        }


    }
    internal class Program
    {


        static void Main(string[] args)
        {

            Place place = Place.start;
            Player player = new Player();
            Monster monsterA = new Monster();


            if (place == Place.start)
            {
                place = start(player);
            }

            while (true)
            {
                switch (place)

                {
                    case Place.Forest:
                        place = Forest(player);
                        break;
                    case Place.Guild:
                        // Guild(player);
                        break;
                    case Place.Inn:
                        // Inn(player);
                        break;
                    case Place.start:
                        place = start(player);
                        break;
                    case Place.fight:
                        place = fight(player, monsterA);
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();

        }


        static Place start(Player player)
        {
            Console.Clear();
            player.CreatePlayer();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("     무엇을 하겠습니까");
            Console.WriteLine("     1.숲을 조사 한다 ");
            Console.WriteLine("     2.길드에 가서 퀘스트를 받는다");
            Console.WriteLine("     3.여관에서 휴식을 취한다");
            Console.WriteLine("--------------------------------------");


            ConsoleKeyInfo keyInfo = Console.ReadKey();


            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("숲을 조사합니다.");
                    return Place.Forest;

                case ConsoleKey.D2:
                    Console.WriteLine("길드에 가서 퀘스트를 받습니다.");
                    return Place.start;
                case ConsoleKey.D3:
                    Console.WriteLine("여관에서 휴식을 취합니다.");
                    return Place.start;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    return Place.start;

            }



        }
        static Place Forest(Player player)
        {
            Place place = Place.start;
            Console.Clear();
            player.CreatePlayer();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("     숲에 들어왔습니다 슬라임을 만났다.");
            Console.WriteLine("     1.슬라임과 싸운다 ");
            Console.WriteLine("     2.무시하고 주변을 둘러 본다");
            Console.WriteLine("     3.떠난다");
            Console.WriteLine("--------------------------------------");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("슬라임이 적대한다");
                    return Place.fight;

                case ConsoleKey.D2:
                    Console.WriteLine("포션을 찾았다.");
                    return Place.start;

                case ConsoleKey.D3:
                    Console.WriteLine("떠난다.");
                    return Place.start;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    return Place.Forest;


            }

        }
        static Place fight(Player player, Monster monsterA)
        {
            {
                while (true)
                {
                    Console.Clear();
                    player.CreatePlayer();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("     슬라임과 적대한다.");
                    Console.WriteLine("     1.공격한다 ");
                    Console.WriteLine("     2.방어한다");
                    Console.WriteLine("     3.떠난다");
                    Console.WriteLine("--------------------------------------");
                    monsterA.CreateMonstor();
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("공격 했다");
                            Console.ReadLine();
                            bool die = monsterA.Damage(player.GetDamage());
                            if (die)
                            {
                                Console.WriteLine("슬라임을 처치했다.");
                                Console.ReadLine();

                                return Place.start;
                            }
                            break;

                        case ConsoleKey.D2:
                            Console.WriteLine("방어한다.");
                            Console.ReadLine();
                            player.Damage(monsterA.GetDamage());
                            break;



                        case ConsoleKey.D3:
                            Console.WriteLine("떠난다.");
                            return Place.start;

                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            return Place.fight;

                    }
                }

            }
        }
    }
}

// 맵 시작 화면
// 캐릭터 
// 번튼 상호 작용
// 몬스터 생성
// 전투 시스템