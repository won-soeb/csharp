#include<stdio.h>
#define NUM 5
int main() {
	//직각삼각형1
	//	int row, col, k = 0;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	printf("--------직각삼각형1---------\n");
	//	for (row = 1; row <= NUM; row++) {
	//		for (col = 1; col <= row; col++) {
	//			k++;
	//			arr1[row][col] = k;
	//		}
	//	}
	//	for (row = 1; row <= NUM; row++) {
	//		for (col = 1; col <= NUM; col++) {
	//			if (arr1[row][col] == 0) {
	//				printf("   ", arr1[row][col]);
	//			}
	//			else {
	//				printf("%3d", arr1[row][col]);
	//			}
	//		}
	//		printf("\n");
	//	}
	//	system("pause");
	//	return 0;
	//}

	//직각삼각형2 ---------bubble sort의 원리가 된다
	//int row, col, k = 0;
	//int arr2[NUM + 1][NUM + 1] = { 0 };
	//printf("--------직각삼각형2---------\n");
	//for (row = 1; row <= NUM; row++) {
	//	for (col = 1; col <= NUM-row+1; col++) {
	//		k++;
	//		arr2[row][col] = k;
	//	}
	//}
	//for (row = 1; row <= NUM; row++) {
	//	for (col = 1; col <= NUM; col++) {
	//		if (arr2[row][col] == 0) {
	//			printf("   ", arr2[row][col]);
	//		}
	//		else {
	//			printf("%3d", arr2[row][col]);
	//		}
	//	}
	//	printf("\n");
	//}
	//system("pause");
	//return 0;
	//}


	//직각삼각형3
	//int row, col, k = 0;
	//int arr3[NUM + 1][NUM + 1] = { 0 };
	//printf("--------직각삼각형3---------\n");
	//for (row = 1; row <= NUM; row++) {
	//	for (col = row; col <= NUM; col++) {
	//		k++;
	//		arr3[row][col] = k;
	//	}
	//}
	//for (row = 1; row <= NUM; row++) {
	//	for (col = 1; col <= NUM; col++) {
	//		if (arr3[row][col] == 0) {
	//			printf("   ", arr3[row][col]);
	//		}
	//		else {
	//			printf("%3d", arr3[row][col]);
	//		}
	//	}
	//	printf("\n");
	//}
	//system("pause");
	//return 0;
	//}

	//직각삼각형4
	//int row, col = 1, k = 0;
	//int arr4[NUM + 1][NUM + 1] = { 0 };
	//printf("--------직각삼각형4---------\n");
	//for (row = 1; row <= NUM; row++) {
	//	for (col = NUM - row + 1; col <= NUM; col++) {
	//		k++;
	//		arr4[row][col] = k;
	//	}
	//}
	//for (row = 1; row <= NUM; row++) {
	//	for (col = 1; col <= NUM; col++) {
	//		if (arr4[row][col] == 0) {
	//			printf("   ", arr4[row][col]);
	//		}
	//		else {
	//			printf("%3d", arr4[row][col]);
	//		}
	//	}
	//	printf("\n");
	//}
	//system("pause");
	//return 0;
	//}

	//모래시계1 //NUM값이 홀수여야함.
	//	int row, col, k = 0;
	//	int s = 1, e = NUM, mid;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	mid = NUM / 2 + 1; //=(1+NUM)/2
	//	printf("-------모래시계----------\n");
	//	for (row = 1; row <= NUM; row++) {
	//		for (col = s; col <= e; col++) {
	//			k++;
	//			arr1[row][col] = k;	
	//		}
	//			if (row < mid) {
	//			s = s + 1;
	//			e = e - 1;
	//		}
	//		else {
	//			s = s - 1;
	//			e = e + 1;
	//		}
	//		printf("\n");
	//	}
	//	system("pause");
	//	return 0;
	//}

	//모래시계2
	//	int row, col, k = 0;
	//	int s, e, mid;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	mid = NUM / 2 + 1; //=(1+NUM)/2
	//	printf("-------모래시계----------");
	//	for (row = 1; row <= NUM; row++) {
	//		if (row < mid) {
	//			s = row;
	//			e = (1 + NUM) - row;
	//		}
	//		else {
	//			s = (1 + NUM) - row;
	//			e = row;
	//		}
	//		for (col = s; col <= e; col++) {
	//			k++;
	//			arr1[row][col] = k;
	//		}
	//		printf("\n");
	//	}
	//	system("pause");
	//	return 0;
	//}

	//모래시계3
	//	int row, col, k = 0, s = 0, e = NUM+1, mid;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	mid = NUM/2+1;
	//	printf("-------모래시계----------\n");
	//	for (row = 1; row <= NUM; row++) {
	//		if (row <= mid) {
	//			s = s++;
	//			e = e--;
	//		}
	//		else {
	//			s = s--;
	//			e = e++;
	//		}
	//		for (col = s; col <= e; col++) {
	//			k++;
	//			arr1[row][col] = k;
	//		}
	//	}
	//	for (row = 1; row <= NUM; row++) {
	//		for (col = 1; col <= NUM; col++) {
	//			if (arr1[row][col] == 0) {
	//				printf("   ", arr1[row][col]);
	//			}
	//			else {
	//				printf("%3d", arr1[row][col]);
	//			}
	//		}
	//		printf("\n");
	//	}
	//	system("pause");
	//	return 0;
	//}

	//마름모
//	int row, col, k = 0, s, e, mid;
//	int arr[NUM + 1][NUM + 1] = { 0 };
//	mid = NUM / 2 + 1;
//	s = mid+1; 
//	e = mid-1;
//	for (row = 1; row <= NUM; row++) {
//		for (col = s; col <= e; col++){
//		k++;
//		arr[row][col]=k;
//		}
//		if (row < mid) {
//			s--; e++;
//		}
//		else {
//			s++; e--;
//		}
//	}
//	printf("-------------마름모-----------");
//	for (row = 1; row <= NUM; row++) {
//		for (col = 1; col <= NUM; col++) {
//			if (arr[row][col] == 0) {
//				printf("   ", arr[row][col]);
//			}
//			else {
//				printf("%3d", arr[row][col]);
//			}
//		}
//		printf("\n");
//	}
//	system("pause");
//	return 0;
//}

//구구단(범위 지정)

//int i, j, k = 0;
//for (i = 2; i <= 9; i++) {
//	if (i <= 5) {//5단까지만 출력
//		for (j = 1; j <= 9; j++) {
//			k = i * j;
//			printf("%d * %d = %d\n", i, j, k);
//		}
//	}
//	else {
//		break;//중단
//	}
//	printf("---------------------------------------\n");
//}
//system("pause");
//return 0;
//}

//곱하기 5를 제외하고 홀수단만 출력
//	int i, j, k = 0;
//	for (i = 2; i <= 9; i++) {
//			for (j = 1; j <= 9; j++) {
//				if (i % 2 == 1 && j != 5) { //break가 필요없다.
//					k = i * j;
//					printf("%d * %d = %d\n", i, j, k);
//				}
//			}
//		printf("--------------------------------\n");
//	}	
//	system("pause");
//	return 0;
//}

//대각선
	int lo, hi, row, col, k = 0;
	int lin[NUM + 1][NUM + 1] = { 0 };
	printf("=======대각선=======\n");
	for (lo = 2; lo <= NUM*2; lo++) {
		for (row = 1; row <= NUM; row++) {
			col = lo - row;
			if (col < 1)continue;
			if (col > NUM)continue;
			k = k + 1;
			lin[row][col] = k;
		}
	}
	for (row = 1; row <= NUM; row++) {
		for (col = 1; col <= NUM; col++) {
			if (lin[row][col] == 0) {
				printf("   ", lin[row][col]);
			}
			else {
				printf("%3d", lin[row][col]);
			}
		}
		printf("\n");
	}
system("pause");
return 0;
}  

