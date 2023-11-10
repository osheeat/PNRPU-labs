﻿#pragma once
#include<iostream>
#include "Money.h"
using namespace std;
template <class T>
class Vector
{
	T* data;
	int _size;
public:
	//construct and destruct
	Vector()
	{
		data = nullptr;
		_size = 0;
	}
	Vector(int size)
	{
		_size = size;
		data = new T[_size];
	}
	Vector(const Vector<T>& vec)
	{
		if (vec._size() == 0)
			Vector();
		else
		{
			_size = vec._size();
			data = new T[_size];
			for (int i = 0; i < _size; i++)
				data[i] = vec[i];
		}
	}
	Vector(int i, T k)
	{
		_size = i;
		data = new T[_size];
		for (int i = 0; i < _size; i++)
			data[i] = k;
	}
	~Vector()
	{
		delete[] data;
		data = nullptr;
		_size = 0;
	}
	//METHODS

	int size() { return _size; }
	Vector<T>& operator=(Vector<T>& tmp)
	{
		delete[] data;
		_size = tmp.size();
		data = new T[_size];
		for (int i = 0; i < _size; i++)
		{
			data[i] = tmp[i];
		}
		return *this;
	}
	T& operator[] (int index)
	{
		if (index < _size) return data[index];
		else cout << "\nError index > _size!!" << endl;
	}
	Vector<T>& operator * (T k)
	{
		Vector <T> tmp(_size, k);
		for (int i = 0; i < _size; i++)
			tmp.data[i] = data[i] * k;
		return tmp;
	}
	Vector<T>& operator-(Vector<T>& tmp)
	{
		if (_size >= tmp.size())
		{
			for (int i = 0; i < tmp.size(); i++)
			{
				data[i] = data[i] - tmp[i];
			}
		}
		else
		{
			for (int i = 0; i < _size; i++)
			{
				data[i] = data[i] - tmp[i];
			}
		}
		return *this;
	}
public:
	//ios overloads
	friend istream& operator>> <>(istream& in, Vector<T>& a);
	friend ostream& operator<< <>(ostream& out, const Vector<T>& a);
	friend ostream& operator<< (ostream& out, const Vector<Money>& tmp);
};
template <typename T>
istream& operator>>(istream& in, Vector<T>& tmp)
{
	for (int i = 0; i < tmp._size; i++)
	{
		cout << "Enter " << i + 1 << " element:" << endl;
		in >> tmp.data[i];
	}
	return in;
}
template <typename T>
ostream& operator<< <>(ostream& out, const Vector<T>& tmp)
{
	for (int i = 0; i < tmp._size; i++)
		out << tmp.data[i] << "  ";
	return out;
}
ostream& operator<< (ostream& out, const Vector<Money>& tmp)
{
	for (int i = 0; i < tmp._size; i++)
		out << "Count "<<i+1 <<" = " << tmp.data[i] << endl;
	return out;
}