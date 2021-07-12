#include <stdio.h>

int main()
{

  int x, tab, y;

  scanf("%d", &y);

  for (x = 1; x <= 10; x++)
  {
    tab = x * y;
    printf("%d x %d = %d\n", x, y, tab);
  }

  return 0;
}