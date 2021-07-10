#include <stdio.h>

int main()
{

  int tg, vm, dp;
  double ql;

  scanf("%d", &tg);
  scanf("%d", &vm);

  dp = tg * vm;

  ql = dp / 12.0;

  printf("%.3lf\n", ql);

  return 0;
}