#include <cstdio>

int main()
{

  int i, x, par;

  par = 0;

  for (i = 1; i <= 5; i++)
  {
    scanf("%d", &x);
    if (x % 2 == 0)
      par++;
  }

  printf("%d valores pares\n", par);

  return 0;
}