//리을
//	int row, col, k = 0, s = 1, e = NUM, temp, sw = 1;
//	int arr[NUM + 1][NUM + 1] = { 0 };
//	for (row = 1; row <= NUM; row++) {
//			for (col = s; col != e + sw; col += sw) {
//				k++;
//				arr[row][col] = k;
//			}
//			temp = s; s = e; e = temp;
//			sw = -sw;
//		}
//	for (row = 1; row <= NUM; row++) {
//		for (col = 1; col <= NUM; col ++) {
//			if (arr[row][col] == 0) {
//								printf("   ", arr[row][col]);
//							}
//							else {
//								printf("%3d", arr[row][col]);
//							}
//						}
//						printf("\n");
//					}
//				system("pause");
//				return 0;
//}

//마방진(이동방식제작)
//int row=1, col, k=0 ,mid;
//int sel[NUM+1][NUM+1] = { 0 };
//mid = NUM / 2 + 1;
//col = mid;
//for (k = 1; k <= NUM * NUM; k++) {
//	sel[row][col] = k;
//	if (k%NUM == 0) {
//		row = row + 1;
//	}
//	else {
//		row = row - 1;
//		col = col + 1;
//		if (row < 1)row = NUM;
//		if (col > NUM)col = 1;
//	}
//}
//for (row = 1; row <= NUM; row++) {
//	for (col = 1; col <= NUM; col++) {
//		if (sel[row][col] == 0) {
//			printf("   ", sel[row][col]);
//		}
//		else {
//			printf("%3d", sel[row][col]);
//		}
//
//	}
//	printf("\n");
//}
//	system("pause");
//	return 0;
//}

