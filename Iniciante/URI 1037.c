#include <stdio.h>

int main()
{

  float X;
  scanf("%f", &X);

  if (X >= 0 && X <= 25.0000)
    printf("Intervalo [0,25]\n");

  else if (X > 25.0000 && X <= 50.0000)
    printf("Intervalo (25,50]\n");

  else if (X > 50.0000 && X <= 75.0000)
    printf("Intervalo (50,75]\n");

  else if (X > 75.0000 && X <= 100.0000)
    printf("Intervalo (75,100]\n");

  else
    printf("Fora de intervalo\n");

  return 0;
}