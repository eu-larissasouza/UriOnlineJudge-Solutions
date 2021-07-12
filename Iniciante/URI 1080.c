#include <stdio.h>

int main()
{
  int cont1, cont2, num, maior, posicao;
  cont2 = 0;
  maior = 0;

  for (cont1 = 1; cont1 <= 100; cont1++)
  {
    scanf("%d", &num);
    if (maior < num)
    {
      maior = num;
      posicao = cont1;
    }
  }
  printf("%d\n%d\n", maior, posicao);
  return 0;
}