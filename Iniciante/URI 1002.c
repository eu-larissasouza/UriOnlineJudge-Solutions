#include <stdio.h>
#include <stdlib.h>
#include <math.h>

#define PI 3.14159

int main()
{

  double raio, area;

  scanf("%lf", &raio);

  area = PI * raio * raio;

  printf("A=%.4lf\n", area);

  return 0;
}