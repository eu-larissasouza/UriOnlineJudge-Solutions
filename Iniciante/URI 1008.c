#include <stdio.h>

int main()
{

  int NUMBER, TIME;
  double SALARY, AUX;

  scanf("%d", &NUMBER);
  scanf("%d", &TIME);
  scanf("%lf", &AUX);

  SALARY = (AUX * TIME);

  printf("NUMBER = %d\n", NUMBER);
  printf("SALARY = U$ %.2lf", SALARY);
  printf("\n");

  return 0;
}