#include <iostream>
#include<vector>
#include<ctime>
#include<algorithm>
using namespace std;

int getCorrectNumber(int num)
{
	while (!(cin >> num) || (cin.peek() != '\n') || num < 0)
	{
		cin.clear();
		while (cin.get() != '\n');
		cout << "Введите корректное число: ";
	}
	return num;
}

void CreateArray(vector<int>&A, int size)
{
    for (int i = 0; i < size; i++)
    {
        A[i] = 1 + rand() % 20;
    }
}

void PrintArray(vector<int>A)
{
    for (int i = 0; i < A.size(); i++)
    {
        cout << A[i] << " ";
    }
}

//Сбалансированное слияние................
vector<int> Merge(vector<int> list1, vector<int> list2)
{
    int l1 = 0;
    int l2 = 0;
    vector<int>tmp;
    while (l1 < list1.size() && l2 < list2.size())
    {
        if (list1[l1] <= list2[l2])
        {
            tmp.push_back(list1[l1]);
            l1++;
        }
        else
        {
            tmp.push_back(list2[l2]);
            l2++;
        }
    }
    while (l1 < list1.size())
    {
        tmp.push_back(list1[l1]);
        l1++;
    }
    while (l2 < list2.size())
    {
        tmp.push_back(list2[l2]);
        l2++;
    }
    cout << "Серия массива:" << endl;
    cout << "| "; PrintArray(tmp);
    cout << "|" << endl;
    return tmp;
}
void MergeSort(vector<int>& list)
{
    if (list.size() < 2)
    {
        return;
    }
    vector<int> left;
    vector<int> right;
    int mid = list.size() / 2;
    for (int i = 0; i < mid; i++)
    {
        left.push_back(list[i]);
    }
    for (int i = mid; i < list.size(); i++)
    {
        right.push_back(list[i]);
    }
    MergeSort(left);
    MergeSort(right);
    list = Merge(left, right);
}


//Естественное слияние................
void PrintSeries(vector<vector<int>>arr)
{
    for (int i = 0; i < arr.size(); i++)
    { 
        cout << i + 1 << "-я серия: ";
        cout << "| ";
        for (int j=0; j < arr[i].size(); j++)
        { 
            cout << arr[i][j] << " ";
        }
        cout << "|" << endl;
    }
}
vector<vector<int>> SplitToSeries(vector<int>Arr)
{
    vector<vector<int>>Mattrix;
    int i = 0;
    while (i < Arr.size())
    {
        vector<int>NewSerie;
        NewSerie.push_back(Arr[i]);
        i++;

        while (i < Arr.size() && Arr[i-1] <= Arr[i])
        {
            NewSerie.push_back(Arr[i]);
            i++;
        }
        Mattrix.push_back(NewSerie);
    }
    cout << "Ваши серии:" << endl;
    PrintSeries(Mattrix);
    return Mattrix;
}
vector<int> NaturalMerge(vector<int> list)
{
    vector<vector<int>> mat = SplitToSeries(list);
    while (mat.size() >= 2)
    {
        vector<int> Merged = Merge(mat[0], mat[1]);
        mat.push_back(Merged);
        mat.erase(mat.begin());
        mat.erase(mat.begin());
    }
    return mat[0];
}

//Многофазное слияние................................
void Print_Files(vector<vector<int>> File1, vector<vector<int>> File2, vector<vector<int>> File3)
{
	cout << "F1:" << endl;
	PrintSeries(File1);
	cout << "=============================================" << endl;
	cout << "F2:" << endl;
	PrintSeries(File2);
	cout << "=============================================" << endl;
	cout << "F3:" << endl;
	PrintSeries(File3);
	cout << "=============================================" << endl;
}

void Fibb(int count_of_series, int& size1, int& size2)
{
	size1 = 0, size2 = 1;
	while (size1 + size2 < count_of_series)
	{
		int tmp = size2;
		size2 += size1;
		size1 = tmp;
	}
}

vector<vector<int>> Split_to_series(vector<int> list)
{
	vector<vector<int>> result;
	int count;
	if (list.size() < 8) {
		count = 1;
	}
	else
	{
		count = list.size() / 8;
		while (list.size() % count != 0)
			count--; 
	}
	int i = 0;
	for (int i = 0; i < list.size() / count; i++)
	{
		vector<int> tmp;
		for (int j = 0; j < count; j++)
		{
			tmp.push_back(list[i * count + j]);
		}
		result.push_back(tmp);
	}
	return result;
}

