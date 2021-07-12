#include <iostream>

using namespace std;

int main()
{
  int n, i = 3, x = 0, y = 1, z;

  cin >> n;

  if (n == 0)
    exit(0);
  if (n == 1)
    cout << x << endl;
  else
  {
    if (n == 2)
      cout << x << " " << y << endl;
    else
    {
      cout << x << " " << y << " ";
      while (i <= n)
      {
        z = x + y;
        x = y;
        y = z;

        if (i == n)
          cout << y << endl;
        else
          cout << y << " ";
        i++;
      }
    }
  }
  return 0;
}