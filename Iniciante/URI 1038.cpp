#include <stdio.h>

int main()
{

  unsigned short int cod, quant;
  float total;

  scanf("%hd", &cod);
  scanf("%hd", &quant);

  if (cod == 1)
  {
    total = quant * 4.00;
    printf("Total: R$ %.2f\n", total);
  }
  else if (cod == 2)
  {
    total = quant * 4.50;
    printf("Total: R$ %.2f\n", total);
  }
  else if (cod == 3)
  {
    total = quant * 5.00;
    printf("Total: R$ %.2f\n", total);
  }
  else if (cod == 4)
  {
    total = quant * 2.00;
    printf("Total: R$ %.2f\n", total);
  }
  else if (cod == 5)
  {
    total = quant * 1.50;
    printf("Total: R$ %.2f\n", total);
  }

  return 0;
}