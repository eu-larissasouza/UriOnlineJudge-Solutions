#include <stdio.h>

int main()
{

  int N, hr, min, seg;

  scanf("%d", &N);

  hr = N / 3600;
  N -= (hr * 3600);

  min = N / 60;
  N -= (min * 60);

  seg = N;

  printf("%d:%d:%d", hr, min, seg);
  printf("\n");

  return 0;
}