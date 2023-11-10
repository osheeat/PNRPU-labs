#include <iostream>
#include <vector>
#include <string>
#include <list>
#include <ctime>
#include <cmath>
#include<algorithm>

using namespace std;

struct Date
{
	int Day, Month, Year;
};
struct Human
{
	string FIO;
	long long PhoneNumber;
	Date DateofBirth;


	void Print()
	{
		cout << "=============================================" << endl;
		cout << "ФИО: " << FIO << endl;
		cout << "Дата рождения: " << DateofBirth.Day << "." << DateofBirth.Month << "." << DateofBirth.Year << endl;
		cout << "Номер телефона: " << PhoneNumber << endl;
	}
	void CreateData()
	{
		string names[] = { "Геннадий", "Максим", "Вячеслав", "Алексей", "Дмитрий" };
		string surnames[] = { "Иванов", "Максимов", "Петров", "Алексеев", "Сидоров" };
		string otchestvoes[] = { "Игоревич", "Александрович", "Юрьевич", "Николаевич", "Сергеевич" };

		FIO = surnames[rand() % 5] + " " + names[rand() % 5] + " " + otchestvoes[rand() % 5];
		DateofBirth.Day = 1 + rand() % 31;
		DateofBirth.Month = 1 + rand() % 12;
		DateofBirth.Year = 1950 + rand() % 71;
		PhoneNumber = 89000000000 + rand() * 30000 + rand() % 10000;
	}
};

vector<Human> CreateArray(int size)
{
	vector<Human> res;
	srand(time(0));
	for (int i = 0; i < size; i++)
	{
		Human newEl;
		newEl.CreateData();
		res.push_back(newEl);
	}
	cout << "Структура создана" << endl;
	return res;
}
void PrintArray(vector<Human> humans)
{
	if (humans.size() < 1)
	{
		cout << "Список пуст:" << endl;
		return;
	}
	for (int i = 0; i < humans.size(); i++)
	{
		humans[i].Print();
		cout << "Номер человека " << i + 1 << endl << endl;
	}
}
int getCorrectNumber()
{
	int num;
	cout << "Введите размер:  ";
	while (!(cin >> num) || (cin.peek() != '\n') || num < 0)
	{
		cin.clear();
		while (cin.get() != '\n');
		cout << "Введите корректное число: ";
	}
	return num;
}

int HashFunc(long long  n, int size)
{
	return n % size;
}
struct Cell
{
	int Number;
	Human Element;

	Cell(int n, Human h)
	{
		Number = n;
		Element = h;
	}
};
bool Comp(Cell c1, Cell c2)
{
	return c1.Number < c2.Number;
}
vector<Cell> SortElements(vector<Cell> collection)
{
	sort(collection.begin(), collection.end(), Comp);
	return collection;
}
vector<Cell> CreateHashTable(vector<Human> humans)
{
	vector<Cell> hashTable;
	for (int i = 0; i < humans.size(); i++)
	{
		int key = HashFunc(humans[i].PhoneNumber, humans.size());

		bool isFind = true;
		while (isFind)
		{
			isFind = false;
			for (int j = 0; j < hashTable.size() && !isFind; j++)
			{
				isFind = hashTable[j].Number == key;
			}
			if (isFind) key++;
		}
		hashTable.push_back(Cell(key, humans[i]));
	}
	return SortElements(hashTable);
}

void PrintHashTable(vector<Cell> hashTable)
{
	for (int i = 0; i < hashTable.size(); i++)
	{
		hashTable[i].Element.Print();
		cout  << "Номер в таблице: " << hashTable[i].Number  << endl;
		cout << "Значение хеша: " << HashFunc(hashTable[i].Element.PhoneNumber, hashTable.size()) << endl;
		cout << endl;
	}
}

int FindElement(vector<Cell> hashTable, long long key)
{
	int ind = -1;
	for (int i = 0; i < hashTable.size() && ind == -1; i++)
	{
		ind = HashFunc(hashTable[i].Element.PhoneNumber, hashTable.size()) == HashFunc(key, hashTable.size()) ? i : -1;
	}
	if (ind == -1) return ind;

	bool isFind = false;
	for (int i = ind; i < hashTable.size() && !isFind; i++)
	{
		if (hashTable[i].Element.PhoneNumber == key)
		{
			ind = i;
			isFind = true;
		}
	}

	if (!isFind) return -1;
	return ind;
}

int main()
{
	setlocale(LC_ALL, "rus");
	int size;
	size = getCorrectNumber();

;	vector<Human>humans;
	humans = CreateArray(size);

	vector<Cell> hashTable = CreateHashTable(humans);
	PrintHashTable(hashTable);

	long long key;
	cout << endl << "Введите номер телефона для поиска: ";
	cin >> key;

	int ind = FindElement(hashTable, key);
	if (ind != -1)
	{
		cout << "Элемент найден" << endl;
		hashTable[ind].Element.Print();
	}
	else
	{
		cout << "Элемент не найден" << endl;
	}
}