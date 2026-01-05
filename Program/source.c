#include<stdio.h>


struct Unit
{
	char rank;
	int hp;
	double ex;
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


	return 0;
}







