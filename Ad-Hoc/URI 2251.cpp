#include <stdio.h>
#include <stdlib.h>
#include <cmath>

int main()
{

	int mov[30], aux, n;
	int disc;

	aux = 0;

	do
	{
		scanf("%d", &disc);
		disc = abs(disc);
		mov[aux] = (pow(2, disc)) - 1;
		aux++;
	} while (disc != 0);

	for (n = 0; n < aux - 1; n++)
	{
		printf("Teste %i\n", n + 1);
		printf("%i\n\n", mov[n]);
	}

	return 0;
}