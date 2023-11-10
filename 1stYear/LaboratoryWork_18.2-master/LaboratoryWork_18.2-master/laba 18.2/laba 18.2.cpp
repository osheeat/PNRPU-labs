#include <iostream>
#include <string>
#include <cmath>
#include <vector>

using namespace std;

class Exam
{
    string FIO;
    string subject;
    int mark;
public:
    Exam()
    {
        FIO = "noname noname noname";
        subject = "nosub";
        mark = 0;
    }
    Exam(string FIO, string subject, int mark)
    {
        this->FIO = FIO;
        this->subject = subject;
        this->mark = mark;
    }
    ~Exam() {}
    void SetFIO()
    {
        string value;
        cout << "Введите ФИО: ";
        getline(cin, value);
        this->FIO = value;
    }
    string GetFIO() { return FIO; }

    void SetSubject()
    {
        string val;
        cout << "Введите предмет: ";
        getline(cin, val);
        this->subject = val;
    }
    string GetSubject() { return subject; }

    void SetMark()
    {
        int ocen;
        cout << "Введите оценку: ";
        cin >> ocen;
        while (ocen > 5 || ocen < 2)
        {
            cout << " Введите корректное число: ";
            cin >> ocen;
        }
        this->mark = ocen;
    }
    int GetMark() { return mark; }
    void Print()
    {
        cout << "ФИО: " << this->FIO << endl;
        cout << "Предмет: " << this->subject << endl;
        cout << "Оценка: " << this->mark << endl;
        cout << "===============================================" << endl;
    }
};

int main()
{
    system("chcp 1251");
    setlocale(LC_ALL, "rus");
    Exam object1, object2("Galinov Oleg Yurevich", "Информатика", 4);

    cout << "object 1 " << endl;
    object1.Print();

    cout << "Введите данные для exam 1:" << endl;
    object1.SetFIO();
    object1.SetSubject();
    object1.SetMark();
    cout << "object 1 ФИО:" << object1.GetFIO() << endl;
    cout << "object 1 предмет:" << object1.GetSubject() << endl;
    cout << "object 1 оценка:" << object1.GetMark() << endl;
    cout << "===============================================" << endl;

    cout << "Ваши экземпляры:" << endl;
    vector<Exam> list{ object1,object2 };
    for (int i = 0; i < 2; i++)
    {
        cout << i + 1 << "-й object" << endl;
        list[i].Print();
    }
}