#include <stdio.h>

int main()
{

  char nome[21];
  double SALARIO, MONTANTE, lucro, TOTAL;

  scanf("%s", &nome);
  scanf("%lf %lf", &SALARIO, &MONTANTE);

  lucro = 0.15 * MONTANTE;
  TOTAL = SALARIO + lucro;

  printf("TOTAL = R$ %.2lf\n", TOTAL);

  return 0;
}