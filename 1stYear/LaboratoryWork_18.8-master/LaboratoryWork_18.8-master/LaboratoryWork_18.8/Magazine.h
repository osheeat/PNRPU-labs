#pragma once
#include"Print.h"
class Magazine : public PRINT
{
public:
	Magazine(void);
public:
	~Magazine(void);
	void Show();
	void ShowNames();
	void Input();
	Magazine(string, string, int);
	Magazine(const Magazine&);
	int GetPages() {return pages;}
	void SetPages(int);
	Magazine& operator= (const Magazine& );
protected:
	int pages;
};