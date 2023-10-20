#define  _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
int main()
{
	int i;
		char j; 
		float k = 0.0;
		scanf("%d %c%f", &i, &j, &k);
		printf("%f", (i + j + k));
	return 0;
}