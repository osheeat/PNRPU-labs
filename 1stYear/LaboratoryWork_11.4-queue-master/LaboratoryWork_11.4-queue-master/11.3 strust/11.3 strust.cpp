#include <iostream>
#include<queue>
#include<vector>
using namespace std;

//реализация через структуру:
struct ochered
{
	int data;
	ochered* next;
};
ochered* make(int n, ochered*& first, ochered*& last)
{
	if (n == 0) return NULL;
	ochered* p = new ochered;
	int a;
	cout << "Введите 1 элемент очереди: ";
	cin >> a;
	p->data = a;
	p->next = NULL;
	first = p;
	last = p;
	for (int i = 2; i <= n; i++)
	{
		ochered* h = new ochered;
		cout << "Введите " << i << " элемент очереди: ";
		cin >> a;
		h->data = a;
		h->next = p;
		last = h;
		p = last;
	}
	return first;
}
void print(ochered* last)
{
	ochered* p = last;
	while (p != NULL)
	{
		cout << p->data << " ";
		p = p->next;
	}
	cout << endl;
}
int pop(ochered*&first, ochered*& last)
{
	ochered* p = last;
	int count = 0;
	while (p != NULL)
	{
		count++;
		p = p->next;
	}
	p = last;
	if (count == 1)
	{
		int t = last->data;
		delete p;
		last = NULL;
		first = NULL;
		return t;
	}
	else {
		while (p->next->next != NULL)
			p = p->next;
		ochered* t = p;
		int e = p->next->data;
		p = p->next;
		t->next = NULL;
		first = t;
		delete p;
		return e;
	}
}
ochered* push(int n, ochered*& last)
{
	ochered* p = new ochered;
	p->data = n;
	p->next = last;
	last = p;
	return last;
}
void deletelem (int size, ochered*& first, ochered*& last)
{
	int* mas = new int[size];
	int i = 0;
	while (i < size)
	{
		int t = pop(first, last);
		if (t % 2 != 0)
		{
			mas[i] = t;
			i++;
		}
		else 
			size--;
	}
	for (int i = 0; i < size; i++)
		push(mas[i], last);
}
//other
int getsize()
{
	int size;
	cin >> size;
	while (size < 1)
	{
		cout << "Введите размер корректно: ";
		cin >> size;
	}
	return size;
}
//STL-libraries
queue<int> CreateQueueSTL(int size)
{
	cout << "Заполнение очереди на " << size << " элементов" << endl;
	queue<int> res;
	int tmp;
	for (int i = 0; i < size; i++)
	{
		cout << "Введите элемент " << i + 1 << ": ";
		cin >> tmp;
		res.push(tmp);
	}
	return res;
}
void PrintQueueSTL(queue<int> qu)
{
	while (!qu.empty())
	{
		cout << qu.front() << " ";
		qu.pop();
	}
	cout << endl;
}
void DeleteSTL(queue<int> qu)
{
	queue<int>tmp;
	while (!qu.empty())
	{
		if (qu.front() % 2 == 0) 
			qu.pop();
		else 
		{
			tmp.push(qu.front());
			qu.pop();
		}
	}
	while (!tmp.empty())
	{
		qu.push (tmp.front());
		tmp.pop();
	}
	cout << "Ваша очередь без четных элементов:" << endl;
	while (!qu.empty())
	{
		cout << qu.front() << " ";
		qu.pop();
	}
	cout << endl;
}

int main()
{
	//Structttttttt
	setlocale(LC_ALL, "rus");
	int size;
	cout << "Введите размер очереди: ";
	size = getsize();
	ochered* first, * last;
	make(size, first, last);
	cout << "Ваша очередь:" << endl;
	print(last);
	deletelem(size, first, last);
	cout << "Ваша очередь без элементов с четным информационным полем:" << endl;
	print(last);

	//STL-libraries

	int sizeofSTL;
	cout << "Введите размер очереди, реализованной через STL - библиотеку: ";
	sizeofSTL = getsize();
	queue<int> myocher = CreateQueueSTL(sizeofSTL);
	cout << "Ваша очередь:" << endl;
	PrintQueueSTL(myocher);
	DeleteSTL(myocher);
	system("pause");
}