#include <iostream>
#include <string>

using namespace std;

//Классы без виртуальных методов
class People {
protected:
	int age;
public:
	People() {
		printf("People()\n");
	}
	~People() {
		printf("~People()\n");
	}
	void Who() {
		printf("I am a people!\n");
	}
};
class Student : public People {
public:
	Student() {
		printf("Student()\n");
	}
	~Student() {
		printf("~Student()\n");
	}
	void Who() {
		printf("I am a people, also i am a student!\n");
	}
	void Study() {
		printf("Oh-oh how many things i need to do\n");
	}
};

//Классы с виртуальными методами
class Transport {
protected:
	int  weight;
public:
	Transport() {
		printf("Transport()\n");
	}
	virtual ~Transport() {
		printf("~Transport()\n");
	}
	virtual void Wheels_Count() {
		printf("I can have N wheels!\n");
	}
	virtual string classname() {
		return "Transport";
	}
	virtual bool isA(const string& who) {
		return who == "Transport";
	}
	void method1() {
		printf("In Transport::method1()\n");
		method2();
	}
	virtual void method2() {
		printf("In Transport::method2()\n");
	}
};
class Car : public Transport {
protected:
	int  weight;
public:
	Car() {
		printf("Car()\n");
	}
	~Car() override {
		printf("~Car()\n");
	}
	void Wheels_Count() override {
		printf("I have 4 wheels!\n");
	}
	string classname() override {
		return "Car";
	}
	bool isA(const string& who) override {
		return who == "Transport" || who == "Car";
	}
	//Имеется в виду легковая машина может резко повернуть
	void FlipFlop() {
		printf("Совершается резкий поворот\n");
	}
	void method2() {
		printf("In Car::method2()\n");
	}
};
class Sedan : public Car {
public:
	bool isA(const string& who) override {
		return (who == "Sedan") || (Car::isA(who));
	}
};
class Truck : public Transport {
protected:
	int  weight;
public:
	Truck() {
		printf("Truck()\n");
	}
	~Truck() override {
		printf("~Truck()\n");
	}
	void Wheels_Count() override {
		printf("I have 6 wheels!\n");
	}
	string classname() override {
		return "Truck";
	}
	bool isA(const string& who) override {
		return who == "Truck" || who == "Transport";
	}
	//Имеется в виду разгрузка товаров с грузовой машины
	void Unloading() {
		printf("Товар разгружается\n");
	}
};

int main()
{
	setlocale(LC_ALL, "russian");
	// НЕ ВИРТУАЛЬНЫЕ
	//Засовываем в указатель на класс предок People класс потомка Student
	//Из-за того, что метод who не виртуальный, при попытке вызвать реализацию метода who student, вызывается метод who people. 
	//Также вызывается только деструктор People, так как деструктор по своей сути тоже метод и в классе People он не виртуальный
	/*People* Vasya = new Student();
	Vasya->Who();
	delete Vasya;*/

	// ВИРТУАЛЬНЫЕ
	//Засовываем в указатель на класс предок Transport класс потомка Car
	//Из-за того, что метод Wheels_Count виртуальный, вызывается реализация метода перекрытая в классе Car 
	//Вызываются оба деструктора, так как деструктор тоже виртуальный
	/*Transport* Toyota = new Car();
	Toyota->Wheels_Count();
	delete Toyota*;*/

	//ПРИВЕДЕНИЕ ТИПОВ

	/*const int SIZE = 10;
	Transport* garage[SIZE];
	for (int i = 0; i < 10; i++)
	{
		int rand_value = rand() % 2 + 1;
		if (rand_value == 1)
			garage[i] = new Car();
		else
			garage[i] = new Truck();
	}*/
	//Проверка встроенная в C++

	/*for (int i = 0; i < SIZE; i++)
	{
		Truck* c = dynamic_cast<Truck*>(garage[i]);
		if (c != nullptr)
			c->Unloading();
	}*/

	////Саммостоятельная проверка с помощью isA
	//for (int i = 0; i < SIZE; i++)
	//{
	//	if (garage[i]->isA("Car"))
	//		static_cast<Car*>(garage[i])->FlipFlop();
	//}

	Transport* Toyota = new Car();
	Toyota->method1();
	delete Toyota;
}

