#include <iostream>

using namespace std;

class Rabochiy
{
    double first; // катет А
    double second; // катет В
public:
    double GetKatet()
    {
        double  tmp;
        cin >> tmp;
        while (tmp <= 0) 
        {
            cout << "Введите длину корректно: ";
            cin >> tmp;
        }
        return tmp;
    }
    Rabochiy()
    {
        double first = 0; 
        double second = 0;
    }
    Rabochiy(double first, double second)
    {
        this->first = first;
        this->second = second;
    }
    void fill()
    {
        cout << "Введите катет А: ";
        first = GetKatet();
        cout << "Введите катет В: ";
        second = GetKatet();
    }
    void hipotenuse()
    {
        cout << "Гипотенуза равна: " << sqrt(first * first + second * second) << endl;
    }
};

int main()
{
    setlocale(LC_ALL, "rus");
    Rabochiy hipot;
    hipot.fill();
    hipot.hipotenuse();
    Rabochiy A(6, 8);
    A.hipotenuse();
}