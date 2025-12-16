#include<stdio.h>

void main()
{
#pragma region 오버플로우
	// 특정한 자료형이 표현할 수 있는 최댓값의 범위를
	// 넘어서 연산을 수행하는 과정입니다.

	//char storage = 127 + 3;
	//
	//printf("storage : %d\n", storage);

	// 오버플로우는 부호 없는 자료형에서도 똑같이 발생하며,
	// 실수일 때 오버플로우가 발생하면 infinity라는 값으로 출력됩니다.
#pragma endregion

#pragma region 언더플로우
	// 특정한 자료형이 표현할 수 있는 최솟갑의 범위를
	// 넘어서 연산을 수행하는 과정입니다

	/*char data = -128 - 3;
	printf("data : %d\n", data);*/

	// 언더플로우는 부호 없는 자료형에서도 똑같이 발생하며.
	// 실수일 때 언더플로우가 발생하면 0이라는 값으로 출력합니다.
#pragma endregion
#pragma region 부호 없는 자료형

	//unsigned int count = 4294967295;

	////[1111 1111] [1111 1111] [1111 1111] [1111 1111]
	//printf("signed count 변수의 값 : %d\n", count);

	////[1111 1111] [1111 1111] [1111 1111] [1111 1111]
	//printf("ㅕigned count 변수의 값 : %u\n", count);

#pragma endregion
#pragma region 실수를 표현하는 방법

#pragma region 서식 지정자
	// 변수의 값을 출력하기 위한 자료형의 정보를 명시적으로
	// 지정해주는 것입니다.

	//char character = 'A';
	//int num = 10;
	//float car = 5.5f;

	//// 서식 지정자의 경우 하나의 표준 출력 함수에 여러 개의
	//// 서식을 넣을 수 있으며, 서식 지정자의 순서는 왼쪽에서
	//// 부터 시작합니다.

	//printf("character : %c \nnum : %d \ncar : %f", character,num,car);	
	//


	// 서식 지정자는 각각의 서식에 따라 원하는 데이터를 출력
	// 할 수 있으며. 서식과 변수의 형태가 일치하지 않으면
	// 원하는 값이 출력되지 않습니다.




#pragma endregion
//	float decimal = 3.3f;
//// 정수형 리터럴 상수는 저장하는 값의 범위가 크지 않으면
////int 자료형으로 저장되며. 실수형 리터럴 상수는 double
//// 자료형으로 저장됩니다
//
//	printf("decimal 변수의 값 : %.8f\n", decimal);
//
//	//표준 출력 함수로 소수를 풀력할 때 4 byte 크기의 실수형
//	// 자료형은 소수점 이하 6자리까지만 표기하며, 8 byte 크기의 
//	//실수형  자료형은
#pragma endregion
#pragma region 실수 형태의 (10) 진수를 (2)진수로 변환하는 과정
	   // 10진수 실수 부분을 1.0이 될 때까지 계속 2로 곱한 다음
	   // 곱한 결과의 정수 부분을 위에서 



#pragma endregion
}