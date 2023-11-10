#include <iostream>
#include <string>
#include<fstream>
#include<vector>

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
		string names[] = { "Геннадий", "Максим", "Вячеслав", "Алексей", "Дмитрий"};
		string surnames[]= { "Иванов", "Максимов", "Петров", "Алексеев", "Сидоров"};
		string otchestvoes[] = {"Игоревич", "Александрович", "Юрьевич", "Николаевич", "Сергеевич" };

		FIO = surnames[rand() % 5] + " " + names[rand() % 5] + " " +  otchestvoes[rand() % 5];
		DateofBirth.Day = 1 + rand() % 31;
		DateofBirth.Month = 1 + rand() % 12;
		DateofBirth.Year = 1900 + rand() % 122;
		PhoneNumber = 89000000000 + rand()*30000 + rand() % 10000;
	}
};

vector<Human> CreateArray(int size = 100)
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
	for (int i = 0; i < humans.size(); i++)
	{
		humans[i].Print();
		cout << "Номер человека " << i + 1 << endl << endl;
	}
}
void SaveToFile(vector<Human> humans)
{
	string path = "database.txt";
	ofstream out = ofstream();
	out.open(path);
	for (int i = 0; i < humans.size(); i++)
	{
		out << humans[i].FIO << endl;
		out << humans[i].DateofBirth.Day << "." << humans[i].DateofBirth.Month << "." << humans[i].DateofBirth.Year << endl;
		out << humans[i].PhoneNumber << endl;
	}
	out.close();
	cout << "Ваша структура была скопирована в database.txt" << endl;
}
bool FindViaInterPolationSearch(vector<Human> humans, Date date)
{

	int key = date.Year * 10000 + date.Month * 100 + date.Day;
	vector<int> collection;
	for (int i = 0; i < humans.size(); i++)
	{
		collection.push_back(0);
		collection[i] = humans[i].DateofBirth.Year * 10000 + humans[i].DateofBirth.Month * 100 + humans[i].DateofBirth.Day;
	}

   
	for (int i = 1; i < collection.size(); i++)
	{
		int j = 0;
		while (collection[i] > collection[j] && j < i) j++;
		collection.insert(collection.begin() + j, collection[i]);
		collection.erase(collection.begin() + i);
	}


	int mid, left = 0, right = collection.size() - 1;

	while (collection[left] < key && collection[right] > key)
	{
		mid = left + (key - collection[left]) * (right - left) / (collection[right] - collection[left]);
		if (collection[mid] < key)
			left = mid + 1;
		else 
			if (collection[mid] > key)
			right = mid - 1;
		else return true;
	}

	if (collection[left] == key)
		return true;
	if (collection[right] == key)
		return true;

	return false;
}
int FindSubstringInString(vector<Human> humans, Date key)
{
	string listOfDates;
	string substring = "";

	if (key.Day < 10) substring += "0";
	substring += to_string(key.Day);
	if (key.Month < 10) substring += "0";
	substring += to_string(key.Month);
	if (key.Year < 10) substring += "0";
	substring += to_string(key.Year);

	for (int i = 0; i < humans.size(); i++)
	{
		string newLine = "";
		if (humans[i].DateofBirth.Day < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Day);
		if (humans[i].DateofBirth.Month < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Month);
		if (humans[i].DateofBirth.Year < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Year);
		listOfDates += newLine;
	}


	for (int i = 0; i <= listOfDates.size() - substring.size(); i++)
	{
		int j = 0;
		while (listOfDates[i + j] == substring[j] && j < substring.size())
			j++;
		if (j == substring.size())
			return i / 8;
	}
	return -1;
}
bool LineSearch(vector<Human>H, Date key)
{
	for (int i = 0; i < H.size(); i++)
	{
		if (H[i].DateofBirth.Day == key.Day && H[i].DateofBirth.Month == key.Month && H[i].DateofBirth.Year == key.Year)
			return true;
	}
	return false;
}

