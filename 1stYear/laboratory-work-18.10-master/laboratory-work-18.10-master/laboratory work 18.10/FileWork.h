#pragma once
#include"Money.h"
#include<fstream>
#include <iomanip>
#include<iostream>
#include<string>
#include<vector>
using namespace std;

int MakeFile(const char* f_name)
{
	fstream stream(f_name, ios::out | ios::trunc);
	
	if (!stream) return -1;
	int n;
	cout << "Введите количество элементов:  ";
	cin >> n;
	vector<Money> m(n);
	for (int i = 0; i < m.size(); i++)
	{
		m[i].SetRub();
		m[i].SetKop();
		stream << m[i] << endl;
	}
	stream.close();
	return n;
}

int PrintFile(const char* f_name)
{
	fstream stream(f_name, ios::in);//orxpurs gna urenua
	if (!stream) return -1;//owmOxa ovxpurua patina

	vector<Money> m(10); int i = 0; 
	while (stream >> m[i])
	{
		m[i].PrintClass();
		i++;
	}
	stream.close();
	return i;
}

void DeleteElem(const char* f_name, int r, int k) 
{
	fstream temp("temp", ios::out);
	fstream stream(f_name, ios::in);
	while (!stream.eof())
	{
		Money m;
		stream >> m;
		// проверка на последнюю строку
		if (m != Money())
		{
			// проверка условия удаления элемента
			if (m.GetRub() <= r || m.GetKop() <= k)
			{
				temp << m;
			}
		}
	}

	stream.close();
	temp.close();
	remove(f_name);
	rename("temp", f_name);
}

int add_file(const char* f_name, int k, Money mm, int count)
{
fstream temp("temp", ios::out);//orxpuTs gna sanucu
fstream stream(f_name, ios::in);//orxpuTs gna urenua
if (!stream)return -1;//oumOxa orxpurua daiina
Money m; int i = 0, l = 0;
while (stream >> m)
{
	if (stream.eof()) break;
	i++;
	if (i == k)
	{
		for (int j = 0;j < count;j++) 
		{ 
			temp << mm;//sanucars = temp Hosyp sanuce
			l++;
		}
	}
temp << m;
}
stream.close(); temp.close();
remove(f_name);
rename("temp", f_name);
return l;
}

int add_end(const char* f_name, Money mm, int count)
{
	fstream stream(f_name, ios::app);
	if (!stream) return -1;
	for (int j = 0; j < count; j++)
		stream << mm;
	return 1;
}

int ChangeFile(const char* f_name, int r, int k)
{
	fstream temp("temp", ios::out);//orxpyTs ana 3anvucu
	fstream stream(f_name, ios::in);//orxpuTs ona urexua
	if (!stream) return -1;//oumOxa orxpurua gaiina

	Money m;
	int i = 0, l = 0;
	char x;
	while (stream >> m)
	{
		if (stream.eof()) break;
		i++;
		if (m.GetRub()==r && m.GetKop()==k)
		{
			cout << m << " - Меняется... Продолжить?[y/n]?\n";
			cin >> x;
			if (x == 'n' || x == 'N')
				break;
			if (m.GetKop() + 50 >= 100)
			{
				temp << m.GetRub() + 2 << endl;
				temp << m.GetKop() - 50 << endl;
			}
			else 
				temp << m.GetRub() + 1 << endl;
				temp << m.GetKop() + 50 << endl;
			i++;;
		}
		else
			temp << m;
	}
	stream.close(); temp.close();
	remove(f_name);
	rename("temp", f_name);
	return l;//xommuecTB0 msMeHeHHEX sneMeHTOR
}
