#pragma once
#include<iostream>
using namespace std;
class Money
{
    long rub;
    int kop;
public:
    Money();
    Money(long rub, int kop);
    ~Money();
    void SetRub();
    long GetRub();
    Money& operator--();
    void SetKop();
    int GetKop();
    friend bool operator==(const Money& t1, const Money& t2);
    friend bool operator!=(const Money& t1, const Money& t2);
    friend ostream& operator<<(ostream& out, const Money& t);
    friend istream& operator>>(istream& in, Money& t);
};