#include <iostream>

template<typename T>
struct Node {
public:
	Node* pNext;
	T data;
	Node(T _data = T(), Node* _pNext = nullptr) : data(_data), pNext(_pNext) {
		printf("Node(T _data, Node* _pNext)\n");
	}
};

template<typename T>
class List {
public:
	List();
	~List();
	
	void push_back(T data);
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
	
	List<Point> pointList;
	Point A;
	Point B;
	pointList.push_back(A);
	pointList.push_back(B);

	std::cout << pointList.GetSize() << "\n";
	std::cout << pointList[1].GetCordX() << "\n";

	return 0;
}


