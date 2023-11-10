#include <iostream>
#include<string>
#include<vector>
#include "Money.h"
using namespace std;
int main()
{
    setlocale(LC_ALL, "rus");
    long a, d;
    int b, e;
    cout << "Enter rub and kop for Money A" << endl;
    cin >> a >> b;
    cout << "Enter rub and kop for Money B" << endl;
    cin >> d >> e;
    Money A(a, b);
    Money C(d, e);
    if (A==C)
        cout << "Суммы равны" << endl;
    else
        cout << "Суммы не равны" << endl;
}