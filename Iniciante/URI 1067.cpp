#include <cstdio>

int main()
{
  int X;

  scanf("%i", &X);

  for (int i = 0; i <= X; ++i)
  {
    if (i % 2 == 1)
      printf("%i\n", i);
  }

  return 0;
}