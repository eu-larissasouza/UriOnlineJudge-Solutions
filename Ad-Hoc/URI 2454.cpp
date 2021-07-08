#include <iostream>

using namespace std;

int main()
{

	int P, R;

	cin >> P >> R;

	if (P == 0)
		cout << "C"
				 << "\n";

	if ((P == 1) && (R == 0))
		cout << "B"
				 << "\n";

	if ((P == 1) && (R == 1))
		cout << "A"
				 << "\n";

	return 0;
}