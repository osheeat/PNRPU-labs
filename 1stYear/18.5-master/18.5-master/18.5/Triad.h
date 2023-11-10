#pragma once
#include "Object.h"
#include <iostream>
using namespace std;
class Triad : public Object
{
    int first;
    int second;
    int third;
public:
    //constructors
    Triad();
    Triad(int d, int m, int y);
    Triad(const Triad& t);
    //destructor
    ~Triad() {};
    //Getter and Setters
    void SetFirst(int f);
    void SetSecond(int s);
    void SetThird(int t);
    int GetFirst();
    int GetSecond();
    int GetThird();

    void PrintInf();
    void IncreaseFirst();
    void IncreaseSecond();
    void IncreaseThird();


    Triad& operator=(Triad& t);
    friend istream& operator >> (istream& cin, Triad& t);
    friend ostream& operator << (ostream& cout, Triad& t);
};