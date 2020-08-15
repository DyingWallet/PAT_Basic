#include<stdio.h>
#include<math.h>
#define MAX 10000000

int main(void) {
	int startIndex, endIndex, count = 0, notPrime = 1;
	if (scanf_s("%d %d", &startIndex, &endIndex) != 2)
		return -1;
	for (int current = 2, index = 0; current < MAX && index < endIndex; current++) {
		notPrime = 1;
		if (current < 5) {
			if (current == 2 || current == 3) {
				notPrime = 0;
				index++;
			}
		}
		else
		{
			if (current % 6 != 1 && current % 6 != 5)
				continue;
			notPrime = 0;
			int root = (int)sqrt(current);
			for (int fac = 5; fac <= root; fac += 6)
				if (current % fac == 0 || current % (fac + 2) == 0) {
					notPrime = 1;
					break;
				}
			if (!notPrime)
				index++;
		}
		if (!notPrime && index >= startIndex) {
			count++;
			int flag = count % 10;
			if (flag != 1)
				printf(" ");
			printf("%d",current);
			if (flag == 0)
				printf("\n");
		}
	}
	return 0;
}