vector<vector<int>> Files_Merge(vector<vector<int>>& F1, vector<vector<int>>& F2)
{
	vector<vector<int>> result; 
	int min;
	if (F1.size() < F2.size()) 
		min = F1.size();
	else
		min = F2.size();

	for (int i = 0; i < min; i++)
	{
		result.push_back(Merge(F1[i], F2[i])); 
	}

	F1.erase(F1.begin(), F1.begin() + min);  
	F2.erase(F2.begin(), F2.begin() + min); 	

	return result;
}

void DeleteEmptySerie(vector<int>& list)
{
	while (list[0] == -100)
	{
		list.erase(list.begin());
	}
}

vector<int> PhaseMerge(vector<int> list)
{
	vector<vector<int>> series = Split_to_series(list);
	int size1, size2; 

	vector<vector<int>> File1, File2, File3; 
	Fibb(series.size(), size1, size2); 
	for (int i = 0; i < size1; i++)
	{
		File1.push_back(series[i]);
	}
	if (size1 + size2 == series.size())
	{
		for (int i = size1; i < series.size(); i++)
		{
			File2.push_back(series[i]);
		}
	}
	else
	{
		int tmp = size1;
		for (tmp; tmp < series.size(); tmp++)
		{
			File2.push_back(series[tmp]);
		}

		for (tmp; tmp < size1 + size2; tmp++)
		{
			vector<int> empty_serie;
			for (int j = 0; j < File2[0].size(); j++)
			{
				empty_serie.push_back(-100);
			}
			File2.push_back(empty_serie);
		}
	}
	

	Print_Files(File1, File2, File3);

	
	for (int i = 0; i < File1.size(); i++)
	{
		sort(File1[i].begin(), File1[i].end());
	}
	for (int i = 0; i < File2.size(); i++)
	{
		sort(File2[i].begin(), File2[i].end());
	}

	Print_Files(File1, File2, File3);

	int count_of_emptyfiles = 1; 
	while (count_of_emptyfiles != 2)
	{
		int empty_index = 3; 
		if (File1.empty()) empty_index = 1;
		if (File2.empty()) empty_index = 2;
		switch (empty_index)
		{
		case 1:
		{
			File1 = Files_Merge(File2, File3);
			break;
		}
		case 2:
		{
			File2 = Files_Merge(File1, File3);
			break;
		}
		case 3:
		{
			File3 = Files_Merge(File1, File2);
			break;
		}
		}
		count_of_emptyfiles = 0;
		if (File1.empty()) count_of_emptyfiles++;
		if (File2.empty()) count_of_emptyfiles++;
		if (File3.empty()) count_of_emptyfiles++;
		Print_Files(File1, File2, File3);
	}

	if (!File1.empty())
	{
		DeleteEmptySerie(File1[0]);
		return File1[0];
	}
	if (!File2.empty())
	{
		DeleteEmptySerie(File2[0]);
		return File2[0];
	}
	if (!File3.empty())
	{
		DeleteEmptySerie(File3[0]);
		return File3[0];
	}
}
int main()
{
    setlocale(LC_ALL, "rus");
    srand (time(NULL));
    int size;
	cout << "Введите размер массива:  ";
	cin >> size;
    size = getCorrectNumber(size);
    vector<int>Array(size);
    CreateArray(Array, size);
    cout << "Ваш массив:" << endl;
    PrintArray(Array);
    cout << endl;
    MergeSort(Array);
    cout << "Сбалансированное слияние:" << endl;
    PrintArray(Array);
    cout << endl << "========================================================================" << endl;
    CreateArray(Array, size);
    cout << "Ваш массив:" << endl;
    PrintArray(Array);
    cout << endl;
    Array = NaturalMerge(Array);
    cout << "Естесственное слияние:" << endl;
    PrintArray(Array);
    cout << endl << "========================================================================" << endl;
	CreateArray(Array, size);
	cout << "Ваш массив:" << endl;
	PrintArray(Array);
	cout << endl;
	Array = PhaseMerge(Array);
	cout << "Фазовое слияние:" << endl;
	PrintArray(Array);
	cout << endl << "========================================================================" << endl;
    system("pause");
}