//석차구하기(내림차순)
//	int arr[NUM] = {50,30,70,40,60 };//1번째(0점) 데이터는 무의미하다.
//	int rank[NUM] = { 0 }; 
//	int i, j;//i는 선택값, j는 비교대상
//	for (i = 0; i < NUM; i++) {
//		rank[i] = 1;//랭크 초기값 1 설정이 반드시 필요함
//	}
//	for (i = 0; i < NUM; i++) {
//		for (j = 0; j < NUM; j++) {
//			if (arr[i] < arr[j]) {
//				rank[i] = rank[i] + 1;
//			}
//		}
//	}
//	printf("------------------------\n");
//	for (i = 0; i < NUM; i++) {
//		printf("%3d", rank[i]);
//	}
//	printf("\n------------------------\n");
//	system("pause");
//	return 0;
//}

//석차구하기(내림차순)2
//	int sel[ROW][COL] = { 50,30,70,50,60 };
//	int i, j,temp,k,lo;
//	for (i = 0; i < COL; i++) { 
//		sel[1][i] = 1;
//	}
//	for (i = 0; i < ROW ; i++) {
//		for (j = 0; j < COL; j++) {
//		}
//	}
//	for (i = 0; i < ROW; i++) {
//		for (j = 0; j < COL; j++) {
//			printf("%3d", sel[i][j]);
//		}
//		printf("\n");
//	}
//	printf("-----------내림차순-------------\n");
//	for (i = 0; i < COL-1; i++) {
//		lo = i;
//		for (j = i+1; j < COL; j++) {
//			if (sel[0][i] < sel[0][j]) {
//				sel[1][i] = sel[1][i] + 1;//sel[1][i]++로도 표현
//			}
//			else if(sel[0][i] > sel[0][j]) {//else if --가정이 더 필요할 때 사용
//				sel[1][j] = sel[1][j] + 1;
//			}
//			else {
//				continue;
//			}
//		}
//	}
//	for (i = 0; i < ROW; i++) {
//		for (j = 0; j < COL; j++) {
//			printf("%3d", sel[i][j]);
//		}
//		printf("\n");
//	}
//	printf("------------정렬 후------------\n");  //선택정렬--특정 자료를 선택하여 비교하는 방법 1-2,1-3번째.....비교
//	for (i = 0; i < COL - 1; i++) {//자료가 n개면 비교횟수는 n-1번이다
//		lo = i;
//		for (j = i + 1; j < COL; j++) {
//			if (sel[1][lo] < sel[1][j]) {
//				lo = j;
//			}
//		}
//		if(i != lo) {
//			for (k = 0; k < 2; k++) {
//				temp = sel[k][i];
//				sel[k][i] = sel[k][lo];
//				sel[k][lo] = temp;
//			}
//		}
//	}
//	for (i = 0; i < ROW; i++) {
//		for (j = 0; j < COL; j++) {
//			printf("%3d", sel[i][j]);
//		}
//		printf("\n");
//	}
//	system("pause");
//	return 0;
//}

