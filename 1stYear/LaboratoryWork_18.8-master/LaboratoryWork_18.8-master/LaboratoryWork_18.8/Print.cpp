#include "Print.h"
//construtor
PRINT::PRINT(void)
{
	author = "";
	name = "";
}
//destructor
PRINT::~PRINT(void) {}
//constructor w parametres
PRINT::PRINT(string a, string n)
{
	author = a;
	name = n;
}
//copy constructor
PRINT::PRINT(const PRINT& pr)
{
	author = pr.author;
	name = pr.name;
}

//setters
void PRINT::SetAuthor(string a)
{
	author = a;
}
void PRINT::SetName(string n)
{
	name = n;
}

PRINT& PRINT::operator= (const PRINT& p)
{
	if (&p == this) return *this;
	author = p.author;
	name = p.name;
	return *this;
}

void PRINT::Show()
{
	cout << "Author:  " << author << endl;
	cout << "Name:  " << name << endl;
}

void PRINT::ShowNames()
{
	cout << "Name:  " << name << endl;
}

void PRINT::Input()
{
	cout << "Enter author:  "; cin >> author;
	cout << "\nEnter name:  "; cin >> name;
	cout << endl;
}

