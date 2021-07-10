#include <stdio.h>

int main()
{

  float num[6];
  int val = 0;
  int i;

  for (i = 0; i <= 5; i++)
  {
    scanf("%f", &num[i]);
    if (num[i] > 0)
    {
      val++;
    }
  }

  printf("%d valores positivos\n", val);

  return 0;
}