//단순화1(NUM = 5)
//int arr[NUM] = { 50,30,70,40,60 };
//int i, j, k, temp;
//printf("-----------정렬전------------\n");
//	for (i = 0; i < NUM; i++) {
//		printf("%3d", arr[i]);
//			}
//
//for (i = 0; i < NUM-1; i++) {
//	for (j = i+1; j < NUM; j++) {
//		if (arr[i] > arr[j]) {
//			temp = arr[i];//arr[i] 와 arr[j]의 자리 교환 방법
//			arr[i] = arr[j];//이런 식으로 순환하듯이 쓰면 된다
//			arr[j] = temp;//순환을 위해 temp라는 제3의 임시변수가 필요
//		}
//	}
//}
//printf("\n-----------정렬후------------\n");
//for (i = 0; i < NUM; i++) {
//	printf("%3d", arr[i]);
//}
//printf("\n");
//system("pause");
//	return 0;
//}

//버블정렬---이웃끼리 비교하는 방법 1-2,2-3번째..... 비교
//int arr[NUM] = { 50,30,70,40,60 };
//int i, j, k, temp;
//printf("-----------정렬전------------\n");
//for (i = 0; i < NUM; i++) {
//	printf("%3d", arr[i]);
//}
//for (i = 0; i < NUM - 1; i++) {//여기서는 j+1이 비교대상이다
//	for (j = 0; j < NUM - i - 1; j++) {//NUM리버스
//		if (arr[j] > arr[j + 1]) {
//			temp = arr[j];
//			arr[j] = arr[j + 1];
//			arr[j + 1] = temp;
//		}
//	}
//}
//	printf("\n-----------정렬후------------\n");
//	for (i = 0; i < NUM; i++) {
//		printf("%3d", arr[i]);
//	}
//	printf("\n");
//	system("pause");
//	return 0;
//}

	//	int row, col, k = 0;
	//	int s, e, mid;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	mid = NUM / 2 + 1; //=(1+NUM)/2
	//	printf("-------모래시계----------");
	//	for (row = 1; row <= NUM; row++) {
	//		if (row < mid) {
	//			s = row;
	//			e = (1 + NUM) - row;
	//		}
	//		else {
	//			s = (1 + NUM) - row;
	//			e = row;
	//		}
	//		for (col = s; col <= e; col++) {
	//			k++;
	//			arr1[row][col] = k;
	//		}
	//		printf("\n");
	//	}
	//	system("pause");
	//	return 0;
	//}


	//직각삼각형2 (0항을 기준으로 잡은경우)---------bubble sort의 원리가 된다
	//int row, col, k = 0;
	//int arr2[NUM][NUM] = { 0 };
	//printf("--------직각삼각형2---------\n");
	//for (row = 0; row < NUM; row++) {
	//	for (col = 0; col < NUM - row ; col++) {//col <= NUM - row -1;
	//		k++;
	//		arr2[row][col] = k;
	//	}
	//}
	//for (row = 0; row < NUM; row++) {
	//	for (col = 0; col < NUM; col++) {
	//		if (arr2[row][col] == 0) {
	//			printf("   ", arr2[row][col]);
	//		}
	//		else {
	//			printf("%3d", arr2[row][col]);
	//		}
	//	}
	//	printf("\n");
	//}
	//system("pause");
	//return 0;
	//}

	//점수입력
