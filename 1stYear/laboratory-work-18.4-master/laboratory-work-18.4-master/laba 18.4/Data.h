#pragma once
#include "Triad.h"
#include <iostream>
using namespace std;

class Date : public Triad
{
	int day, month, year;
public:
	//constructors
	Date() : Triad(), day(0), month(0), year(0) {};
	Date(int d, int m, int y) : Triad(), day(d), month(m), year(y) {};
	Date(Triad t, int d, int m, int y) : Triad(t), day(d), month(m), year(y) {}

	void IncreaseFirst()
	{
		if (day + 1 > 31)
			cout << "error! day out of range!" << endl;
		else day++;
	}
	void IncreaseSecond()
	{
		if (month + 1 > 12)
			cout << "error! month out of range!" << endl;
		else month++;
	}
	void IncreaseThird()
	{
		if (year + 1 > 2021)
			cout << "error! year out of range!" << endl;
		else year++;
	}
	void PrintInf()
	{
		cout << "Day:\t" << day << endl;
		cout << "Month:\t" << month << endl;
		cout << "Year:\t" << year << endl;
	}

	void ChangeData(int n)
	{
		while (day + n > 31) 
		{
			month++;
			if (month > 12)
			{
				month = 1;
				year++;
			}
			n -= 31;
		}
		day = day + n;
	}

	~Date() {};
	void SetDay(int d) 
	{ 
		if (d > 31 || d < 1)
		{
			cout << "error! day out of range!" << endl;
		}
		else this->day = day; 
	};
	void SetMonth(int m) 
	{ 
		if (m > 12 || m < 1)
		{
			cout << "error! month out of range!" << endl;
		}
		this->month = m; 
	};
	void SetYear(int y) 
	{
		if (y > 2021 || y < 1)
		{
			cout << "error! year out of range!" << endl;
		}
		this->year = y; 
	};
	int GetDay() { return day; }
	int GetMonth() { return month; }
	int GetYear() { return year; }


	Date& operator=(Triad& t)
	{
		this->SetFirst(t.GetFirst());
		this->SetSecond(t.GetSecond());
		this->SetThird(t.GetThird());
		return *this;
	}
};