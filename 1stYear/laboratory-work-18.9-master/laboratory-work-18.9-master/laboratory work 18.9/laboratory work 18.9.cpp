#include <iostream>
#include"Vector.h"
using namespace std;

#include <iostream>
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
    try 
    {
        int size = -1;
        int pos = -1;
        cout << "enter size:  ";
        size = getCorrectNumber(size);
        Vector A(size);
        cout << "Заполните вектор А:" << endl;
        cin >> A;
        cout << "Ваш самостоятельно заполненный вектор А:" << endl;
        cout << A << endl;
        --A;
        cout << "Ваш вектор без последнего элемента:" << endl;
        cout << A << endl;
        cout << "Введите индекс элемента, который хотите вывести:  ";
        pos = getCorrectNumber(pos);
        cout << A[pos-1];

    }
    catch(int)
    { 
        cout << "ERROR!" << endl;
    }
}

