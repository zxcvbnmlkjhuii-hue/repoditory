#include<stdio.h>

void main()
{
#pragma region 조건문
	// 어떤 조건이 주어질 때 해당 조건에 따라 동작을
	// 수행하도록 실행하는 명령문입니다.
#pragma region 관계 연산자
	// 두 개의 피연산자의 값을 비교하여 그 결과를 0 또는
	// 1이라도 값으로 나타내는 연산자입니다.

	//int accuracy = 10;
	//int attack = 20;

	//printf("accuracy < attack : %d\n", accuracy < attack);

	//printf("accuracy > attack : %d\n", accuracy > attack);

	//printf("accuracy <= attack : %d\n", accuracy <= attack);

	//printf("accuracy >= attack : %d\n", accuracy >= attack);

	//printf("accuracy != attack : %d\n", accuracy != attack);

	//printf("accuracy == attack : %d\n", accuracy == attack);

	// 관계 연산자는 조건이 맞을 때 1이라는 값으로 반환되며,
	// 조건이 틀릴 때는 0이라는 값으로 반환됩니다.
#pragma endregion
#pragma region if문
	// 어떤 특정한 조건을 비교하여 조건이 맞나면 실행되는
	// 명령문입니다.

	//int health = 0;
	//if (health <= 0)
	//{
	//	printf("destroy");
	//}

	// if문은 조건이 1일 때 실행되며, 0일 때 실행되지 않습니다.


#pragma endregion
#pragma region else if문
	// if문의 조건이 틀릴 때 else if문의 조건이
	// 맞다면 실행되는 명령문입니다.

	//int level = 1;

	//if (level < 1)
	//{
	//	
	//	printf("destroyA");
	//}
	//else if(level >= 1)
	//{
	//	printf("destroy");
	//}

	// else if문은 여러번 정의할 수 있으며,if문이
	// 존재할 때 사용 할 수 있습니다.
<<<<<<< HEAD
=======
#pragma endregion
#pragma region  else문
	// if문과 else if문의 조건이 다 틀리면
	// 실행되는 명령문입니다.

<<<<<<< HEAD
	int integer = 0;
=======
	printf("character : %c \nnum : %d \ncar : %f", character,num,car);	
	
	
>>>>>>> 5ff6dfcf5f946dbad21e93f3f4ff2417149b9be5

		if (integer > 0)
		{
			printf("+");
		}
		else if (integer < 0)
		{
			printf("-");
		}
		else
		{
			printf("integer");
		}

		// if문에 연결된 모든 조건문이 조건이 맞을 때
		// 가장 위에 있는 조건문만 실행됩니다.
>>>>>>> 9c2e0bee3c391fd3ccc5ba5a6d8ce234eaec3ca2
#pragma endregion
#pragma region  else문
	// if문과 else if문의 조건이 다 틀리면
	// 실행되는 명령문입니다.
	//int integer = 0;


	//	if (integer > 0)
	//	{
	//		printf("+");
	//	}
	//	else if (integer < 0)
	//	{
	//		printf("-");
	//	}
	//	else
	//	{
	//		printf("integer");
	//	}

		// if문에 연결된 모든 조건문이 조건이 맞을 때
		// 가장 위에 있는 조건문만 실행됩니다.
#pragma endregion
#pragma region switch문
	// 어떤 결과에 따라 그  결과부터 실행되는 명령문입니다.
	//char grade = 'K';

	//// switch문은 해당 조건이 완료되었을 때, break문이 없으면
	//// 나머지 밑에 있는 case 문까지 계속 실행시키다가 종료합니다.
	//
	//switch (grade)
	//{
	//case 'F' :
	//	printf("60점 이하입니다.\n");
	//	break;
	//case 'D':
	//	printf("61~69점 입니다.\n");
	//	break;
	//case 'C':
	//	printf("70~79점 입니다.\n");
	//	break;
	//case 'B':
	//	printf("80~89점 입니다.\n");
	//	break;
	//case 'A':
	//	printf("90~100점 입니다.\n");
	//	break;
	//default:
	//	printf("exception\n");
	//	break;
	// switch문의 경우 조건에 해당하는 값에 따라 조건의
	// 위치로 이동합니다.

#pragma endregion
#pragma region 논리 연산자

#pragma region AND 연산자
	// 두 개의 조건이 다 성립될 때 실행되는 연산자입니다.

	//int a = 1;
	//int b = 2;
	//if(a > 0 && b > 0)
	//{
	//	printf("true");
	//}

	//  조건문에서 하나 이상의 조건이 있다면 오니쪽부터 조건을 검사합니다.

#pragma endregion
#pragma region ON 연산자
// 두 개의 조건 중에서 하나라도 조건이 성립될 때 실행되는 연산자입니다.
	//int a = 90;
	//int b = 101;
	//if(a > 100 || b > 100)
	//{
	//	printf("true");
	//}
	//// 조건문의 논리 표현식을 평가하는 도중에 결과가 이미 확정이 났다면, 그 이후의 평가는 생략합니다,

#pragma
#pragma endregion
#pragma region  NOT 연산자
// 하나의 조건을 반전시키는 연산자입니다.
//int power = 1;
//
//if (!power)
//{
//	printf("on");
//}
//
//else
//{
//printf("off");
//}
#pragma endregion

#pragma
#pragma endregion
#pragma region 사분면
int x = 0;
int y = -1;

if (x > 0 && y > 0)
{
	printf("제 1 사분면");
}

 if (x < 0 && y > 0)
{
	printf("제 2 사분면");
}
 if (x < 0 && y < 0)
{
	printf("제 3 사분면");
}
 if (x > 0 && y < 0)
{
	printf("제 4 사분면");
}
else if (x = 0 )
{
	printf("X 절편");
}
else if ( y = 0)
{
	printf("Y 절편");
}
#pragma endregion



}