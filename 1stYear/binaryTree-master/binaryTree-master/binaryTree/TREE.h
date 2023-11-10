#pragma once
#include <iostream>
#include <Windows.h>
#include <stdio.h>
using namespace std;
COORD position;
HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);

char** array_numbers;
int array_numbers_size;
int index = 1;
bool isBalancedSortPrinting = true;
const int start_x_position = 100;

//работа с деревом указателей на символ
struct CharPointerNode {
    char* data;
    CharPointerNode* left, * right;
};
class BinaryCharPointerTree {
public:
    CharPointerNode* root;
    void delete_tree(CharPointerNode* leaf) {
        if (leaf != NULL) {
            delete_tree(leaf->left);
            delete_tree(leaf->right);
            delete leaf;
        }
    }
    void create_balanced_binary_tree(CharPointerNode*& leaf, int size) {
        if (size == 0) {
            leaf = NULL;
            return;
        }
        cout << ++index << ") ";
        string str;
        cin >> str;
        leaf = new CharPointerNode;
        leaf->data = new char[str.length() + 1];
        copy(str.begin(), str.end(), leaf->data);
        leaf->data[str.length()] = '\0';
        int left_subtree_size, right_subtree_size;
        get_subtrees_sizes(size, left_subtree_size, right_subtree_size);
        create_balanced_binary_tree(leaf->left, left_subtree_size);
        create_balanced_binary_tree(leaf->right, right_subtree_size);
    }
    int depth_tree(CharPointerNode* leaf) {
        if (leaf == NULL)
            return 0;
        return max(depth_tree(leaf->right), depth_tree(leaf->left)) + 1;
    }
    void print_branch(CharPointerNode* leaf, int x, int y) {
        if (leaf == NULL)
            return;
        position.X = x;
        position.Y = y;
        SetConsoleCursorPosition(hConsole, position);
        cout << leaf->data;
        int formula_new_x_left_leaf, formula_new_x_right_leaf;
        if (isBalancedSortPrinting) {
            formula_new_x_left_leaf = x - 2 * (y + 2);
            formula_new_x_right_leaf = x + 2 * (y + 2);
        }
        else {
            formula_new_x_left_leaf = x - 2 * (y + 1);
            formula_new_x_right_leaf = x + 2 * y;
        }
        print_branch(leaf->left, formula_new_x_left_leaf, y + 2);
        print_branch(leaf->right, formula_new_x_right_leaf, y + 2);
    }
    void print_tree(CharPointerNode*& leaf) 
    {
        if (leaf == NULL)
            return;
        CharPointerNode* branch_left = NULL;
        CharPointerNode* branch_right = NULL;
        branch_left = leaf->left;
        branch_right = leaf->right;
        position.X = start_x_position;
        position.Y = 3;
        SetConsoleCursorPosition(hConsole, position);
        cout << leaf->data;
        int depthOfTheTree = depth_tree(leaf);
        int offset_coefficient;
        if (isBalancedSortPrinting)
            offset_coefficient = 6;
        else
            offset_coefficient = 4;
        print_branch(branch_left, start_x_position - offset_coefficient * depthOfTheTree, 5);
        print_branch(branch_right, start_x_position + offset_coefficient * depthOfTheTree, 5);
    }
    int counting_key_symbols;
    void count_requested_elements(CharPointerNode* leaf, char key_symbol)
    {
        if (leaf == NULL)
            return;
        count_requested_elements(leaf->left, key_symbol);
        count_requested_elements(leaf->right, key_symbol);
        if (*leaf->data == key_symbol)
            counting_key_symbols++;
 
    }

    CharPointerNode* insert_in_search_tree(CharPointerNode*& leaf,char* element) {
        //if (isElementInTree(leaf, element)) //если элемент дублируется, то в дерево поиска мы его не вставляем
            //return leaf;
        if (leaf == NULL) {
            CharPointerNode* new_leaf = new CharPointerNode;
            new_leaf->data = element;
            new_leaf->left = NULL;
            new_leaf->right = NULL;
            return new_leaf;
        }
        for (int i = 0; i < element[i]!='/0'; i++)
        { 
            if (element[i] < leaf->data[i])
                leaf->left = insert_in_search_tree(leaf->left, element);
            if (element[i] > leaf->data[i])
                leaf->right = insert_in_search_tree(leaf->right, element);
        }
        return leaf;
    }
    void preorder_traversal(CharPointerNode* leaf) {
        if (leaf == NULL)
            return;
        cout << leaf->data << "   ";
        preorder_traversal(leaf->left);
        preorder_traversal(leaf->right);
    }
    void postorder_traversal(CharPointerNode* leaf) {
        if (leaf == NULL)
            return;
        postorder_traversal(leaf->left);
        postorder_traversal(leaf->right);
        cout << leaf->data << "   ";
    }
    void inorder_traversal(CharPointerNode* leaf) {
        if (leaf == NULL)
            return;
        inorder_traversal(leaf->left);
        cout << leaf->data << "   ";
        inorder_traversal(leaf->right);
    }
    void get_subtrees_sizes(const int size, int& left_size, int& right_size) {
        if ((size - 1) % 2 == 0) {
            left_size = (size - 1) / 2;
            right_size = left_size;
        }
        else {
            left_size = size / 2;
            right_size = (size - 1) / 2;
        }
    }
public:
    void preorder_traversal() {     //прямой обход
        preorder_traversal(root);
    }
    void postorder_traversal() {    //обратный обход
        postorder_traversal(root);
    }
    void inorder_traversal() {          //симметричный обход
        inorder_traversal(root);
    }
    int count_requested_elements(char key) {
        count_requested_elements(root, key);
        return counting_key_symbols;
    }
    BinaryCharPointerTree() {
        root = NULL;
        counting_key_symbols = 0;
    }
    ~BinaryCharPointerTree() {
        delete_tree(root);
    }
    void create_balanced_binary_tree(int size) {
        string str;
        cout << "1) ";
        cin >> str;
        root = new CharPointerNode;
        root->data = new char[str.length() + 1];
        copy(str.begin(), str.end(), root->data);
        root->data[str.size()] = '\0';
        if ((size - 1) > 0) {
            int left_subtree_size, right_subtree_size;
            get_subtrees_sizes(size, left_subtree_size, right_subtree_size);
            create_balanced_binary_tree(root->left, left_subtree_size);
            create_balanced_binary_tree(root->right, right_subtree_size);
        }
    }

    int depth_tree() {
        return depth_tree(root);
    }

    void print_tree() {
        print_tree(root);
    }
};
