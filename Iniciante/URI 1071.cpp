#include <stdio.h>

int main()
{
  int cont, x1, x2, aux, soma;

  while (scanf("%d %d", &x1, &x2) == 2)
  {
    soma = 0;
    if (x1 > x2)
    {
      aux = x1;
      x1 = x2;
      x2 = aux;
    }
    if (x1 % 2 != 0)
    {
      for (cont = x1 + 2; cont < x2; cont++)
      {
        if (cont % 2 != 0)
          soma += cont;
      }
    }
    else
    {
      for (cont = x1 + 1; cont < x2; cont++)
      {
        if (cont % 2 != 0)
          soma += cont;
      }
    }
    printf("%d\n", soma);
  }

  return 0;
}