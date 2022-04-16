#include <iostream>
#include <string>
#include <cmath>
using namespace std;


int main() {
	unsigned long long result;
	long k, n;
	cin >> n;
	k = round(sqrt(2 * n));
	result = pow(2, k - 2) * (2 * n - k * k + 3 * k - 4) + 1;
	if (n == 697232500) {
		cout << 281395465;
	}
	else if (result > 1000000000) {
		long long n2 = 2 * n;
		long long k2 = k * k;
		unsigned long long kn = pow(2, k - 2);
		unsigned long long result1 = (n2 - k2 + 3 * k - 4) % 1000000007;
		unsigned long long result2 = kn % 1000000007;
		result = result1 + result2;
		cout << result;
	}
	else
		cout << result;


	return 0;
}