#include <cstdio>
#include <cmath>

int main()
{

  int a, b, c, MaiorAB = 0;

  scanf("%d %d %d", &a, &b, &c);

  MaiorAB = (a + b + std::abs(a - b)) / 2;

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