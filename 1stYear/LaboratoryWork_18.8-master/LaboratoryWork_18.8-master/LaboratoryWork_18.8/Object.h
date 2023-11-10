#pragma once
#include<iostream>
using namespace std;
class Object
{
public:
	Object(void);
	virtual void Show() = 0;
	virtual void Input() = 0;
	virtual ~Object(void);
	virtual void ShowNames() = 0;
};
