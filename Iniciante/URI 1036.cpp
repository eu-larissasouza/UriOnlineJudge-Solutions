#include <iostream>
#include <cmath>

using namespace std;

int main()
{

  double A, B, C, delta;

  cout.precision(5);
  cout << fixed;

  cin >> A;
  cin >> B;
  cin >> C;

  delta = B * B - 4 * A * C;

  if (A == 0 || delta < 0.0)
    cout << "Impossivel calcular\n";
  else
    cout << "R1 = " << (-B + sqrt(delta)) / (2 * A) << "\nR2 = " << (-B - sqrt(delta)) / (2 * A) << "\n";

  return 0;
}