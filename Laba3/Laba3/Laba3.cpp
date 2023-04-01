#include <iostream>
#include <time.h>

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
	//Оператор квадратные скобки
	T& operator[](const int index);
	//Вернуть размер списка
	int GetSize() {return Size;}

	
private:
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
		~Node() {

			printf("~Node()\n");
		}
	};

	int Size;
	//"Голова" списка ( первый элемент )
	Node <T>* Head;
	Node <T>* Tail;
};

template<typename T>
List<T>::List(): Size(0), Head(nullptr), Tail(nullptr)
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
	//Хвост равен голове, так как элемент один
	if (Head == nullptr)
	{
		Head = new Node<T>(data);
		Tail = Head;
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
		Tail = current->pNext;
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
	if (Size == 0)
	{
		
	}
	else
	else {
		//создаем временный указатель, в который присваиваем указаетль head
		Node<T>* temp = Head;
		//следующий элемент после head, становится head
		Head = Head->pNext;
		//удаляем указатель на старый head
		delete temp;
		//уменьшаем size после удаления элемента
		Size--;
	}
}

template<typename T>
void List<T>::pop_back()
{
	remove(Size - 1);
}

template<typename T>
void List<T>::insert(T data, int index)
{

	if (Size == 0 || index - Size >= 1 || index < 0) {

	}
	//если индекс 0, добавляем объект в начало
	else if (index == 0)
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
	//костыль, чтобы всё не ломалось, когда список пустой и вызывается метод remove
	if (Head == nullptr || index - Size > -1 || index < 0) {

	}
	//если нужно удалить элемент по индексу ноль, вызываем фукнция pop_front()
	else if (index == 0 && Size > 1)
	{
		 pop_front();
	}
	else if (Size == 1) {
		pop_front();
		Head = nullptr;
		Tail = nullptr;
	}
	else
	{
		//указатель, в который будет помещен указатель на объект по индексу [index-1]
		Node<T>* previous = this->Head;

		for (int i = 0; i < index - 1; i++)
		{
			previous = previous->pNext;
		}

		if (previous->pNext == Tail)
		{
			Node<T>* TailDelete = Tail;
			Tail = previous->pNext;
			delete TailDelete;
			Size--;
		}
		else {
			//Указатель ToDelete указывает на элемент который нужно удалить, то есть следующий после элемента [index-1]
			Node<T>* ToDelete = previous->pNext;
			//меняем указатель pNext у previous на pNext->ToDelete, после чего pNext будет указывать на [index+1] элемент
			previous->pNext = ToDelete->pNext;
			delete ToDelete;
			Size--;
		}
	}
}

template<typename T>
T& List<T>::operator[](const int index)
{
	//счетчик и нода с помощью которой будем итерироваться по циклу
	int counter = 0;
	Node<T>* current = this->Head;


	while (current != nullptr) {
		//проверяем равно ли значение счечтика значению индекса?
		if (counter == index)
		{
			//если да то return data
			return current->data;
		}
		//если нет то меням указатель current на следующий элемент списка и увеличиваем счечтик
		current = current->pNext;
		counter++;
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
	virtual ~Point() {
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

class ColoredPoint : public Point {
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
		printf("ColoredPoint(const Point& p)\n");
	}
	~ColoredPoint() override {
		printf("~ColoredPoint(%d, %d, %d)\n", x, y, color);
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

	//srand(time(NULL));

	time_t begin = time(NULL);

	const int COUNT_TEST = 100;

	List<int*> ints;

	int rand_value;
	for (int i = 0; i < COUNT_TEST; i++)
	{
		rand_value = rand() % 6;
		switch (rand_value)
		{
		case 0:
			ints.push_back(new int(rand() % 100));
			break;
		case 1:
			ints.push_front(new int(rand() % 100));
			break;
		case 2:
			ints.pop_back();
			break;
		case 3:
			ints.pop_front();
			break;
		case 4:
			ints.insert(new int(rand()%100), i);
			break;
		case 5:
			ints.remove(i);
			break;
		default:
			break;
		}
	}
	
	/*List<Point*> points;
	int rand_value;
	int rand_x;
	int rand_y;
	int rand_color;
	for (int i = 0; i < COUNT_TEST; i++)
	{
		rand_value = rand() % 6;
		rand_x = rand() % 100;
		rand_y = rand() % 100;
		rand_color = rand() % 255;

		switch (rand_value)
		{
		case 0:
			points.push_back(new ColoredPoint(rand_x, rand_y, rand_color));
			break;
		case 1:
			points.push_front(new ColoredPoint(rand_x, rand_y, rand_color));
			break;
		case 2:
			points.pop_back();
			break;
		case 3:
			points.pop_front();
			break;
		case 4:
			points.insert(new ColoredPoint(rand_x, rand_y, rand_color), i);
			break;
		case 5:
			points.remove(i);
			break;
		default:
			break;
		}
	}*/

	time_t end = time(NULL);

	cout << "\nThe elapsed time is " << end - begin << endl;

	return 0;
}


