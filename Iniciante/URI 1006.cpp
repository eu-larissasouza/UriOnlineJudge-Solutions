#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{

  double A, B, C, MEDIA;

  cin >> A;
  cin >> B;
  cin >> C;

  MEDIA = (A * 0.2 + B * 0.3 + C * 0.5);

  printf("MEDIA = %.1lf", MEDIA);
  printf("\n");

  return 0;
}