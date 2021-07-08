#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{

	int N, S, ms, mov, cont;

	cin >> N >> S;
	ms = S;

	for (cont = 0; cont < N; ++cont)
	{
		scanf("%d", &mov);
		S += mov;
		if (S < ms)
			ms = S;
	}
	cout << ms << "\n";

	return 0;
}