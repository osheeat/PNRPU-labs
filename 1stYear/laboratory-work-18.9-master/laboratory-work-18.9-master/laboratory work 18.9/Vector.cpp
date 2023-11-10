#pragma once
#include "Vector.h"
#include<iostream>
#include<iomanip>
using namespace std;
const int MAX_SIZE = 30;

	//construct and destruct
	Vector::Vector()
	{
		data = 0;
		_size = 0;
	}
	Vector::Vector(int n)
	{
		if (n > MAX_SIZE) throw 2;
		_size = n;
		data = new int[n];
		for (int i = 0; i < _size; i++)
			data[i] = 0;
	}
	Vector::Vector(const Vector& vec)
	{
		if (vec._size == 0)
			Vector();
		else
		{
			_size = vec._size;
			data = new int[_size];
			for (int i = 0; i < _size; i++)
				data[i] = vec.data[i];
		}
	}
	Vector::Vector(int s, int* m)
	{
		if (s > MAX_SIZE) throw 1;
		_size = s;
		data = new int[_size];
		for (int i = 0; i < _size; i++)
			data[i] = m[i];
	}
	Vector::~Vector()
	{
		if (data != 0) delete[]data;
	}

	//METHODS
	int Vector::size() 
	{
		return _size; 
	}

	const Vector& Vector::operator-(const Vector& a)
	{
		if (_size>a._size)
		{ 
			for (int i = 0; i < a._size; i++)
			{
				data[i] = data[i] - a.data[i];
			}
			return *this;
		}
		else
		{
			for (int i = 0; i < _size; i++)
			{
				data[i] = data[i] - a.data[i];
			}
		}
	}
	const Vector&Vector::operator =(const Vector& a)
	{
		if (this == &a)
			return *this;
		if (data != 0)
			delete[] data;
		data = new int[_size];
		for (int i = 0; i < _size; i++)
		{
			data[i] = a.data[i];
		}
		return *this;
	}
	int Vector:: operator[] (int index)
	{
		if (index < 0) throw 2;
		if (index >= _size) throw 3;
		return data[index];
	}
	const Vector&Vector:: operator*(const int k)
	{

		for (int i = 0; i < _size; i++)
			data[i] = data[i] * k;
		return *this;
	}
	Vector Vector:: operator--()
	{
		if (_size == 0) throw 5;
		if (_size == 1)
		{
			_size = 0;
			delete[] data;
			data = 0;
			return*this;
		}
			Vector temp(_size, data);
			delete[] data;
			_size--;
			data = new int[_size];
			for (int i = 0; i < _size; i++)
				data[i] = temp.data[i];
			return*this;
		
	}

	//overloads
	ostream& operator<< (ostream& out, const Vector& tmp)
	{
		for (int i = 0; i < tmp._size; i++) 
		{
			out << i + 1 << ")  ";
			out << tmp.data[i] << "  " << endl;
		}
		return out;
	}

	istream& operator>>(istream& in, Vector& tmp)
	{
		for (int i = 0; i < tmp._size; i++)
		{
			cout << "Введите " << i + 1 << " элемент вектора:  ";
			in >> tmp.data[i];
		}
		return in;
	}