vector<int> Prefix(string str)
{
	vector<int> result(str.size());
	result[0] = 0;
	int j = 1, i = 0;
	while (j < str.size())
	{
		if (str[i] != str[j])
		{
			if (i == 0)
			{
				result[j] = 0;
				j++;
			}
			else
			{
				i = 0;
			}
		}
		else
		{
			result[j] = i + 1;
			i++;
			j++;
		}
	}
	return result;
}
int KMP(vector<Human> humans, Date key)
{
	string listOfDates;
	string substring;

	if (key.Day < 10)
		substring += "0";
	substring += to_string(key.Day);
	if (key.Month < 10)
		substring += "0";
	substring += to_string(key.Month);
	if (key.Year < 10)
		substring += "0";
	substring += to_string(key.Year);

	for (int i = 0; i < humans.size(); i++)
	{
		string newLine = "";
		if (humans[i].DateofBirth.Day < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Day);
		if (humans[i].DateofBirth.Month < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Month);
		if (humans[i].DateofBirth.Year < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Year);
		listOfDates += newLine;
	}


	vector <int> pi = Prefix(substring);
	int k = 0, l = 0;
	while (k < listOfDates.size())
	{
		if (substring[l] == listOfDates[k])
		{
			k++;
			l++;
			if (l == substring.size()) return k / 8;
		}
		else
		{
			if (l == 0)
			{
				k++;
			}
			else l = pi[l - 1];
		}
	}
	return -1;
}
string Reverse_str(string str)
{
	string result;
	for (int i = str.size() - 1; i >= 0; i--)
	{
		result.push_back(str[i]);
	}
	return result;
}
int BMSearch(vector<Human> humans, Date key)
{
	string listOfDates;
	string substring;
	////////////////////////////////////////
	if (key.Day < 10) substring += "0";
	substring += to_string(key.Day);
	/////////////////////////////////////// 
	if (key.Month < 10) substring += "0";
	substring += to_string(key.Month);
	///////////////////////////////////////
	if (key.Year < 10) substring += "0";
	substring += to_string(key.Year);
	///////////////////////////////////////
	for (int i = 0; i < humans.size(); i++)
	{
		string newLine = "";
		if (humans[i].DateofBirth.Day < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Day);
		if (humans[i].DateofBirth.Month < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Month);
		if (humans[i].DateofBirth.Year < 10) newLine += "0";
		newLine += to_string(humans[i].DateofBirth.Year);
		listOfDates += newLine;
	}

	vector<int> shiftarray(substring.size());
	string substring_reverse_copy = Reverse_str(substring);
	int count = 0;
	for (int i = 0; i < substring.size(); i++)
	{
		shiftarray[i] = substring_reverse_copy.find(substring[i]) + 1;
		if (substring[i] == substring[substring.size() - 1]) count++;
		if (i == substring.size() - 1)
		{
			if (count == 1)
			{
				shiftarray[substring.size() - 1] = substring.size();
			}
			else
			{
				int pos = substring.size() - 1;
				shiftarray[pos] = substring_reverse_copy.find(substring[pos]) + 1;
			}
		}
	}

	cout << "Массив сдвигов для строки " << substring << " :" << endl;
	for (int i = 0; i < shiftarray.size(); i++)
	{
		cout << shiftarray[i] << " ";
	}
	cout << endl << "==============================================================" << endl;


	int current_char = substring.size() - 1;
	while (current_char < listOfDates.size())
	{
		int i = substring.size() - 1;
		int j = current_char;
		if (listOfDates[current_char] == substring[i])
		{
			// int j = current_char;
			while (listOfDates[j] == substring[i] && i != 0)
			{
				i--;
				j--;
			}
		}
		if (i == 0)
		{
			return current_char / 8 + 1;
		}
		else
		{
			if (substring.find(listOfDates[j]) == -1)
			{
				current_char += substring.size();
			}
			else
			{
				current_char += shiftarray[i];
			}
		}
	}
	return -1;
}

void Search(vector<Human> humans)
{
	Date key;
	cout << "Введите интересующую дату рождения" << endl;
	cin >> key.Day >> key.Month >> key.Year;

	bool f = FindViaInterPolationSearch(humans, key);
	cout << endl << "Поиск через интерполяционный метод" << endl;
	if (f)
		cout << "Элемент найден" << endl;
	else
		cout << "Элемент не найден" << endl;

	f = LineSearch(humans, key);
	cout << endl << "Метод линейного поиска" << endl;
	if (f)
		cout << "Элемент найден" << endl;
	else
		cout << "Элемент не найден" << endl;

	int ind = FindSubstringInString(humans, key);
	cout << endl << "Метод поиска подстроки в строке" << endl;
	if (ind != -1) 
	{
		cout << "Элемент найден" << endl;
		cout << "Инициалы интересующего элемента:" << endl << humans[ind].FIO << endl << endl;
	}
	else
		cout << "Элемент не найден" << endl;
}
int main()
{
	setlocale(LC_ALL, "rus");
	vector<Human>Humans;
	
	char vvod = ' ';
	while (vvod != '8')
	{
		cout << "1 - Создать структуру" << endl;
		cout << "2 - Вывести структуру" << endl;
		cout << "3 - Записать в файл" << endl;
		cout << "4 - Выполнить поиск" << endl;
		cin >> vvod;

		switch (vvod)
		{ 
		case '1': Humans = CreateArray(); break;
		case '2': PrintArray(Humans); break;
		case '3': SaveToFile(Humans); break;
		case '4': Search(Humans); break;
		}
	}
	Date key;
	cout << "Введите искомую дату рождения: " << endl;
	cin >> key.Day >> key.Month >> key.Year;
	int pos = KMP(Humans, key);
	cout << "Сортировка методом Кнутта-Морриса-Пратта:" << endl;
	if (pos == -1)
		cout << "Нет такой даты рождения" << endl;
	else
		cout << "Есть такая дата рождения" << endl;
	int BM = BMSearch(Humans, key);
	cout << "Сортировка методом Бойера-Мура:" << endl;
	if (BM == -1)
		cout << "Нет такой даты рождения" << endl;
	else
		cout << "Есть такая дата рождения" << endl;
}