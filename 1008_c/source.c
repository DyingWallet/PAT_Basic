#include<stdio.h>
void arrayReverse(int[], int, int);
int main(void) {
    int n, m;
    if (scanf_s("%d%d", &n, &m) != 2)
        return -1;
    m %= n;
    int origin[128];
    for (int i = 0; i < n; i++)
        if (scanf_s("%d", &origin[i]) != 1)
            return -1;
    arrayReverse(origin, n - m, m);
    arrayReverse(origin, 0, n - m);
    arrayReverse(origin, 0, n);
    for (int i = 0; i < n; i++)
        if (i == 0) printf("%d", origin[i]);
        else printf(" %d", origin[i]);
    return 0;
}
void arrayReverse(int origin[], int startIndex, int revLength) {
    int i = startIndex, j = startIndex + revLength - 1;
    while (i < j)
    {
        int temp = origin[i];
        origin[i++] = origin[j];
        origin[j--] = temp;
    }
}