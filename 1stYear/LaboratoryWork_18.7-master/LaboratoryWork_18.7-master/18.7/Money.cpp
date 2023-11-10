#include <iostream>
#include "Money.h"
using namespace std;

Money::Money()
{
    rub = 0;
    kop = 0;
}
Money::Money(long rub, int kop)
{
    this->rub = rub;
    this->kop = kop;
}
Money:: ~Money() {}
void Money::SetRub()
{
    long val;
    cout << "Введите рубли: ";
    cin >> val;
    while (val < 0)
    {
        cout << "Введите корректное число: ";
        cin >> val;
    }
    this->rub = val;
}
long Money::GetRub() { return rub; }
void Money::SetKop()
{
    int tmp;
    cout << "Введите копейки: ";
    cin >> tmp;
    while (tmp > 99 || tmp < 0)
    {
        cout << "Введите корректное число: ";
        cin >> tmp;
    }
    this->kop = tmp;
}
int Money::GetKop() { return kop; }
Money& Money::operator--()
{
    int a;
    cout << "Enter dop:  ";
    cin >> a;
    int tmp = rub * 100 + kop;
    tmp = tmp - a;
    Money m(rub, kop);
    rub = tmp / 100;
    kop = tmp % 100;
    return m;
}
bool operator==(const Money& t1, const Money& t2)
{
    return (t1.rub == t2.rub && t1.kop == t2.kop);
}
bool operator!=(const Money& t1, const Money& t2)
{
    return (!(t1.rub == t2.rub && t1.kop == t2.kop));
}
ostream& operator<<(ostream& out, const Money& t)
{
    return (out << t.rub << "," << t.kop);
}
istream& operator>>(istream& in, Money& t)
{
    cout << "Enter rub:  ";
    in >> t.rub;
    cout << "Enter kop:  ";
    in >> t.kop;
    return in;
}