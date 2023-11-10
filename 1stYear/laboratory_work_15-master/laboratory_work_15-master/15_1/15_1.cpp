#include <iostream>
#include<vector>
#include<stack>
using namespace std;
struct Bus
{
    int number, Long;
};
int getCorrectNumber()
{
    unsigned int num;
    while (!(cin >> num) || (cin.peek() != '\n') || num < 0)
    {
        cin.clear();
        while (cin.get() != '\n')
        cout << "Введите корректное число: ";
    }
    return num;
}
void shell(vector<Bus>& array, int size)
{
    int temp1, temp2, j;
    for (int step = size / 2; step > 0; step /= 2) 
    {
        for (int i = step; i < size; i++) 
        {
            temp1 = array[i].number;
            temp2 = array[i].Long;
            for (j = i; j >= step; j -= step) 
            {
                if (temp2 < array[j - step].Long) 
                {
                    array[j].Long = array[j - step].Long;
                    array[j].number = array[j - step].number;
                }
                else {
                    break;
                }
            }
            array[j].number = temp1;
            array[j].Long = temp2;

        }
    }
}
void huara(vector<Bus>& items, int left, int right)
{
    int i, j, middle, tmpnum, tmplong;
    stack<int>stc;
    stc.push(left);
    stc.push(right);
    do {
        right = stc.top();
        stc.pop();
        left = stc.top();
        stc.pop();
        i = left;
        j = right;
        middle = items[(right + left) / 2].Long;
        do 
        {
            while (items[i].Long < middle) 
                i++;
            while (middle < items[j].Long) 
                j--;
            if (i <= j)
            {
                tmplong = items[i].Long;
                items[i].Long = items[j].Long;
                items[j].Long = tmplong;
                tmpnum = items[i].number;
                items[i].number= items[j].number;
                items[j].number = tmpnum;
                i++;
                j--;
            }

        } while (i <= j);
        if (left < j)
        {
            stc.push(left);
            stc.push(j);
        }
        if (i < right)
        {
            stc.push(i);
            stc.push(right);
        }
    } while (!stc.empty());
}

int main()
{
    int size;
    setlocale(LC_ALL, "rus");
    cout << "Введите кол-во элементов: ";
    size = getCorrectNumber();
    vector <Bus> buses(size);
    for (int i = 0; i < size; i++)
    {
        cout << "Номер автобуса: ";
        cin >> buses[i].number;
        cout << "Длина маршрута: ";
        cin >> buses[i].Long;
        cout << endl;
    }
    shell(buses, size);
    cout << endl;
    cout << "Shell: " << endl << endl;
    for (int i = 0; i < size; i++)
    {
        cout << "Номер автобуса: " << buses[i].number << " - ";
        cout << "Длина маршрута: " << buses[i].Long << endl;
    }

    cout << endl << endl;
    huara(buses, 0, size-1);
    cout << "Hoara:" << endl << endl;
    for (int i = 0; i < size; i++)
    {
        cout << "Номер автобуса: " << buses[i].number << " - ";
        cout << "Длина маршрута: " << buses[i].Long << endl;
    }
    system("pause");
}