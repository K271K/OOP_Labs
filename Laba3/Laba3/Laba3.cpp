#include <iostream>

using namespace std;

//Класс для односвязного списка
template<typename T>
class List {
public:

	List();
	~List();
	
	//очистка списка
	void clear();
	//добавить в конец списка
	void push_back(T data);
	void push_back(T* data);
	//добавить в начало списка
	void push_front(T data);
	//удалить элемент из начала списка
	void pop_front();
	//удалить элемент из конца списка
	void pop_back();
	//вставить элемент 
	void insert(T data, int index);
	//удалить элементы по индексу
	void remove(int index);
	//Вывод списка
	void ListOutput();
	//Вернуть размер списка
	int GetSize() {return Size;}
	//перегрузка оператора квадратные скобки
	T& operator[](const int index);
	
private:
	//Шаблонная нода, которая будет содержать данные и указатель на след элемент
	template<typename T>
	struct Node {
	public:
		Node* pNext; //указатель на следующий элемент в списке
		T data; //данные
		T* data; //данные переданные по указателю
		bool isDynamic = 0;
		Node() : data(T()), pNext(nullptr) {
			printf("Node()\n");
		}
		Node(T _data) : data(_data), pNext(nullptr) {
			printf("Node(T _data)\n");
		}
		~Node() {
			if (isDynamic) delete data;
			printf("~Node()\n");
		}
	};

	int Size;
	//"Голова" списка ( первый элемент )
	Node <T>* Head;
};

template<typename T>
List<T>::List(): Size(0), Head(nullptr)
{ 
	printf("List()\n");
}

template<typename T>
List<T>::~List()
{
	clear();
	printf("~List()\n");
	
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
	//если головы нет, значит список пуст и создается нода-голова, в которую будут помещены данные
	if (Head == nullptr)
	{
		Head = new Node<T>(data);
	}
	//если голова есть: создаем временный указатель, чтобы пройтись по нодам и найти ноду, у которой указатель на след элемент равен nullptr
	else 
	{
		Node<T>* current = this->Head;

		while (current->pNext != nullptr) 
		{
			current = current->pNext;
		}

		current->pNext = new Node<T>(data);
	}

	//увеличиваем size после добавления элемента
	Size++;
}

template<typename T>
void List<T>::push_back(T* data)
{
	//если головы нет, значит список пуст и создается нода-голова, в которую будут помещены данные
	if (Head == nullptr)
	{
		Head = new Node<T>(data);
	}
	//если голова есть: создаем временный указатель, чтобы пройтись по нодам и найти ноду, у которой указатель на след элемент равен nullptr
	else
	{
		Node<T>* current = this->Head;

		while (current->pNext != nullptr)
		{
			current = current->pNext;
		}

		current->pNext = new Node<T>(data);
	}

	//увеличиваем size после добавления элемента
	Size++;
}

template<typename T>
void List<T>::push_front(T data)
{
	Node<T>* NewNode = new Node<T>(data);
	NewNode->pNext = Head;
	Head = NewNode;
	Size++;
}

template<typename T>
void List<T>::pop_front()
{
	//создаем временный указатель, в который присваиваем указаетль head
	Node<T>* temp = Head;
	//следующий элемент после head, становится head
	Head = Head->pNext;
	//удаляем указатель на старый head
	delete temp;
	//уменьшаем size после удаления элемента
	Size--;
}

template<typename T>
void List<T>::pop_back()
{
	remove(Size - 1);
}

template<typename T>
void List<T>::insert(T data, int index)
{
	//если индекс 0, добавляем объект в начало
	if (index == 0)
	{
		push_front(data);
	}
	else
	{
		//указатель, в который будет помещен указатель на объект предыдищуий перед индексом по которому надо добавить объект
		Node<T>* previous = this->Head;
		
		for (int i = 0; i < index - 1; i++)
		{
			previous = previous->pNext;
		}

		//Создаю нову ноду и передаю туда данные, указатель новый ноды = равен указатнлю previous(указывает на объект, который имеет "index+1" индекс
		//У previous указатель pNext ставлю на новую созданную ноду
		Node<T>* NewNode = new Node<T>(data);
		NewNode->pNext = previous->pNext;
		previous->pNext = NewNode;

		Size++;

	}
}

