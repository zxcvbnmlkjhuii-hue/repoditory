#include<stdio.h>

void main()

{
#pragma region  주소 연산자
	// 변수의 주소 값을 반환하는 연산자입니다.

	/*int data = 10;

	printf("%p", &data);*/

	// 데이터의 주소는 해당 데이터가 저장된 메모리의 시작 주소를
	// 의미하며, 메모리의 공간은 byte의 크기로 나누어 표현합니다.

#pragma endregion

#pragma region 표준 입력 함수
	// 여러 종류의 데이터를 다양한 서식에 맞추어
	// 입력해주는 함수입니다.
	//int x = 0;

	//// 표준 입력 함수는 입력을 수행할 때까지 다음 작업으로
	//// 넘어갈 수 없습니다.
	//printf("x 변수의 값을 입력 :");

	//scanf_s("%d", &x);

	//// 버퍼는 데이터가 이동할 때 임시로 저장되는 공간이며,
	//// 서식 지정자에 따라 입력할 수 있는 데이터의 범위도 결정됩니다,

	//printf("x의 값 : %d", x);
	//
	// 표준 입력 함수로 데이터를 입력하게 되면 버퍼에 데이터를 보관
	// 하였다가 입력하는 순간 버퍼 안의 내용을 프로그램에 전송합니다.


#pragma endregion

#pragma region 포인터
	// 메모리의 주소 값을 저장할 수 있는 변수입니다.

//	int storage = 10;
//	int room = 20;
//	int * pointer = &storage;
//	
//	/// 포인터가 가리키는 메모리 공간의 자료형은 알 수 없으므로,
//	// 포인터가 가리키는 메모리의 자료형을 선언해주어야 합니다.
//
//	printf("storage의 주소 %p\n", &storage);	
//	printf("pointer의 값 %p\n", pointer);
//	printf("pointer의 주소 %p\n", &pointer);
//	*pointer = 99;
//	printf("storage의 값 %d\n", storage);
//	printf("pointer변수가 가리키는 값 %d\n", *pointer);
//	
//	pointer = &room;
//
//	printf("storage의 값 %p\n", pointer);
//	printf("room변수가 가리키는 값 %d\n", *pointer);
//
//	// 포인터 변수도 자신의 메모리 공간으 가지고 있으며, 포인터 변수에
//	// 변수의 주소를 저장하게 되면 해당 변수의 시작 주소를 가림킵니다.
//
//	printf("int의 크기 : %u\n", sizeof(int));
//	printf("pointer의 크기 : %u\n", sizeof(pointer));
//	// 포인터 변수의 크기는 중앙 처리 장치가 한 번에 처리할 수 있는
//	// 크기로 정해지며, 한 번에 처리할 수 있는 크기는 운영체제에 따라 크기가 결정됩니다.
//
#pragma endregion

#pragma region 범용 포인터
	// 자료형이 정해지지 않은 상태로 모든 자료형을
	// 저장할 수 있는 포인터입니다.

	//char a = 'A';
	//int b = 10;
	//float c = 3.14f;

	//// 범용 포인터는 메모리 주소에 접근해서 값을
	//// 변경할 수 없습니다.
	//void* reference = &a;
	//*(char*)reference = 'B';
	//printf("%c\n", a);
	//reference = &b;
	//*(int*)reference = 20;
	//printf("%d\n", b);
	//reference = &c;
	//*(float*)reference = 4.12f;
	//printf("%f\n", c);


	// 범용 포인터로 변수의 메모리에 접근하려면 범용 포인터가
	// 가리키는 변수의 자료형으로 변환해주어야 합니다.



#pragma endregion

#pragma region 상수 지시 포인터
// 포인터가 가리키는 주소에 저장되어 있는 값을 변경할 수 없도록 
// 지정되어 있는 포이터입니다.

	//int z = 20;
	//int y = 10;
	//const int* fixcdPoninter = &y;
	////*fixcdPoninter = 20 안됨;
	//fixcdPoninter = &z;
	//printf("%d", *fixcdPoninter);
#pragma endregion

#pragma region 포인터 상수
// 포인터 변수가 가리키고 있는 주소 값을 변경할 수
// 없는 포인터입니다

	//int z = 20;
	//int y = 10;
	//int*const fixcdPoninter = &y;
	//*fixcdPoninter = 99;
	///*fixcdPoninter = &z; 안됨*/
	//printf("%d\n", *fixcdPoninter);
	//printf("%d", y);

	//상수로 선언한 포인터는 해당 변수의 값을 변경할 수 있지만, 다른 변수의
	// 주고를 새로 저장할 수는 없습니다.
#pragma endregion



#pragma endregion



}