#include <iostream>
#include "Stack.h"
using namespace std;
template <typename t>
void PrintStack(Stack<t>& list)
{
    int i = 1;
    while (!list.empty())
    {
        cout << i << "-ый элемент стека: " << list.top() << endl;
        list.pop();
        i++;
    }
}

int main()
{
    setlocale(LC_ALL, "rus");
    Stack<char> st;
    st.push('y');
    st.push('t');
    st.push('r');
    st.push('e');
    st.push('w');
    st.push('q');
    Stack<char> st2;
    st2 = st;
    Stack<char> st3;
    st3 = st2;
    cout << "1 стек:" << endl;
    PrintStack(st);
    cout << endl << "2 стек:" << endl;
    PrintStack(st2);
    cout << endl << "3 стек:" << endl;
    PrintStack(st3);
}
