#pragma once
#include<iostream>
#include "Vector.h"
#include"Magazine.h"
using namespace std;
	Vector::Vector()
	{
		beg = nullptr;
		cur = 0;
		size = 0;
	}

	Vector::Vector(int n)
	{
		beg = new Object * [n];
		cur = 0;
		size = n;
	}

	Vector::~Vector()
	{
		if (beg != 0) delete[] beg;
		beg = 0;
	}
	//METHODS
	void Vector::Add()
	{
		if (size == 0)
		{
			cout << "size=0!" << endl;
			return;
		}
		if (size == cur)
		{
			cout << "error!" << endl;
			return;
		}
		Object* o;
		cout << "1. PRINT" << endl;
		cout << "2. Magazine" << endl;
		int y;
		cin >> y;
		if (y == 1)
		{
			PRINT* t = new PRINT;
			t->Input();
			o = t;
		}
		else
		{
				Magazine* t = new Magazine;
				t->Input();
				o = t;
		}
		if (cur < size)
		{
			beg[cur] = o;
			cur++;
		}
	}

	int Vector::operator() () { return cur; }

	void Vector::Show()
	{
		if (cur == 0)
		{
			cout << "Empty" << endl;
		}
		else 
		{ 
			Object** p = beg;
			for (int i = 0; i < cur; i++)
			{
				(*p)->Show();
				p++;
			}
		}
	}

	void Vector::ShowNames()
	{
		if (cur == 0)
		{
			cout << "Empty" << endl;
		}
		else
		{
			Object** p = beg;
			for (int i = 0; i < cur; i++)
			{
				(*p)->ShowNames();
				p++;
			}
		}
	}

	void Vector::Del()
	{
		if (size == 0)
		{
			cout << "Vector is empty!" << endl;
		}
		if (cur > 0)
			cur--;
	}