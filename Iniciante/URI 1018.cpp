#include <stdio.h>

int main()
{

  int x, N, n100, n50, n20, n10, n5, n2, n1;

  scanf("%d", &N);
  x = N;

  n100 = N / 100;
  N -= (n100 * 100);

  n50 = N / 50;
  N -= (n50 * 50);

  n20 = N / 20;
  N -= (n20 * 20);

  n10 = N / 10;
  N -= (n10 * 10);

  n5 = N / 5;
  N -= (n5 * 5);

  n2 = N / 2;
  N -= (n2 * 2);

  n1 = N;

  printf("%d\n", x);
  printf("%d nota(s) de R$ 100,00\n", n100);
  printf("%d nota(s) de R$ 50,00\n", n50);
  printf("%d nota(s) de R$ 20,00\n", n20);
  printf("%d nota(s) de R$ 10,00\n", n10);
  printf("%d nota(s) de R$ 5,00\n", n5);
  printf("%d nota(s) de R$ 2,00\n", n2);
  printf("%d nota(s) de R$ 1,00\n", n1);

  return 0;
}