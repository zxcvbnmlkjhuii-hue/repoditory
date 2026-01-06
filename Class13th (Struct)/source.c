#include <stdio.h>
#include <math.h>

struct Unit
{
	char rank;
	int hp;
	double ex;
};

struct  Point2D
{
	int x;
	int y;
};

struct Ability
{
	char rank;
	double hp;
	int ex;

};

int main()
{
#pragma region 구조체
	// 여러 개의 변수를 하나의 집합으로 구조화한 다음
	// 하나의 객체를 생성하는 것입니다.

	//struct Unit unit = { 'A',100,135.75};
	//
	//printf("%c\n", unit.rank);
	//printf("%d\n",unit.hp);
	//printf("%f\n", unit.ex);


	//// 구조체의 각 멤번는 주조체 선언에서 나타나는 순서대로 초기화디며
	//// 이 순서는 초기화 목록의 값들이 왼쪽에서부터 오른쪽으로 시작됩니다.

	//unit.rank = 'B';
	//unit.hp = 120;
	//unit.ex = 140.30;
	//printf("%c\n", unit.rank);
	//printf("%d\n", unit.hp);
	//printf("%f\n", unit.ex);

	// 구조체를 선언하기 전에 구조체는 메모리 공간이 생성되지 않으므로,
	// 구조체 내부에 있는 데이터를 초기화할 수 있습니다.
#pragma endregion

#pragma region 두 점 사이의 거리

	//printf("%f\n", pow(2,3)); 

	//struct Point2D Player = { 7,6 };
	//struct Point2D Monster = { 3,4 };

	//int lengthX = Player.x - Monster.x;
	//int lengthY = Player.y - Monster.y;

	//printf("%f\n", sqrt(pow(lengthX,2) +pow(lengthY, 2)));

	//if (sqrt(pow(lengthX, 2) + pow(lengthY, 2)) < 5)
	//{
	//	printf("공격");
	//}
	//else
	//{
	//	printf("회피");
	//}
	//
#pragma endregion

#pragma region 바이트 패딩
	// 멤버 변수를 메모리에서 CPU롤 읽을 때 한 번에
	// 읽을 수 있도록, 컴파일러가 레지스터의 블록에
	// 맞추어 바이트를 패딩해주는 최적화 작업입니다.

	//struct Unit object = {'A',10.2,12};

	//printf("%u\n",sizeof(object));


	//// 구조체의 크기는 구조체를 구성하는 멤버 중에서 크기가
	//// 가장 큰 자료형의 배수가 되도록 설정합니다.


	//struct Ability aobject = { 'A',10.2,12 };

	//printf("%u", sizeof(aobject));
	// 구조체 크기의 경우 멤버 변수의 순서에 따라 메모리의 크기가
	// 

#pragma endregion


	return 0;
}







