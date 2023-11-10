#pragma once
#include "Data.h"
#include "Triad.h"
#include <iostream>
using namespace std;

int CorrectDay()
{
    int d;
    cout << "enter day:  ";
    cin >> d;
    while (d > 31 || d < 1)
    {
        cout << "enter correct day!  ";
        cin >> d;
    }
    return d;
}
int CorrectMonth()
{
    int m;
    cout << "enter month:  ";
    cin >> m;
    while (m > 12 || m < 1)
    {
        cout << "enter correct month!  ";
        cin >> m;
    }
    return m;
}
int CorrectYear()
{
    int y;
    cout << "enter year:  ";
    cin >> y;
    while (y > 2021 || y < 1)
    {
        cout << "enter correct year!  ";
        cin >> y;
    }
    return y;
}

int main()
{
    setlocale(LC_ALL, "rus");
    Triad A(0,1,1);
    A.SetFirst(777);
    A.SetSecond(666);
    A.SetThird(333);
    A.Show();

    //entering date
    int day, month, year;
    day = CorrectDay();
    month = CorrectMonth();
    year = CorrectYear();

    //print class Date
    Date D(32, 13, 2022);
    D.IncreaseFirst();
    D.IncreaseSecond();
    D.IncreaseThird();
    Date C(day, month, year);
    C.PrintInf();
    cout << "=============================" << endl;
    //change data
    int n;
    cout << "Введите кол-во дней, на которое хотите изменить дату:  ";
    cin >> n;
    C.ChangeData(n);
    C.PrintInf();
}