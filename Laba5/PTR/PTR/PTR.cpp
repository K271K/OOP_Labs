#include <iostream>

using namespace std;

class Point {
private:
	int x;
	int y;
public:
	Point() : x(0), y(0) {
		printf("Point()\n");
	}
	Point(int x, int y) : x(x), y(y) {
		printf("Point(int x, int y)\n");
	}
	Point(const Point& t) : x(t.x), y(t.y) {
		printf("Point(const Point &t)\n");
	}
	~Point() {
		printf("~Point()\n");
	}
	void dump() {
		printf("%d, %d\n", x, y);
	}
};

void pass_objectUnique(unique_ptr<Point> p) {
	p->dump();
}

unique_ptr<Point> return_objectUnique(int x, int y) {
	return make_unique<Point>(x, y); //По смыслу return move()
}

shared_ptr<Point> pass_objectShared(shared_ptr<Point> p) {
	p->dump();
	return p;
}

int main() {

	//Передача по умному указателю
	/*unique_ptr<Point> p = make_unique<Point>(1, 2);
	pass_objectUnique(move(p));*/

	//Возврат из функции по умному указателю
	/*unique_ptr<Point> p = return_objectUnique(3,4);*/

	//Shared_ptr
	shared_ptr<Point> p = make_shared<Point>(1, 2);
	p = pass_objectShared(p);
	shared_ptr<Point>p2 = p;
	p2->dump();

	return 0;
}