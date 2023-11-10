#pragma once
#include<iostream>
using namespace std;
class Iterator
{
	int* elem;
	friend class Vector;
public:
	Iterator()
	{
		elem = 0;
	};

	Iterator(const Iterator& it)
	{
		elem = it.elem;
	}

	bool operator ==(const Iterator& it) { return elem == it.elem; }
	bool operator !=(const Iterator& it) { return elem != it.elem; };

	void operator ++() { ++elem; };
	void operator --() { --elem; }

	int& operator*() const { return *elem; };
};


class Vector
{
	int *data;
	int _size;
	Iterator beg, end;

public:
	Iterator first() { return beg; }
	Iterator last() { return end; }

	//construct and destruct
	Vector()
	{
		data = 0;
		_size = 0;
	}
	Vector(int n)
	{
		_size = n;
		data = new int[_size];
		for (int i = 0; i < _size; i++)
			data[i] = 0;
		beg.elem = &data[0];
		end.elem = &data[_size - 1];
	}
	Vector(const Vector& vec)
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
		beg = vec.beg;
		end = vec.end;
	}

	Vector(int i, int k)
	{
		_size = i;
		data = new int[_size];
		for (int i = 0; i < _size; i++)
			data[i] = k;

		beg.elem = &data[0];
		end.elem = &data[_size-1];
	}

	~Vector()
	{
		delete[] data;
		data = 0;
	}
	//METHODS

	int size() { return _size; }

	Vector& operator=( Vector& a)
	{
		delete[] data;
		_size = a.size();
		if (data != 0) delete[] data;
		data = new int[_size];
		for (int i = 0; i < _size; i++)
		{
			data[i] = a.data[i];
		}
		return *this;

		beg = a.beg;
		end = a.end;
		return *this;
	}

	int& operator[] (int index)
	{
		if (index < _size) return data[index];
		else cout << "\nError index > _size!!" << endl;
	}

	Vector& operator*(const int k)
	{
		Vector tmp(_size, k);
		for (int i = 0; i < _size; i++)
			tmp.data[i] = data[i] * k;
		return tmp;
	}

	Vector& operator-(Vector& tmp)
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
	friend ostream& operator<< (ostream& out, const Vector& tmp)
	{
		for (int i = 0; i < tmp._size; i++)
			out << tmp.data[i] << "  ";
		return out;
	}
	 friend istream& operator>>(istream& in, Vector& tmp)
	{
		for (int i = 0; i < tmp._size; i++)
		{
			cout << "Введите " << i + 1 << " элемент:  ";
			in >> tmp.data[i];
			
		}
		return in;
	}
};