#include <iostream>
#include <string>
#include <vector>
using namespace std;

int getCorrectNumber()
{
	unsigned int num;
	while (!(cin >> num) || (cin.peek() != '\n') || num < 0)
	{
		cin.clear();
		while (cin.get() != '\n');
		cout << "Введите корректное число: ";
	}
	return num;
}

struct Auto
{
	int year;
	string marka;
	int regnum;
	int sernum;


	void fill()
	{
		cout << "Введите год выпуска:\t";
		cin >> year;
		cout << "Введите регистрационный номер:\t";
		cin >> regnum;
		cout << "Введите серийный номер:\t";
		cin >> sernum;
		cout << "Введите марку машины:\t";
		cin.ignore();
		getline(cin, marka);
		cout << "======================" << endl << endl;
	}
	void print()
	{
		cout << "\n Год выпуска: \t\t" << year;
		cout << "\n Серийный номер: \t" << sernum;
		cout << "\n Регистрационный номер:\t" << regnum;
		cout << "\n Марка: \t\t" << marka << endl;
	}
};


int main()
{
	system("chcp 1251 > null");
	setlocale(LC_ALL, "rus");


	vector <Auto> myvec;

	int size;
	cout << "Введите кол-во машин:\t";
	size=getCorrectNumber();

	for (int i = 0; i < size; i++)   //fill struct
	{
		myvec.push_back(Auto());
		myvec[i].fill();
	}

	cout << "Ваша структура:" << endl; 
	for (int i = 0; i < size; i++)   // print struct
	{
		myvec[i].print();
	}
	cout << "======================" << endl;


	cout << "Структура без первых 3 элементов: " << endl; //remove first 
	myvec.erase(myvec.begin(), myvec.begin() + 3); // 3 elements
	for (int i = 0; i < myvec.size(); i++)
	{
		myvec[i].print();
	}


	int number;
	cout << "Введите какой-нибудь регистрационный номер:\t";   // fill extra regnum
	cin >> number;
	for (int i = 0; i < myvec.size(); i++)
	{
		if (myvec[i].regnum == number)
		{
			myvec.insert(myvec.begin() + i + 1, Auto());
			myvec[i + 1].fill();
		}
	}
	cout << "======================" << endl;


	cout << "Структура с добавленным элементом после введенного регистрационного номера: " << endl;   //print last struct
	for (int i = 0; i < myvec.size(); i++)
	{
		myvec[i].print();
	}
	return 0;
}