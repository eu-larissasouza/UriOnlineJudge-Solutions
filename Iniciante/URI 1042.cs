using System;

class URI {

  public static void Main(string[] args) {

  int a, b, c, cont1, cont2, cont3, aux;

  scanf("%d %d %d", &a, &b, &c);

  cont1 = a;
  cont2 = b;
  cont3 = c;

  if (cont1 < cont2)
  {
    aux = cont1;
    cont1 = cont2;
    cont2 = aux;
  }

  if (cont2 < cont3)
  {
    aux = cont2;
    cont2 = cont3;
    cont3 = aux;
  }

  if (cont1 < cont2)
  {
    aux = cont1;
    cont1 = cont2;
    cont2 = aux;
  }

  printf("%d\n%d\n%d\n", cont3, cont2, cont1);
  printf("\n");
  printf("%d\n%d\n%d\n", a, b, c);

}
}