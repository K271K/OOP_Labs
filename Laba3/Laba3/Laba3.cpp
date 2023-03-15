#include <iostream>

//Шаблонная нода, которая будет содержать данные и указатель на след элемент
template<typename T>
struct Node {
public:
	Node* pNext; //указатель на следующий элемент в списке
	T data; //данные
	Node() : data(T()), pNext(nullptr) {
		printf("Node()\n");
	}
	Node(T _data) : data(_data), pNext(nullptr) {
		printf("Node(T _data)\n");
	}
};

template<typename T>
class List {
public:
	List();
	~List();
	
	void clear();
	void push_back(T data);
	void pop_front();
	int GetSize() {return Size;}
	T& operator[](const int index);
private:

	

	int Size;
	Node <T> *Head;
};

template<typename T>
List<T>::List(): Size(0), Head(nullptr)
{ 
	printf("List()\n");
}

template<typename T>
List<T>::~List()
{
	printf("~List()\n");
	clear();
}

template<typename T>
void List<T>::clear()
{
	while (Size) //пока Size != 0 вызывать pop_front, который удаляет элемент из начала и уменьшает Size на 1
	{
		pop_front();
	}
}

template<typename T>
void List<T>::push_back(T data)
{
	if (Head == nullptr)
	{
		Head = new Node<T>(data);
	}
	else 
	{
		Node<T>* current = this->Head;

		while (current->pNext != nullptr) 
		{
			current = current->pNext;
		}

		current->pNext = new Node<T>(data);
	}

	Size++;
}

template<typename T>
void List<T>::pop_front()
{
	Node<T>* temp = Head;
	Head = Head->pNext;
	delete temp;
	Size--;
}

template<typename T>
T& List<T>::operator[](const int index)
{
	int counter = 0;
	Node<T>* current = this->Head;
	while (current != nullptr)
	{
		if (counter == index)
		{
			return current->data;
		}
		else
		{
			current = current->pNext;
			counter++;
		}
	}
}

class Point {
public:
	Point(): x(0), y(0)
	{
		printf("Point()\n");
	}
	
	int GetCordX() {
		return x;
	}
private:
	int x;
	int y;
};


int main() {



	return 0;
}


