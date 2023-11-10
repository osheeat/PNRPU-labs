#include <iostream>
#include "Money.h"
#include "Vector.h"
using namespace std;
int main()
{
    setlocale(LC_ALL, "Russian");
    int size;
    cout << "enter size of array: ";
    cin >> size;
    Vector<int>A(size, 10);
    cout << "Vector A: " << A << endl;
    cin >> A;
    cout << "Vector A: " << A << endl;
    cout << "A[2] = " << A[2] << endl;
    Vector<int>B(5, 7);
    cout << "Vector B: " << B << endl;
    A - B;
    cout << "Разность Векторов:" << endl << A << endl;
    cout << "Размер вектора А: " << A.size() << endl;


    Vector<char>C(size, 'P');
    cout << "Введите элементы для вектора типа char:" << endl;
    cin >> C;
    cout << C << endl;
    Vector<double>D(size, 2.4);
    cout << "Введите элементы для вектора типа double:" << endl;
    cin >> D;
    cout << D << endl;
    Vector<float>E(size, 5.67);
    cout << "Введите элементы для вектора типа float:" << endl;
    cin >> E;
    cout << E << endl;
    Money m(23, 45);
    Vector<Money>N(size, m);
    cout << "Введите элементы для вектора типа float:" << endl;
    cin >> N;
    cout << N << endl;
}
