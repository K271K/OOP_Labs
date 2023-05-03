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
};
class Car: public Transport {
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
};

class Base {
public:
	Base() {
		printf("Base ( ) \n");
	}
	virtual ~Base() {
		printf("~Base ( ) \n");
	}
	void method1() {
		method2();
	}
	virtual void method2() {
		printf("Base::method2()\n");
	}

};

class Desc: public Base {
public:
	Desc() {
		printf("Desc ( ) \n");
	}
	~Desc() {
		printf("~Desc ( ) \n");
	}
	void method2() {
		printf("Desc::method2()\n");
	}

};


int main()
{
	//Засовываем в указатель на класс предок People класс потомка Student
	//Из-за того, что метод who не виртуальный, при попытке вызвать реализацию метода who student, вызывается метод who people. 
	//Также вызывается только деструктор People, так как деструктор по своей сути тоже метод и в классе People он не виртуальный
	/*People* Vasya = new Student();
	Vasya->Who();
	delete Vasya;*/

	//Засовываем в указатель на класс предок People класс потомка Student
	//Из-за того, что метод who не виртуальный, при попытке вызвать реализацию метода who student, вызывается метод who people. 
	//Также вызывается только деструктор People, так как деструктор по своей сути тоже метод и в классе People он не виртуальный
	/*Transport* Toyota = new Car();
	Toyota->Wheels_Count();
	delete Toyota;*/

	//Функции которые вызывают внутри себя другие функции
	Base* a = new Desc();
	a->method1();
	delete a;


}

