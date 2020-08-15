#include<iostream>
#include<string>

using namespace std;

int main(void) {
	string s1, s2, s3, s4;
	string weekDays[7] = { "MON ", "TUE ", "WED ", "THU ", "FRI ", "SAT ", "SUN " };
	bool foundDay = false;
	cin >> s1 >> s2 >> s3 >> s4;
	for (size_t i = 0; i < (s1.length() < s2.length() ? s1.length() : s2.length()); i++)
		if (!foundDay && s1[i] == s2[i] && ('A' <= s1[i] && s1[i] <= 'G')) {
			cout << weekDays[s1[i] - 'A'];
			foundDay = true;
			continue;
		}
		else if (foundDay && s1[i] == s2[i] && (('0' <= s1[i] && s1[i] <= '9') || ('A' <= s1[i] && s1[i] <= 'N'))) {
			isdigit(s1[i]) ? cout << "0" << s1[i] - '0' << ":" : cout << s1[i] - 'A' + 10 << ":";
			break;
		}
	for (size_t i = 0; i < (s3.length() < s4.length() ? s3.length() : s4.length()); i++)
		if (s3[i] == s4[i] && isalpha(s3[i])) {
			(i / 10) ? cout << i : cout << "0" << i;
			break;
		}
	return 0;
}