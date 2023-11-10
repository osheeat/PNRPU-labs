#include"Money.h"
#include"FileWork.h"
#include <iostream>
#include<fstream>
#include<string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    //system("chcp>1251");

    Money m, m1, m2;
    int k, c, count;
    char file_name[30];
    do 
    {
        cout << "1)  Make File" << endl;
        cout << "2)  Print File" << endl;
        cout << "3)  Delete record from file" << endl;
        cout << "4)  Add Record To File" << endl;
        cout << "5)  Change Record In File" << endl;
        cout << "0)  Exit" << endl;
        cin >> c;
        switch (c)
        {
        case 1: 
            cout << "Введите имя файла:  ";
            cin >> file_name;
            k = MakeFile(file_name);
            if (k < 0) 
                cout << "Невозможно создать файл!";
            break;
        case 2:
            k = PrintFile(file_name);
            if (k == 0) cout << "Файл пуст\n";
            if (k < 0) cout << "Невозможно прочитать файл\n";
            break;
        case 3:
            int rubdel, kopdel;
            cout << "Имя файла:  ";
            cin >> file_name;
            cout << "Введите рубли:  "; 
            cin >> rubdel;
            cout << "Введите копейки:  ";
            cin >> kopdel;
            DeleteElem(file_name, rubdel, kopdel);
            if(k < 0) 
                cout << "Невозможно прочитать файл\n";
            break;
        case 4 :
            int pos;
            cout << "Имя файла:  ";
            cin >> file_name;
            cout << "Введите позицию, на которую хотите поставить:  ";
            cin >> pos;
            cout << "Введите рубли и копейки, которые хотите добавить (через пробел):  ";
            cin >> m1;
            cout << "Количество новых элементов:  ";
            cin >> count;
            k = add_file(file_name, pos, m1, count);
            if (k < 0)
                cout << "Невозможно прочитать файл\n";
            if (k == 0)
                k = add_end(file_name, m1, count);
            
            break;
        case 5:
            int nom, nom1;
            cout << "Имя файла:  ";
            cin >> file_name;
            cout << "Введите рубли и копейки, которые хотите увеличить (через пробел):  " << endl;
            cin >> nom >> nom1;
            k = ChangeFile(file_name, nom, nom1);
            if (k < 0)
                cout << "Невозможно прочитать файл\n" << endl;
            break;
        }
    } while (c != 0);
}
