#include "Object.h"
#include"Data.h"
#include"Triad.h"
#include"Vector.h"
#include <iostream>
using namespace std;

int main()
{
    Triad A;
    cin >> A;
    cout << A << endl;
    A.IncreaseFirst();
    A.IncreaseSecond();
    A.IncreaseThird();
    cout << A << endl;
    Date B;
    cin >> B;
    cout << B << endl;
    B.IncreaseFirst();
    B.IncreaseSecond();
    B.IncreaseThird();
    cout << B << endl;

    cout << "--------------------------" << endl;
    Object* pointer1 = &A;
    Triad* pointer2 = &B;
    Vector list;
    list.push_back(pointer1);
    list.push_back(pointer2);
    cout << list << endl;
}
