#pragma once
#include <iostream>
#include <vector>
using namespace std;
template <typename t>
class Node
{
public:
	t data;
	Node* next;

	Node(t Value, Node* Next)
	{
		data = Value;
		next = Next;
	}
};

template <typename t>
class Stack
{
	Node<t>* head;
	int _size;
public:

	Stack()
	{
		head = nullptr;
		_size = 0;
	}
	~Stack()
	{
		while (!empty())
			pop();
	}
	int size() 
	{
		return _size; 
	}
	void push(t data)
	{
		_size++;
		Node<t>* newel = new Node<t>(data, head);
		head = newel;
	}
	bool empty() 
	{
		return head == nullptr;
	}
	void pop()
	{
		if (empty())
		{
			return;
		}
		Node<t>* tmp = head;
		head = tmp->next;
		delete tmp;
		tmp = nullptr;
		_size--;
	}
	t top()
	{
		if (empty())
		{
			return NULL;
		}
		return head->data;
	}
	const Stack& operator=(const Stack& list)
	{
		vector<t> listofdatas;
		Node<t>* tmp = list.head;
		while (tmp != nullptr)
		{
			listofdatas.push_back(tmp->data);
			tmp = tmp->next;
		}
		this->head = nullptr;
		this->_size = 0;
		while (!listofdatas.empty())
		{
			this->push(listofdatas[listofdatas.size() - 1]);
			listofdatas.pop_back();
		}
		return *this;
	}
};