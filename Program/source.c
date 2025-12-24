#include<stdio.h>

void main()

{
#pragma region 배열
	// 같은 자료형의 변수들로 이루어진 유한 집합입니다.

	//int A5 [5];

	//// 배열의 경우 첫 번째 원소는 0부터 시작합니다.
	//
	//for (int i = 0; i < 5; i++)
	//{
	//	A5[i] = (i+1) * 10;
	//	printf("%d\n", A5[i]);
	//}
	
	// 배열의 메모리 공간은 프로그램이 실행되는 동안 
	// 변경할 수 없습니다.
	
	int array[] = {1,2,7,4,5,6,0};
	
	//int size = sizeof(array) / sizeof(array[0]);

	//	for (int i = 0; i < size; i++)
	//	{
	//		printf("%d\n", array[i]);
	//	}
	//	//  배열의 크기는 생략할 수 있으며, 초기하 목록에서
	//	// 설정한 요소에 따라 배열의 크기가 결정됩니다.
		printf("%d\n", array[1]);
		int* pointer = &array[1];

		*pointer = +3  ;

		printf("%d", array[1]);

#pragma endregion

}