template<typename T>
void List<T>::remove(int index)
{
	//если нужно удалить элемент по индексу ноль, вызываем фукнция pop_front()
	if (index == 0)
	{
		pop_front();
	}
	else
	{
		//указатель, в который будет помещен указатель на объект по индексу [index-1]
		Node<T>* previous = this->Head;

		for (int i = 0; i < index - 1; i++)
		{
			previous = previous->pNext;
		}

		//Указатель ToDelete указывает на элемент который нужно удалить, то есть следующий после элемента [index-1]
		Node<T>* ToDelete = previous->pNext;
		//меняем указатель pNext у previous на pNext->ToDelete, после чего pNext будет указывать на [index+1] элемент
		previous->pNext = ToDelete->pNext;

		delete ToDelete;
		Size--;
	}
}

template<typename T>
void List<T>::ListOutput()
{
	int current_size = this->GetSize();
	for (int i = 0; i < current_size; i++)
	{
	}
}

template<typename T>
T& List<T>::operator[](const int index)
{
	//вводим счетчик и пока он не равен переданному индексу идем по нодам, когда счетчик равен индексу, возвращаем данные
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

//класс для проверки
class Point {
public:
	Point(): x(0), y(0)
	{
		printf("Point()\n");
	}
	Point(int x, int y)
	{
		printf("Point(int x, int y)\n");
		this->x = x;
		this->y = y;
	}
	Point(const Point& T) {
		printf("Point(const Point& T)\n");
		this->x = T.x;
		this->y = T.y;
	}
	~Point() {
		printf("~Point(%d, %d)\n", x, y);
	}
	
	int GetCordX() {
		return x;
	}
	virtual void output() {
		printf("x = %d y = %d\n", x, y);
	}
protected:
	int x;
	int y;
};

class ColoredPoint : Point {
protected:
	int color;
public:
	ColoredPoint() : Point(), color(0) {
		printf("ColoredPoint()\n");
	}
	ColoredPoint(int x, int y, int color) : Point(x, y), color(color) {
		printf("ColoredPoint(int x, int y, int color)\n");
	}
	ColoredPoint(const ColoredPoint& cp) : Point(cp), color(cp.color) {
		printf("NamedPoint(const Point& p)\n");
	}
	~ColoredPoint() {
		printf("~NamedPoint(%d, %d, %d)\n", x, y, color);
	}
	void output() override {
		printf("x = %d, y = %d, color = %d\n", x, y, color);
	}
	void changeColor(char newColor) {
		color = newColor;
	}
};

class NamedPoint : public Point {
protected:
	char Name;
public:
	NamedPoint() : Point(), Name('\0') {
		printf("NamedPoint()\n");
	}
	NamedPoint(int x, int y, char Name) : Point(x, y), Name(Name) {
		printf("NamedPoint(int x, int y, char Name)\n");
	}
	NamedPoint(const NamedPoint& np) : Point(np), Name(np.Name) {
		printf("NamedPoint(const Point& p)\n");
	}
	~NamedPoint() {
		printf("~NamedPoint(%d, %d, %c)\n", x, y, Name);
	}
	void output() override {
		printf("x = %d, y = %d, Name = %c\n", x, y, Name);
	}
	void changeName(char newName) {
		Name = newName;
	}
};


int main() {
	const int COUNT_POINTS = 10;
	List<Point> points;

	Point* A = new Point();
	Point B(1, 2);
	points.push_back(B);
	points.push_back(A);

	srand(time(NULL));
	//int RandValue;
	//for (int i = 0; i < 10; i++) {
	//	RandValue = rand() % 3 + 1;
	//	switch (RandValue)
	//	{
	//	case 1:
	//		cout << "Added Point\n";
	//		break;
	//	case 2:
	//		cout << "ADded ColoredPoint\n";
	//		break;
	//	case 3:
	//		cout << "Added NamedPoint\n";
	//		break;
	//	default:
	//		break;
	//	}
	//}

	

	return 0;
}


