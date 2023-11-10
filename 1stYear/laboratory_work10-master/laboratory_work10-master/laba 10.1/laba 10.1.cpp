#include <iostream>
#include <vector>
#include <string>
using namespace std;


void fillarray(vector<string> &Array, int size)
{
	for (int i = 0; i < size; i++)
	{
		cout << "Введите " << i + 1 << " - ю строку:" << endl;
		getline(cin, Array[i]);
	}
}
void printarray(vector<string> Array, int size)
{
	for (int i = 0; i < size; i++)
		cout << Array[i] << endl;
}
int getCorrectNumber()
{
	int num;
	while (!(cin >> num) || (cin.peek() != '\n') || num < 0)
	{
		cin.clear();
		while (cin.get() != '\n');
		cout << "Введите корректное число: ";
	}
	return num;
}


int main()
{
	setlocale(LC_ALL, "ru");
	system("chcp 1251 > null");

	int size;
	
	cout << "Введите кол-во строк: \t";
	size = getCorrectNumber();

	vector<string> Array(size);
	cin.ignore();
	fillarray(Array, size);
	cout << "Ваши строки: " << endl;
	printarray(Array, size);

	cout << endl << "__________________________________________________" << endl;
	
	int NumberofRow;
	cout << "Введите номер строки которую необходимо удалить: \t";
	cin >> NumberofRow;
	while (NumberofRow > size || NumberofRow < 1)
	{
		cout << "Введите строку корректно: \t";
		cin >> NumberofRow;
	}
	cout << endl;

	Array.erase (Array.begin() + NumberofRow-1);//удаление выбранной строки
	cout << "Ваши строки без " << NumberofRow << "-ой (-ей) строки:" << endl;
	printarray(Array, size-1);
}
