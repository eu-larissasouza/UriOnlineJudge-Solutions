#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{

  int n, x, men, pos, cont;

  cin >> n;

  for (cont = 0; cont < n; cont++)
  {
    scanf("%d", &x);
    if (cont == 0)
    {
      men = x;
      pos = cont;
    }
    else
    {
      if (x < men)
      {
        men = x;
        pos = cont;
      }
    }
  }

  printf("Menor valor: %d\n", men);
  printf("Posicao: %d\n", pos);

  return 0;
}