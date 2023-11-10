#include"Object.h"
#include"Magazine.h"
class Vector
{
public:
	Vector();
	Vector(int);
	~Vector(void);
	void Add();
	void Del();
	void Show();
	void ShowNames();
	int operator ()();
protected:
	Object** beg;
	int size;
	int cur;
};