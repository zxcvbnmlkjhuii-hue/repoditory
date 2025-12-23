#include<stdio.h>

void main()
{
#define SIZE 5 
#pragma region 자료형 변환
	// 서로 다른 자료형을 가지고 있는  변수끼리 연산이
	// 이루어질 때 기존에 지정했던 자료형을 다른 자료형
	// 으로 변환하는 과정입니다.

#pragma region 암묵적 형 변환
	// 서로 다른 자룧형으로 연산이 이루어질 때 자료형의
	// 크기가 더 큰 자료형으로 변환되는 과정입니다.

	//int a = 10;
	//float b = 3.4f; 
	//
	//printf("%f ",a+b);

	// 표현 범위가 작은 데이터에 표현 범위가 큰 데이터를
	// 저장하게 되면 암묵적으로 데이터 손실이 발생합니다.


#pragma endregion
#pragma region 명시적 항 변환
	// 연산이 이루어지기 전에 사용자가 직접 자료형을
	// 변환하는 과정입니다.

	/*int a = 10;
	int b = 3;

	float result = (float)a / b;

	printf(" % f",result);*/

	// 정수형 변수끼리 연산을 수행하게 되면 정수의 결과
	// 값만 가질 수 있습니다.



#pragma endregion
#pragma region 단축 평가 계산
	// 계산을 진행하는 도중에 결과가 이미 확저오된 경우,
	// 나머지 계산을 생략하는 과정입니다.

	/*int x = 0;
	int y = 0;
	if (x == 0 && y++)
	{
		printf("shdrt circuit");
	}

	if (x != 0 || y++)
	{
		printf("shdrt circuit");

	}
	printf("%d", y);
  */
#pragma endregion
#pragma region 매크로
  // 프로그램 내에서 특정한 데이터가 문자열로 정의되고
  // 처리되는 과정입니다.

  //printf("매크로 SIZE의 값 : %d ", SIZE);

  // 매크로의 경우 자료형이 존재하지 않으므로 메모리 공간을
  // 가지고 있지 않습니다.

  // ex) SIZE = 100;

  // 매크로의 과정은 컴파일 이전에 실행되며, 각 매크로가 실행될 떄
  // 매크로의 대체 목록을 넣어야 하므로 프로그램의 크기가 커지게 됩니다.
#pragma endregion

	for (int x = 1; x < 10; x++)
	{
		for (int y = 1; y < 10; y++)
		{
			int z;
			z = x * y;
			printf(" %d*%d=%d\n", x, y, z);
		}
		printf("\n");
	}

#pragma endregion


}

