#include<stdio.h>



void coordinate(int x, int y)
{
	printf("%d%d\n", x ,y);
	
}

void reset(char grade, int level, float experience)
{
	printf("%c%  d%  f", grade, level, experience);



}

void swap(int argumentX, int argumentY)
{

	int z = argumentX;

	argumentX = argumentY;
	argumentY = z;
	

	
}

void swap_value(int *argumentX, int *argumentY)
{

	int z = *argumentX;

	*argumentX = *argumentY;
	*argumentY = z;


}

void main()

{
#pragma region 함수
	 // 하나의 특별한 목적의 작없을 수행하기 위해
	 // 독립적으로 설계된 코드의 집합입니다.

	//initialize();


#pragma endregion

#pragma region 인수
	// 한수가 호출될 떄 매개 변수에 실제로 전달되는 값입니다,

	int x = 10;
	int y = 20;

	swap(&x, &y);
	
	printf("x의 값 : %d y의 값 : %d", x, y);

	// 인수의 경우 함수에 있는 매개 변수에 따라 전달할 수 있는
	// 인수의 수가 결정되며, 값을 전달하는 인수와 값을 전달 받는
	// 매개 변수의 자료형이 서로 일치해야 합니다
#pragma endregion




}







