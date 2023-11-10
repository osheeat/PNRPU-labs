#include "Data.h"
#include "Triad.h"
#include <iostream>
using namespace std;
Triad::Triad() { first = 0; second = 0; third = 0; }
Triad::Triad(int f, int s, int t) {
this->first = f; 
this->second = s; 
this->third = t;
}
Triad::Triad(const Triad& t) 
{
	first = t.first;
	second = t.second;
	third = t.third; 
}
void Triad::SetFirst(int f) 
{ this->first = f; }
void Triad::SetSecond(int s) 
{ this->second = s; }
void Triad::SetThird(int t) 
{ this->third = t; }
int Triad::GetFirst() 
{ return first; }
int Triad::GetSecond() 
{ return second; }
int Triad::GetThird() 
{ return third; }
//methods
void Triad::Show()
{
	cout << "First:  " << first << endl;
	cout << "Second:  " << second << endl;
	cout << "Third:  " << third << endl;
}
void Triad::IncreaseFirst()
{
	first++;
}
void Triad::IncreaseSecond()
{
	second++;
}
void Triad::IncreaseThird()
{
	third++;
}

Triad& Triad :: operator = (Triad& t)
{
	if (this == &t)
		return *this;
	first = t.first;
	second = t.second;
	third = t.third;
}
istream& operator >> (istream& cin, Triad& t)
{
	cout << "enter first:  ";
	cin >> t.first;
	cout << "enter second:  ";
	cin >> t.second;
	cout << "enter third:  ";
	cin >> t.third;
	return cin;
}
ostream& operator << (ostream& cout, Triad& t)
{
	return (cout << "First:  " << t.first << endl << "Second:  " << t.second << endl << "Third:  " << t.third << endl);
}