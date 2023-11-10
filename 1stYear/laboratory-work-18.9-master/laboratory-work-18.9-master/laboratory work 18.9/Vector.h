#pragma once
#include<iomanip>
#include<iostream>
using namespace std;
class Vector
{
	int _size;
	int* data;
public:
	Vector();
	Vector(int n);
	Vector(const Vector& vec);
	Vector(int s, int* m);
	~Vector();

	int size();
	const Vector& operator-(const Vector& v);
	const Vector& operator=(const Vector& v);
	int operator[](int i);
	const Vector&  operator*(const int k);
	Vector operator--();

	friend ostream& operator<< (ostream& out, const Vector& tmp);
	friend istream& operator>>(istream& in, Vector& tmp);
};