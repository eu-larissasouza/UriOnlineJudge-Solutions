#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

int main()
{

  double raio, pi, area;

  pi = 3.14159;

  cin >> raio;

  area = pi * (raio * raio);

  printf("A=%.4lf\n", area);

  return 0;
}