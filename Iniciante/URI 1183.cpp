#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{

  char op;
  int i, j;
  float soma = 0, matriz[12][12];

  scanf("%c", &op);

  for (i = 0; i < 12; i++)
  {
    for (j = 0; j < 12; j++)
    {
      scanf("%f", &matriz[i][j]);
      if (j > i)
        soma += matriz[i][j];
    }
  }

  if (op == 'M')
    printf("%.1f\n", soma / 66);
  else if (op == 'S')
    printf("%.1f\n", soma);

  return 0;
}