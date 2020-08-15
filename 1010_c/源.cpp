#include<iostream>

using namespace std;

int main(void) {
	int coe, index, flag = 0;

	while (cin >> coe >> index){
		if (index != 0) {
			if (flag) cout << " ";
			cout << coe * index << " " << index - 1;
			flag = 1;
		}
	}
	if (flag == 0) cout << "0 0";
	return 0;
}