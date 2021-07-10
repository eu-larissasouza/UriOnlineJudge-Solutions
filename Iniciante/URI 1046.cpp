#include <stdio.h>

int main()
{

  int HI, HF, TEMPO;
  scanf("%d %d", &HI, &HF);
  TEMPO = 24 - HI + HF;
  if (TEMPO > 24)
    printf("O JOGO DUROU %d HORA(S)\n", TEMPO - 24);
  else
    printf("O JOGO DUROU %d HORA(S)\n", TEMPO);

  return 0;
}