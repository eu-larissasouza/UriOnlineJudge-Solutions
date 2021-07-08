#include <iostream>
#include <vector>
#include <string.h>

using namespace std;

int main(int argc, char **argv)
{
  int T1, T2, T3, T4, x;

  cin >> T1 >> T2 >> T3 >> T4;

  x = T1 + T2 + T3 + T4 - 3;
  cout << x << "\n";

  return 0;
}