#include <stdio.h>

int main()
{

  int div, x;

  scanf("%d", &x);

  for (div = 1; div <= 10000; div++)
  {
    if (div % x == 2)
    {
      printf("%d\n", div);
    }
  }
  return 0;
}