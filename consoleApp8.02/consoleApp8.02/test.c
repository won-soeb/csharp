#include<stdio.h>
#define NUM 5
int main() {
	//�����ﰢ��1
	//	int row, col, k = 0;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	printf("--------�����ﰢ��1---------\n");
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

	//�����ﰢ��2 ---------bubble sort�� ������ �ȴ�
	//int row, col, k = 0;
	//int arr2[NUM + 1][NUM + 1] = { 0 };
	//printf("--------�����ﰢ��2---------\n");
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


	//�����ﰢ��3
	//int row, col, k = 0;
	//int arr3[NUM + 1][NUM + 1] = { 0 };
	//printf("--------�����ﰢ��3---------\n");
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

	//�����ﰢ��4
	//int row, col = 1, k = 0;
	//int arr4[NUM + 1][NUM + 1] = { 0 };
	//printf("--------�����ﰢ��4---------\n");
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

	//�𷡽ð�1 //NUM���� Ȧ��������.
	//	int row, col, k = 0;
	//	int s = 1, e = NUM, mid;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	mid = NUM / 2 + 1; //=(1+NUM)/2
	//	printf("-------�𷡽ð�----------\n");
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

	//�𷡽ð�2
	//	int row, col, k = 0;
	//	int s, e, mid;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	mid = NUM / 2 + 1; //=(1+NUM)/2
	//	printf("-------�𷡽ð�----------");
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

	//�𷡽ð�3
	//	int row, col, k = 0, s = 0, e = NUM+1, mid;
	//	int arr1[NUM + 1][NUM + 1] = { 0 };
	//	mid = NUM/2+1;
	//	printf("-------�𷡽ð�----------\n");
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

	//������
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
//	printf("-------------������-----------");
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

//������(���� ����)

//int i, j, k = 0;
//for (i = 2; i <= 9; i++) {
//	if (i <= 5) {//5�ܱ����� ���
//		for (j = 1; j <= 9; j++) {
//			k = i * j;
//			printf("%d * %d = %d\n", i, j, k);
//		}
//	}
//	else {
//		break;//�ߴ�
//	}
//	printf("---------------------------------------\n");
//}
//system("pause");
//return 0;
//}

//���ϱ� 5�� �����ϰ� Ȧ���ܸ� ���
//	int i, j, k = 0;
//	for (i = 2; i <= 9; i++) {
//			for (j = 1; j <= 9; j++) {
//				if (i % 2 == 1 && j != 5) { //break�� �ʿ����.
//					k = i * j;
//					printf("%d * %d = %d\n", i, j, k);
//				}
//			}
//		printf("--------------------------------\n");
//	}	
//	system("pause");
//	return 0;
//}

//�밢��
	int lo, hi, row, col, k = 0;
	int lin[NUM + 1][NUM + 1] = { 0 };
	printf("=======�밢��=======\n");
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

//����
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

//������(�̵��������)
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

//�������ϱ�(��������)
//	int arr[NUM] = {50,30,70,40,60 };//1��°(0��) �����ʹ� ���ǹ��ϴ�.
//	int rank[NUM] = { 0 }; 
//	int i, j;//i�� ���ð�, j�� �񱳴��
//	for (i = 0; i < NUM; i++) {
//		rank[i] = 1;//��ũ �ʱⰪ 1 ������ �ݵ�� �ʿ���
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

//�������ϱ�(��������)2
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
//	printf("-----------��������-------------\n");
//	for (i = 0; i < COL-1; i++) {
//		lo = i;
//		for (j = i+1; j < COL; j++) {
//			if (sel[0][i] < sel[0][j]) {
//				sel[1][i] = sel[1][i] + 1;//sel[1][i]++�ε� ǥ��
//			}
//			else if(sel[0][i] > sel[0][j]) {//else if --������ �� �ʿ��� �� ���
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
//	printf("------------���� ��------------\n");  //��������--Ư�� �ڷḦ �����Ͽ� ���ϴ� ��� 1-2,1-3��°.....��
//	for (i = 0; i < COL - 1; i++) {//�ڷᰡ n���� ��Ƚ���� n-1���̴�
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

//�ܼ�ȭ1(NUM = 5)
//int arr[NUM] = { 50,30,70,40,60 };
//int i, j, k, temp;
//printf("-----------������------------\n");
//	for (i = 0; i < NUM; i++) {
//		printf("%3d", arr[i]);
//			}
//
//for (i = 0; i < NUM-1; i++) {
//	for (j = i+1; j < NUM; j++) {
//		if (arr[i] > arr[j]) {
//			temp = arr[i];//arr[i] �� arr[j]�� �ڸ� ��ȯ ���
//			arr[i] = arr[j];//�̷� ������ ��ȯ�ϵ��� ���� �ȴ�
//			arr[j] = temp;//��ȯ�� ���� temp��� ��3�� �ӽú����� �ʿ�
//		}
//	}
//}
//printf("\n-----------������------------\n");
//for (i = 0; i < NUM; i++) {
//	printf("%3d", arr[i]);
//}
//printf("\n");
//system("pause");
//	return 0;
//}

//��������---�̿����� ���ϴ� ��� 1-2,2-3��°..... ��
//int arr[NUM] = { 50,30,70,40,60 };
//int i, j, k, temp;
//printf("-----------������------------\n");
//for (i = 0; i < NUM; i++) {
//	printf("%3d", arr[i]);
//}
//for (i = 0; i < NUM - 1; i++) {//���⼭�� j+1�� �񱳴���̴�
//	for (j = 0; j < NUM - i - 1; j++) {//NUM������
//		if (arr[j] > arr[j + 1]) {
//			temp = arr[j];
//			arr[j] = arr[j + 1];
//			arr[j + 1] = temp;
//		}
//	}
//}
//	printf("\n-----------������------------\n");
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
	//	printf("-------�𷡽ð�----------");
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


	//�����ﰢ��2 (0���� �������� �������)---------bubble sort�� ������ �ȴ�
	//int row, col, k = 0;
	//int arr2[NUM][NUM] = { 0 };
	//printf("--------�����ﰢ��2---------\n");
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

	//�����Է�
//	int num;
//	printf("�����Է�=  ");
//	scanf_s("%d", &num);//����� â���� ���� �Է��� �����ϰ� ��
//	printf("����= %d \n\n\n", num);
//	if (num >= 90 && num <=100) { //swtich
//		printf("A��� \n");
//	}
//	else if (num >= 80 && num < 90) {//��øif��. switch������ ��ȯ ����.������ ������ ����
//		printf("B��� \n");
//	}
//	else if (num >= 70 && num < 80) {//case
//		printf("C��� \n");
//	}
//	else if (num >= 60 && num < 70) {
//		printf("D��� \n");
//	}
//	else if (num >= 0 && num < 60) {
//		printf("F��� \n");
//	}
//	else { //default
//		printf("�Է������� Ȯ���ϼ���\n");
//	}
//	system("pause");
//	return 0;
//}

//int num;
//while (1) {//��ȣ ���� ��ü�� ���ѷ�����Ų��
//	printf("�����Է�(�����Է½� ����)=   ");
//	scanf_s("%d", &num);
//	printf("����= %d \n", num);
//	if (num < 0)break;
//	if (num > 100 || num < 0) {
//		printf("�Է������� Ȯ���ϼ���\n");
//	}
//	else {
//		num = num / 10;//�������� 10����(����)������ ���̽� �ѹ��� ������ ���� 
//		switch (num) {
//		case 10://100~109��
//		case 9://90~99��
//			printf("A��� \n");
//			break;//�� ����.
//		case 8:
//			printf("B��� \n");
//			break;
//		case 7:
//			printf("C��� \n");
//			break;
//		case 6:
//			printf("D��� \n");
//			break;
//		default:
//			printf("F��� \n");
//		}
//	}
//}
//system("pause");
//return 0;
//}

//��� switch���� ����if������ ��ȯ ����.�׷��� �ݴ�� �ȵǴ� ��찡 ����.



//�ڷ�˻�(�� ����)
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
//		a[i][5] = 0;//5���� ���������� ����
//		for (j = 1; j <= 4; j++) {
//			a[i][5] += a[i][j];//����,����
//		}
//		a[i][6] = a[i][5] / 4;//���
//		a[i][7] = 1;//���� �ʱⰪ(���)
//	}
//		for (i = 0; i <= 3; i++) {
//			for (j = i + 1; j <= 4; j++) {
//				if (a[i][5] < a[j][5]) {//��������
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
//	//���� �˻�
//	for (i = 0; i <= 4; i++) {
//		if (rank == a[i][7]) {
//			printf("%d�� �л��� ����\n", rank);
//			printf("---------------------------------------------------\n");
//			printf(" ��ȣ ���� ���� ���� ���� ���� ��� ����\n");
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