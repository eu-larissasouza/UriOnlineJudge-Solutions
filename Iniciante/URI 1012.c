#include <stdio.h>

#include <math.h>

int main()
{

  double A, B, C, pi;
  double tri, cir, tra, qua, ret;

  scanf("%lf", &A);
  scanf("%lf", &B);
  scanf("%lf", &C);
  pi = 3.14159;

  tri = (A * C) / 2;
  cir = pi * pow(C, 2);
  tra = ((A + B) * C) / 2;
  qua = B * B;
  ret = A * B;

  printf("TRIANGULO: %.3lf\n", tri);
  printf("CIRCULO: %.3lf\n", cir);
  printf("TRAPEZIO: %.3lf\n", tra);
  printf("QUADRADO: %.3lf\n", qua);
  printf("RETANGULO: %.3lf", ret);
  printf("\n");

  return 0;
}