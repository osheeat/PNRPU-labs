#pragma once
#include <iostream>
#include "Object.h"
using namespace std;	

class Vector 
{
	Object** startpos;
	int _size;
public:
	Vector()
	{
		startpos = nullptr;
		_size = 0;
	}
	Vector(int size)
	{
		startpos = new Object * [size];
		_size = size;
	}
	Vector(Vector& tmp)
	{
		if (startpos != nullptr)
			delete[] startpos;
		else
		{
			int size = tmp.size();
			startpos = new Object * [size];
			for (int i = 0; i < size; i++)
			{
				startpos[i] = tmp.startpos[i];
			}
		}
	}
	~Vector()
	{
		if (startpos != nullptr)
		{
			delete[] startpos;
			startpos = nullptr;
		}
	}
	//methods
	int size() { return _size; }
	void push_back(Object* value)
	{
		Object** tmp = new Object * [_size + 1];
		for (int i = 0; i < _size; i++)
		{
			tmp[i] = startpos[i];
		}
		tmp[_size] = value;
		delete[] startpos;
		startpos = tmp;
		tmp = nullptr;
		_size++;
	}
	//overloads;
	friend ostream& operator << (ostream& out, Vector& list);
};
ostream& operator << (ostream& out, Vector& list)
{
	if (list._size == 0)
		return out << "Empty" << endl;
	Object** tmp = list.startpos;
	for (int i = 0; i < list._size; i++)
	{
		out << i + 1 << " element of list:" << endl;
		(*tmp)->PrintInf();
		tmp++;
	}
	return out;
}