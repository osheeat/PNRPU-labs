#include <iostream>
#include"Object.h"
using namespace std;

class PRINT : public Object
{
public:
	PRINT(void);
public:
	virtual ~PRINT(void);
	void Show();
	void ShowNames();
	void Input();
	PRINT(string, string);
	PRINT(const PRINT&);
	// selecters
	string GetAuthor() { return author; }
	string GetName() { return name; }
	//modificators
	void SetAuthor(string);
	void SetName(string);
	PRINT& operator=(const PRINT&);
protected:
	string author, name;
};