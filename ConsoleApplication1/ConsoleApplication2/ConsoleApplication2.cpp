#include <iostream>
#include <string>
#include <cmath>
using namespace std;


int main() {
	unsigned long long result = 0;
	long k, n;
	cin >> n;
	k = n;
	int counter = 0;

	for (int i = 0, q = 0; i < n; q++) {
		if (k - q > 0) {
			k -= q;
			counter++;
		}
		else {
			break;
		}
	} // counter - result of 1, 2, 3...
	counter--;

	for (int i = 0; i <= counter; i++) {
		result += pow(2, i);
	}
	cout << counter << std::endl;

	cout << result;


	return 0;
}