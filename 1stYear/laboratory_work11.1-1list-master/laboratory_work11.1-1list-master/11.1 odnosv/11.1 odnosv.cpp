#include <iostream>
using namespace std;

struct List
{
	char data;
	List* next;
};
int getSize()
{
	int num;
	cin >> num;
	while (num<1)
	{
		cout << "Введите корректное число: ";
		cin >> num;
	}
	return num;
}
//STRUCT-REALIZATION
List* make(int size)
{
	if (size == 0)
	{
		cout << "Список не может существовать!" << endl;
		return 0;
	}
	List* first, * p;
	first = NULL;
	cout << "Введите 1 элемент:\t";
	p = new List;
	cin >> p->data;
	first = p;
	for (int i = 2; i <= size; i++)
	{
		List* h = new List;
		p->next = h;
		p = p->next;
		cout << "Введите " << i << " элемент:\t";
		cin >> p->data;
		p->next = NULL;
	}
	return first;
}
void print(List* first)
{
	if (first == NULL)
	{
		cout << "Список пуст" << endl;
	}
	else
	{
		List* p = first;
		while (p != 0)
		{
			cout << p->data << " ";
			p = p->next;

		}
		cout << endl;
	}
}
void add(List*& first)
{
	if (first == NULL) return;
	List* p = first;
	int size = 0;
	while (p != NULL)
	{
		p = p->next;
		size++;
	}
	p = first;
	int pos;
	cout << "Введите номер элемента, после которого хотите добавить элемент:\t";
	cin >> pos;
	while (pos > size || pos < 1)
	{
		cout << "Введите корректное число: ";
		cin >> pos;
	}
	for (int i = 1; i < pos; i++)
	{
		p = p->next;
	}
	List* h = new List;
	h->next = p->next;
	p->next = h;
	p = p->next;
	cout << "Введите новый элемент:\t";
	cin >> p->data;

}

int main()
{
	system("chcp 1251 > null");
	setlocale(LC_ALL, "rus");

	int size;
	cout << "Введите размер списка\t";
	size = getSize();
	List* list = make(size);

	cout << "Ваш список:" << endl;
	print(list);

	add(list);
	cout << "Ваш список с добавленным номером:" << endl;
	print(list);
	system("pause");
}