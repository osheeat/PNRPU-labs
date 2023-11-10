#include "Money.h"
#include<iostream>
using namespace std;
Money::Money()
{
    rub = 0;
    kop = 0;
    dop = 0;
}

Money::Money(long rub, int kop)
{
    this->rub = rub;
    this->kop = kop;
    this->dop = dop;
}

Money:: ~Money() {}

void Money::SetRub()
{
    long val;
    cout << "¬ведите рубли: ";
    cin >> val;
    while (val < 0)
    {
        cout << "¬ведите корректное число: ";
        cin >> val;
    }
    this->rub = val;
}

long Money::GetRub() { return rub; }

void Money::SetKop()
{
    int tmp;
    cout << "¬ведите копейки: ";
    cin >> tmp;
    while (tmp > 99 || tmp < 0)
    {
        cout << "¬ведите корректное число: ";
        cin >> tmp;
    }
    this->kop = tmp;
}

int Money::GetKop() { return kop; }

void Money::SetDop()
{
    int tmp1;
    cout << "¬ведите вычитаемые копейки: ";
    cin >> tmp1;
    while (tmp1 > 99 || tmp1 < 0)
    {
        cout << "¬ведите корректное число: ";
        cin >> tmp1;
    }
    this->dop = tmp1;
}

int Money::GetDop() { return dop; }

void Money::PrintClass()
{
    cout << "«начение: " << this->rub << "," << this->kop << endl;
}

void Money::GetRazn()
{
    if (kop >= dop)
        kop -= dop;
    else {
        rub--;
        kop = 100 + kop - dop;
    }
}

Money& Money::operator++()
{
    rub++;
    return *this;
}

Money& Money::operator++(int a)
{
    Money tmp(*this);
    this->rub++;
    return tmp;
}

ostream& operator<<(ostream& out,const Money& m)
{
    out << m.rub;
    out << ",";
    out << m.kop;
    return out;
}

istream& operator>>(istream& in, Money& m)
{
    in >> m.rub;
    in >> m.kop;
    return in;
}

fstream& operator>>(fstream& fin, Money& m)
{
    fin >> m.rub;
    fin >> m.kop;
    return fin;
}

 fstream& operator<<(fstream& fout,const Money& m)
{
    fout << m.rub << endl;
    fout << m.kop << endl;
    return fout;
}

 bool Money::operator!=(Money secondOperand)
 {
     return rub != secondOperand.rub && kop != secondOperand.kop;
 }
