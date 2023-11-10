#include <iostream>
#include "TREE.h"
using namespace std;

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    cout << "Введите количество элементов в бинарном дереве:" << endl;
    do {
        cout << ">";
        cin >> array_numbers_size;
        if (array_numbers_size < 1)
            cout << "Введите положительное число" << endl;
    } while (array_numbers_size < 1);

    array_numbers = new char*[array_numbers_size];
    BinaryCharPointerTree tree;
    cout << "Введите Ваши строки:\n";
    tree.create_balanced_binary_tree(array_numbers_size);
    system("cls");
    cout << "\t\t\t\t\t\t\t\t\t\t\tВЫВОД БИНАРНОГО ДЕРЕВА";
    cout << "\n\t\t\t\t\t\t\t\t\t\t\tГлубина дерева: " << tree.depth_tree();
    tree.print_tree();
    cout << "\n\n\n\n";
    char sym;
    cout << "Введите символ, который необходимо найти:  ";
    cin >> sym;
    cout << "Количество строк, которые начинаются с искомого символа равно: " << tree.count_requested_elements(sym) << endl;
    cout << "Прямой обход:\n";
    tree.preorder_traversal();
    cout << endl;
    cout << "Обратный обход:\n";
    tree.postorder_traversal();
    cout << endl;
    cout << "Симметричный обход:\n";
    tree.inorder_traversal();
    cout << "\n\n\n\n\n\n\n\n";
    system("pause");
    system("cls");
    return 0;
}