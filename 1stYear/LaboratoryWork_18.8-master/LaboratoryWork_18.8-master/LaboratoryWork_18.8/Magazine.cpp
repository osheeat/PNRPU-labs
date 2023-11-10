#include "Magazine.h"
Magazine::Magazine(void) : PRINT()
{
	pages = 0;
}

Magazine::~Magazine(void) {}

Magazine::Magazine(string A, string N, int P) : PRINT(A, N)
{
	pages = P;
}

Magazine::Magazine(const Magazine& M)
{
	author = M.author;
	name = M.name;
	pages = M.pages;
}

void Magazine::SetPages(int P)
{
	pages = P;
}

Magazine& Magazine::operator= (const Magazine& m)
{
	if (&m == this) return *this;
	author = m.author;
	name = m.name;
	return *this;
}

void Magazine::Show()
{
	cout << "Author:  " << author << endl;
	cout << "Name:  " << name << endl;
	cout << "Pages:  " << pages << endl;
}

void Magazine::ShowNames()
{
	cout << "Name:  " << name << endl;
}

void Magazine::Input()
{
	cout << "Enter author:  "; cin >> author;
	cout << "\nEnter name:  "; cin >> name;
	cout << "\nEnter pages:  "; cin >> pages;
	cout << endl;
}