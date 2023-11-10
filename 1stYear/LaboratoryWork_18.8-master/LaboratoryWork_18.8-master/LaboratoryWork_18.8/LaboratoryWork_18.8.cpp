#include <iostream>
#include"Dialog.h"
#include <Windows.h>
using namespace std;

void setcolor(int govno)
{
    int bg = 0;
    int text = govno;
    HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(hStdOut, (WORD)((bg << 4) | text));
}

int main()
{
    srand(time(0));
    setlocale(LC_ALL, "rus");
    cout << " m[number]  : создать массив длиной number" << endl;
    cout << "     +      : добавить элемент в массив" << endl;
    cout << "     -      : удалить элемент из массива" << endl;
    cout << "     s      : вывести весь массив на экран" << endl;
    cout << "     z      : вывести названия произведений на экран" << endl;
    cout << "     q      : выйти из программы" << endl << endl;
    Dialog D;
    D.Execute();


    int colour;
    colour = 3 + rand() % 4;
    switch (colour) 
    {
    case 3: cout << "лео беспорядок" << endl; break;
    case 4: cout << "раф саймонс" << endl; break;
    case 5: cout << "эмси дони" << endl; break;
    case 6: cout << "майки мышь" << endl; break;
    }


    setcolor(2);
    cout << "                             "; setcolor(colour); cout << "    ______     " << endl; setcolor(2);
    cout << "           ...............   "; setcolor(colour); cout <<"  / " << endl;
    cout << "        _____________________ /      ___      " << endl; 
    cout << "      ....."; setcolor(7); cout << "<0>"; setcolor(colour); cout << "........."; setcolor(7); cout << "<0>"; setcolor(colour); cout <<"...... ";  cout << "  /" << endl;
    cout << "    _____________________________ /             " << endl; setcolor(2);
    cout << "  .............*.....*..............               " << endl;
    cout << "    .............................               " << endl;
    cout << "      .........................               " << endl;
    cout << "        ......_________.......              " << endl;
    cout << "           ...............             " << endl;
    setcolor(7);
    /*
    Dialog D;
    D.Execute();*/
}