#include<stdio.h>
#include<math.h>
int main(void) {
	int max, count = 0, pre, root, notPrime = 0;
	scanf_s("%d", &max);
	if (max >= 5) {
		pre = 5;
		count++;
		for (int curr = 7; curr <= max; curr++) {
			if (curr % 6 != 1 && curr % 6 != 5)
				continue;
			root = (int)sqrt(curr);
			for (int j = 5; j <= root; j += 6)
				if (curr % j == 0 || curr % (j + 2) == 0) {
					notPrime = 1;
					break;
				}
				else
					notPrime = 0;
			if (notPrime == 0) {
				if (curr - pre == 2)
					count++;
				pre = curr;
			}
		}
	}
	printf("%d", count);
}