//	int num;
//	printf("점수입력=  ");
//	scanf_s("%d", &num);//디버깅 창에서 직접 입력이 가능하게 됨
//	printf("점수= %d \n\n\n", num);
//	if (num >= 90 && num <=100) { //swtich
//		printf("A등급 \n");
//	}
//	else if (num >= 80 && num < 90) {//중첩if문. switch문으로 변환 가능.구간을 나눌때 좋다
//		printf("B등급 \n");
//	}
//	else if (num >= 70 && num < 80) {//case
//		printf("C등급 \n");
//	}
//	else if (num >= 60 && num < 70) {
//		printf("D등급 \n");
//	}
//	else if (num >= 0 && num < 60) {
//		printf("F등급 \n");
//	}
//	else { //default
//		printf("입력점수를 확인하세요\n");
//	}
//	system("pause");
//	return 0;
//}

//int num;
//while (1) {//괄호 내부 전체를 무한루프시킨다
//	printf("점수입력(음수입력시 종료)=   ");
//	scanf_s("%d", &num);
//	printf("점수= %d \n", num);
//	if (num < 0)break;
//	if (num > 100 || num < 0) {
//		printf("입력점수를 확인하세요\n");
//	}
//	else {
//		num = num / 10;//점수값을 10으로(정수)나눠서 케이스 넘버별 구간을 설정 
//		switch (num) {
//		case 10://100~109점
//		case 9://90~99점
//			printf("A등급 \n");
//			break;//꼭 적자.
//		case 8:
//			printf("B등급 \n");
//			break;
//		case 7:
//			printf("C등급 \n");
//			break;
//		case 6:
//			printf("D등급 \n");
//			break;
//		default:
//			printf("F등급 \n");
//		}
//	}
//}
//system("pause");
//return 0;
//}

//모든 switch문은 다중if문으로 변환 가능.그러나 반대는 안되는 경우가 있음.



//자료검색(총 정렬)
//	int i, j, k, f, temp, rank;
//	//int low = 0, high = 4, mid;
//	int a[5][8] = { 0 };
//	int temp[8] = { 0 };
//
//	a[0][1] = 89, a[0][2] = 100, a[0][3] = 79, a[0][4] = 76;
//	a[1][1] = 46, a[1][2] = 78, a[1][3] = 99, a[1][4] = 78;
//	a[2][1] = 86, a[2][2] = 80, a[2][3] = 68, a[2][4] = 56;
//	a[3][1] = 67, a[3][2] = 77, a[3][3] = 88, a[3][4] = 68;
//	a[4][1] = 78, a[4][2] = 79, a[4][3] = 98, a[4][4] = 100;
//
//	for (i = 0; i <= 4; i++) {
//		a[i][0] = i + 1;
//		a[i][5] = 0;//5열을 석차값으로 설정
//		for (j = 1; j <= 4; j++) {
//			a[i][5] += a[i][j];//누적,총합
//		}
//		a[i][6] = a[i][5] / 4;//평균
//		a[i][7] = 1;//석차 초기값(등수)
//	}
//		for (i = 0; i <= 3; i++) {
//			for (j = i + 1; j <= 4; j++) {
//				if (a[i][5] < a[j][5]) {//석차정렬
//					a[i][7] += 1;
//				}
//				else {
//					a[j][7] += 1;
//				}
//		}
//	}
//	for (i = 0; i <= 3; i++) {
//		f = i;
//		for (j = i + 1; j <= 4; j++) {
//			if (a[f][7] > a[j][7]) {
//				f = j;
//				temp[k] = a[f][k];
//				a[f][k] = a[i][k];
//				a[i][k] = temp[k];
//			}
//		}
//	}
//	//순차 검색
//	for (i = 0; i <= 4; i++) {
//		if (rank == a[i][7]) {
//			printf("%d등 학생의 정보\n", rank);
//			printf("---------------------------------------------------\n");
//			printf(" 번호 국어 영어 수학 전산 총점 평균 석차\n");
//			for (j = 0; j <= 7; j++) {
//				printf("%6d", a[i][j]);
//			}
//			printf("\n---------------------------------------------------\n");
//			break;
//		}
//	}
//	system("pause");
//	return 0;
//}