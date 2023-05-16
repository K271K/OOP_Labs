#include <iostream>
#include <string>

using namespace std;

//BaseDesc
class Base{
protected:
	string name;
public:
	// конструктор по умолчанию
	Base(){
		name = "";
		printf("#%d Base() name=\"%s\" \n", int(this) % 1000, name.c_str());
	}
	// конструктор с параметром
	Base(string str) {
		name = str;
		printf("%d Base(string str) name=\"%s\"\n", int(this) % 1000, name.c_str());	
	}
	// конструктор копирования
	Base(const Base& obj) {
		this->name = obj.name;
		printf("%d Base(const Base& obj) name=\"%s\" from object #%d\n", int(this) % 1000, name.c_str(), (int)&obj % 1000);
	};
	// конструктор с параметром-указателем для копирования 
	Base(Base* obj) {
		this->name = obj->name;
		printf("%d Base(Base* obj) name=\"%s\" from object #%d\n", int(this) % 1000, name.c_str(), (int)obj % 1000);	
	};
	virtual ~Base() {
		printf("#%d ~Base() name=\"%s\"\n", (int)this % 1000, name.c_str());
	}
};

class Desc : public Base {
public:
	// конструктор по умолчанию
	Desc() {
		name = "";
		printf("#%d Desc() name=\"%s\"\n", int(this) % 1000, name.c_str());
	}
	// конструктор с параметром
	Desc(string str) {
		name = str;
		printf("%d Desc(string str) name=\"%s\"\n", int(this) % 1000, name.c_str());
	}
	// конструктор копирования
	Desc(const Desc& obj) {
		this->name = obj.name;
		printf("%d Desc(const Desc& obj) name=\"%s\" from object #%d\n", int(this) % 1000, name.c_str(), (int)&obj % 1000);
	};
	// конструктор с параметром-указателем для копирования 
	Desc(Desc* obj) {
		this->name = obj->name;
		printf("%d Desc(Desc* obj) name=\"%s\" from object #%d\n", int(this) % 1000, name.c_str(), (int)obj % 1000);
	};
	void DescCheck() {
		printf("It's a Desc\n");
	}
	virtual ~Desc() {
		printf("#%d ~Desc() name=\"%s\"\n", (int)this % 1000, name.c_str());
	}
};

//С помощью конструктора копирования создается локальная копия внутри функции и после выхода из функции она удаляется.
void in1(Base obj) {
	printf("Inside func1\n");
	//Преобразование указателя Base на указатель Desc внутри функции
	/*Desc* c = dynamic_cast<Desc*>(&obj);
	if (c != nullptr)
		c->DescCheck();*/
};
void in2(Base* obj) {
	printf("Inside func2\n");
	
};
void in3(Base& obj) {
	printf("Inside func3\n");
};



int main()	{
	setlocale(LC_ALL, "Russian");

	//TEST1
	/*Base t1;
	Base t2("hello");
	Base t3(t2);
	Base t4(&t3);
	Base t5 = t2;*/

	//TEST2
	//Base* t0; -- не комплируется 
	//Base* t1 = new Base;
	//Base* t2 = new Base("Hello");
	//Base* t3 = new Base(t2);
	//Base* t4 = new Base(*t3);
	//Base* t5 = t2;
	////delete t0; -- не компилируется
	//delete t1;
	//delete t2;
	//delete t3;
	//delete t4;
	//delete t5;
	//return 0;

	//TEST3
	/*Base("HelloWorld");
	Base t1("Hello");
	t1 = Base("World");
	Base t2 = Base("Wierd");
	printf("\n");*/

	//TEST4 in1,2,3
	/*Base o("o");
	Base* po = new Base("po");
	cout << "\nBefore func1(o)\n";
	in1(o);
	cout << "After func1(o)\n";
	cout << "\nBefore func2(&o)\n";
	in2(&o);
	cout << "After func2(&o)\n";
	cout << "\nBefore func3(o)\n";
	in3(o);
	cout << "After func2(&o)\n";
	cout << "\nBefore func1(*po)\n";
	in1(*po);
	cout << "After func1(*po)\n";
	cout << "\nBefore func2(po)\n";
	in2(po);
	cout << "After func2(po)\n";
	cout << "\nBefore func3(*po)\n";
	in3(*po);
	cout << "After func3(*po)\n";
	delete po;*/

}
