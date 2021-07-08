#include <iostream>
#include <bits/stdc++.h>

using namespace std;

int main()
{

	int V, T, Ai, cont;

	cin >> V >> T;

	for (cont = 0; cont < T; cont++)
	{
		cin >> Ai;
		if (V + Ai > 100)
			V = 100;
		else if (V + Ai > 0)
			V += Ai;
		else
			V = 0;
	}

	cout << V << "\n";
	return 0;
}