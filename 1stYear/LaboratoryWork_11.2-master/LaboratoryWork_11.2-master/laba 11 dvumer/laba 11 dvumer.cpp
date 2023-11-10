#include <iostream>
#include<list>
#include<iterator>
using namespace std;

//STL-REALIZATION
list<int>mylist;
void fillListSTL (int size)
{
	int tmp;
	cout << "Ваш список на " << size << " элементов:" << endl;
	for (int i = 0; i < size; i++)
	{
		cout << "Введите " << i + 1 << " Элемент:\t";
		cin >> tmp;
		mylist.push_back(tmp);
	}
}
void PrintlistSTL()
{
	list <int> ::iterator startpos = mylist.begin();
	list <int> ::iterator endpos = mylist.end();
	int i = 0;
	cout << "Ваш список через STL:" << endl;
	for (startpos; startpos != endpos; startpos++)
	{
		cout << *startpos << " ";
		i++;
	}
	cout << endl;
}

void DeleteSTL(list<int>l)
{
	list<int>tmp;
	list <int> ::iterator it = l.begin();
	for (int i = 1; i<=l.size(); i++)
	{
		if (i % 2 != 0)
		{
			tmp.push_back(*it);
			++it;
		}
		else
			it++;
	}

	list <int> ::iterator startpos = tmp.begin();
	list <int> ::iterator endpos = tmp.end();
	int i = 0;
	cout << "Ваш список без четных элементов:" << endl;
	for (startpos; startpos != endpos; startpos++)
	{
		cout << *startpos << " ";
		i++;
	}
	cout << endl;
}

//STRUCT-REALIZATION
struct spisok
{
	int data;
	spisok* next;
	spisok* prev;
};
spisok* make(int size)
{
	spisok* first, * p;
	first = NULL;
	p = new spisok;
	cout << "Введите 1 элемент:\t";
	cin >> p->data;
	first = p;
	p->next = NULL;
	p->prev = NULL;
	for (int i = 2; i <= size; i++)
	{
		spisok* h = new spisok;
		spisok* q = p;
		p->next = h;
		p = p->next;
		cout << "Введите " << i << " элемент:\t";
		cin >> p->data;
		p->next = NULL;
		p->prev = q;
	}
	return first;
}
void print(spisok* first)
{
	if (first == NULL)
	{
		cout << "Список пуст " << endl;
	}
	else 
	{
		spisok* p = first;
		while (p != NULL)
		{
			cout << p->data << " ";
			p = p->next;
		}
		cout << endl;
	}
}
void DeleteElements(spisok*& first, int size)
{

	spisok* tmp = first;
	int i = 1;
	while (tmp != nullptr) 
	{
		if (i % 2 == 0) 
		{
			if (tmp->next == nullptr) 
			{
				spisok* tmp2 = tmp->prev;
				delete tmp;
				tmp2->next = 0;
				tmp = tmp2;
			}
			else 
			{
				spisok* tmp2 = tmp->prev; 
				spisok* tmp3 = tmp->next;
				delete tmp;
				tmp2->next = tmp3;
				tmp3->prev = tmp2;
				tmp = tmp3;
			}
		}
		else 
		{
			tmp = tmp->next;
		}
		i++;
	}

}

int main()
{
	setlocale(LC_ALL, "rus");
	int size;
	cout << "Введите размер списка, реализованного через STL:\t";
	cin >> size;
	fillListSTL(size);
	PrintlistSTL();
	DeleteSTL(mylist);

	cout << "Введите элементы списка, реализованного через структуру" << endl;
	spisok* list = make(size);
	cout<< endl << "Ваш список:" << endl;
	print(list);
	DeleteElements(list, size);
	cout << "Список без элементов с четным номером:" << endl;
	print(list);
	system("pause");
}
