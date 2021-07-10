#include <stdio.h>
#include <math.h>

int main()
{

  double pi, volume;
  unsigned short int R;

  scanf("%hd", &R);
  pi = 3.14159;

  volume = (4 / 3.0) * pi * pow(R, 3);

  printf("VOLUME = %.3lf", volume);
  printf("\n");

  return 0;
}