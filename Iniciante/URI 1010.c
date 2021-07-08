#include <stdio.h>

int main()
{

  int c1, c2, n1, n2;
  double v1, v2, result;

  scanf("%d %d %lf", &c1, &n1, &v1);
  scanf("%d %d %lf", &c2, &n2, &v2);

  result = (n1 * v1) + (n2 * v2);

  printf("VALOR A PAGAR: R$ %.2lf", result);
  printf("\n");

  return 0;
}