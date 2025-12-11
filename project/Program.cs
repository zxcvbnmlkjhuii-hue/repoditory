
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Programmer_A;     //유저스페이스를 생략을 위해 귀찮아서

//개체지향 프로그램c#은
//클래스로 시작해서 클래스로 끝난다.
namespace Trst1
{
    internal class Program
    {
        //static string TempFunc()
        //{
        //    Console.WriteLine("매서드1");
        //    string str = "리턴";
        //    return str;
        //    Console.WriteLine("매1");
        //}
        static void Main(string[] args)     //일단 문법
        {
            //int i = 11; //i 값 정하기
            //int l = 5;
            //string str = TempFunc();
            //string str2 = Console.ReadLine();

            //Console 
            ////char c = '지';         //단일문자 저장
            ////string s = "원하시는만큼 저장 가능";   //문자열 저장 쓰는 만큼 저장
            ////Console.WriteLine(c);
            ////Console.WriteLine(s);

            ////int result;
            ////result = i + l;
            ////Console.WriteLine(result);
            ////result = i - l;
            ////Console.WriteLine(result);
            ////result = i * l;
            ////Console.WriteLine(result);
            ////result = i / l;
            ////Console.WriteLine(result);

            ////int temp = i + (int)l; //큰거에서 작은거로 가면 렘누수가 생겨 (int)로 바꾼다
            ////float f = 5.5f; //55.5 뒤에f 는 문법 같은거
            ////double d = 5.5;  //상관 없음
            //int lv = 3000;

            //Console.WriteLine(i);   //i 값 텍스트 출력
            //Console.WriteLine(l);
            //Console.WriteLine(lv);
            //i = -77; //i -77 다시 정립
            //Console.WriteLine("i 값을 바꿧습니다.");      //텍스트 출력
            //Console.WriteLine(i);      //i 값 턱스트 출력
            //Console.ReadLine();     // 전체 적으로 출력


            ////Monster monsterA = new Monster();   //몬스터 생성
            ////NPC NPC1 = new NPC();   //NPC 생성
            ////NPC1.move();        //NPC1 움직였다
            ////monsterA.move();    //몬스터A가 움직였다


            //Console.ReadLine();



        }
    }
}

namespace Programmer_A
{
    class Monster  //몬스터라는 정보 
    {
        int lv;      //매계 변수 세부적인 사항

        public void move()  //매서드 == 방향성
        {
            Console.WriteLine("몬스터가 움직였다");     //텍스트 출력
        }
        public void Att()
        {

        }


    }

}
namespace Programmer_A
{
    class NPC
    {
        public void move()  //매서드
        {
            Console.WriteLine("NPC 움직였다");      //Npc 움직였다 출력
        }

    }
}



// 게임만든다.->프로젝트 만들기
//캐릭터를 만든다 -> 클래스 
//캐리거 스텟이 있다 -> 매개변수를 만든다.
//캐릭터가 공격한다. -> 매서드를 만든다.
//int 자료형 - 데이터타입 
//lv 이름
// void = 리턴값이 없다 = 매서드가 결과 값을 전달해주고 종료하다
//스텍키는 힘들고 문법 만이 라도 만들고 
//집에서 계산기라도 만들어 보기