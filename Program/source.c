#include<stdio.h>

void main()
{
#pragma region 변수
	// 데이터를 저장할 수 있는 메모리 공간을 생성하는 것입니다.
# pragma region 자료형
	// 데잍터를 저장하기 위해 데이터의 형태를 정해주는 것입니다.

	// 자료형은 각각의 자료형마다 크기가 정해져 있으며, 자료형의
	// 크기는 바이트 단위로 이루어져 있으며, 자료형의 경우 자료형에
	// 따ㅏ라 저장할 수 있는 값의 종류와 범위가 결정됩니다.
#pragma endregion

#pragma region 변수의 이름 규칙

	// 1. 변수 이름은 대소문자를 구분합니다.
    // ex)int health;
	// ex)int HEALTH;

	// 2. 변수의 이름으로 예약어를 사용할 수 없습니다.
	// ex) char char;X
	
	// 3. 변수의 이름에는 공백이 포함될 수 없습니다
	// ex) fliat time Dellta;X

	// 4. 변수의 이름으로 트거수 무너자 "_". "$"만 상용할 수 있습니다.
	// ex)short under_score;
	// ex)long currency$;

	// 5. 변수의 이름은 숫자로 시작할 수 없습니다.
	// ex)int yeat2025;
	// ex)int 5day;X


#pragma endregion

#pragma region 서식 지정자
	// 변수의 값을 출력하기 위한 자료형의 정보를 명시적으로
	// 지정해주는 것입니다.

	char character = 'A';
	int num = 10;
	float car = 5.5f;

	// 서식 지정자의 경우 하나의 표준 출력 함수에 여러 개의
	// 서식을 넣을 수 있으며, 서식 지정자의 순서는 왼쪽에서
	// 부터 시작합니다.

	printf("character : %c \nnum : %d \ncar : %f", character,num,car);
	
	

	// 서식 지정자는 각각의 서식에 따라 원하는 데이터를 출력
	// 할 수 있으며. 서식과 변수의 형태가 일치하지 않으면
	// 원하는 값이 출력되지 않습니다.

	

	
#pragma endregion


#pragma endregion

}