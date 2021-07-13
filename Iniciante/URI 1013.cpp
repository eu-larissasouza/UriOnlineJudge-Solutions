#include <stdio.h>

int main()
{
  int a, b, c, MaiorAB = 0;

  scanf("%d %d %d", &a, &b, &c);

  if (MaiorAB > c)
  {
    printf("%d eh o maior", MaiorAB);
  }
  else
  {
    printf("%d eh o maior", c);
  }

  return 0;
}