#include <iostream>
#include<stack>
#include<vector>
using namespace std;
char elem;
//without STL-functions
struct Stack
{
	char data;
	Stack* prev, *next;
};
Stack* createStack(int size)
{
	if (size == 0) return NULL;
	Stack* last, * p;
	last = NULL;
	p = new Stack;
	cout << "Введите 1 элемент:\t";
	cin >> elem;
	p->data = elem;
	p->next = NULL;
	last = p;
	for (int i = 2; i <= size; i++)
	{
		Stack* h = new Stack;
		p->next = h;
		p = p->next;
		cout << "Введите " << i << " элемент:\t";
		cin >> p->data;
		p->next = NULL;
	}
	return last;
}
void PrintStack(Stack*& last)
{
	if (last == NULL)
		cout << "Стек пуст" << endl;
	else {
		Stack* p = last;
		while (p != NULL)
		{
			cout << p->data << " ";
			p = p->next;
		}
		cout << endl;
	}
}
int PopST(Stack*& last)
{
	Stack* p = last;
	int k = 0;
	while (p != NULL)
	{
		k++;
		p = p->next;
	}
	p = last;
	if (k == 1)
	{
		int tmp = last->data;
		delete p;
		last = NULL;
		return tmp;
	}
	else
	{
		Stack* t = p->next;
		int u = p->data;
		last = t;
		delete p;
		return u;
	}
}
Stack* PushST(Stack*& last, int el)
{
	Stack* p = new Stack;
	p->data = el;
	p->next = last;
	last = p;
	return last;
}
void Addelement(int size, Stack*& last)
{
	Stack* mystack2 = createStack(0);
	char key;
	int number;
	cout << "Введите номер, после которого хотите добавить элемент: ";
	cin >> number;
	while (number > size || number < 1) {
		cout << "Введите номер, после которого хотите добавить элемент: ";
		cin >> number;
	}
	for (int i = 0; i < size - number; i++)
	{
		char t = PopST(last);
		PushST(mystack2, t);
	}
	for (int i = 0; i < 1; i++)
	{
		cout << "Введите новый элемент: ";
		cin >> key;
		PushST(last, key);
	}
	for (int i = 0; i < size - number; i++)
	{
		char t = PopST(mystack2);
		PushST(last, t);
	}
}


//STL-functions
stack<char> CreateStackSTL(int size)
{
	char element;
	stack<char> res;
	for (int i = 0; i < size; i++)
	{
		cout << "Введите " << i + 1 << " элемент: ";
		cin >> element;
		res.push(element);
 	}
	return res;
}
void PrintSTL(stack<char>st)
{
	stack<char> t;
	while (!st.empty())
	{
		t.push(st.top());
		st.pop();
	}
	while (!t.empty())
	{
		cout << t.top() << " ";
		t.pop();
	}
	cout << endl;
}
void AddElementSTL(stack<char>st)
{
	stack<char>copy;
	char key; int number;
	cout << "Введите номер, после которого хотите добавить элемент: ";
	cin >> number;
	while (number <1 || number > st.size())
	{
		cout << "Введите номер корректно: ";
		cin >> number;
	}
	for (int i = 0; i < number; i++)
	{
		copy.push(st.top());
		st.pop();
	}
	cout << "\nВведите новый элемент: ";
	for (int i = 0; i < 1; i++)
	{
		cin >> key;
		st.push(key);
	}
	for (int i = 0; i <number; i++)
	{
		st.push(copy.top());
		copy.pop();
	}
	PrintSTL(st);
}

int GetSize()
{
	int n;
	cin >> n;
	if (n < 1)
	{
		cout << "Введите корректное число: ";
		cin >> n;
	}
	return n;
}
int main()
{
	setlocale(LC_ALL, "rus");
	//without stl
	int size;
	cout << "Введите размер стека: ";
	size = GetSize();
	Stack* mystack = createStack(size);
	cout << "Ваш стек: ";
	PrintStack(mystack);
	Addelement(size, mystack);
	cout << "Ваш стек с добавленным элементом:" << endl;
	PrintStack(mystack);
	//stl
	int stlsize;
	cout << "Введите размер стека: ";
	stlsize = GetSize();
	stack<char>stackstl = CreateStackSTL(stlsize);
	PrintSTL(stackstl);
	AddElementSTL(stackstl);
	system("pause");
}