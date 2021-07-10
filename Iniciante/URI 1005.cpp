#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{

  double A, B, MEDIA;

  cin >> A;
  cin >> B;

  MEDIA = (A * 3.5 + B * 7.5) / 11;

  printf("MEDIA = %.5lf", MEDIA);
  printf("\n");

  return 0;
}