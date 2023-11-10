#include <iostream>
#include "Vector.h"
#include<Windows.h>
using namespace std;

int getCorrectNumber(int num)
{
    while (!(cin >> num) || (cin.peek() != '\n') || num < 0)
    {
        cin.clear();
        while (cin.get() != '\n');
        cout << "Введите корректное число: ";
    }
    return num;
}


int main()
{
    setlocale(LC_ALL, "rus");
    system("chcp 1251 > null");
    cout << "Введите размер:  ";
    int size = 0, value;
    size = getCorrectNumber(size);
    cout << "Каким элементом заполнить массив?  ";
    cin >> value;
    Vector A(size, value);
    cout << "Ваш вектор:" << endl;
    cout << A << endl;
    cout << "Введите вектор A самостоятельно:" << endl;
    cin >> A;
    cout << "Вектор A:" << endl;
    cout << A << endl;
    Vector B(5);
    cout << "Введите вектор В самостоятельно::" << endl;
    cin >> B;
    cout << "3 элемент вектора В: ";
    cout << B[3] << endl;
    A - B;
    cout << "Разность векторов (А - В):" << endl;
    cout << A << endl;
    Iterator i = A.first();
    cout << "Первый элемент вектора A:  ";
    cout << *i << endl;
    for (i = A.first(); i != A.last(); ++i)
        cout << *i << "  ";
    i = A.last();
    cout << *i << endl;
    Iterator l = A.last();
    cout << "Последний элемент вектора А:  ";
    cout << *l << endl;


}