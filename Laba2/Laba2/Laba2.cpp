#include <iostream>

using namespace std;

//Создание класса
class Point {
protected:
    int x, y;
public:
    Point(): x(0), y(0) {
        printf("Point()\n");
    }
    Point(int x, int y) : x(x), y(y) {
        printf("Point(int x, int y)\n");
    }
    Point(const Point& p): x(p.x), y(p.y) {
        printf("Point(const Point& p)\n");
    }
    ~Point() {
        printf("~Point(%d, %d)\n", x,y);
    }
    void shift(int dx, int dy) {
        x += dx;
        y += dy;
    }
    void reset();
    void showCords();
};

void Point::reset() {
    x = 0;
    y = 0;
}

void Point::showCords() {
    printf("(%d, %d)\n", x, y);
}

//Наследование
class NamedPoint: public Point {
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
    void changeName(char newName) {
        Name = newName;
    }
};

//Композиция без указателя
class Triangle {
public:
    Point firstP;
    Point secondP;
    Point thirdP;
    Triangle() {
        printf("Triangle()\n");
    }
    Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : firstP(x1, y1), secondP(x2, y2), thirdP(x3, y3) {
        printf("Triangle(int x1, int y1, int x2, int y2, int x3, int y3)\n");
    }
    Triangle(const Triangle& t) : firstP(t.firstP), secondP(t.secondP), thirdP(t.thirdP) {
        printf("Triangle(const Triangle &t)\n");
    }
    ~Triangle() {
        printf("~Triangle()\n");
    }

    void showCordsTriangle() {
        firstP.showCords();
        secondP.showCords();
        thirdP.showCords();
    }

    void shiftTriangle(int dx, int dy) {
        firstP.shift(dx, dy);
        secondP.shift(dx, dy);
        thirdP.shift(dx, dy);
    }
};


////Композиция с указателями
class Section {
public:
    Point* Pstart;
    Point* Pend;
    Section() {
        printf("Section()\n");
    }
    Section(int x1, int y1, int x2, int y2) : Pstart(new Point(x1, y1)), Pend(new Point(x2, y2)) {
        printf("Section(int x1, int y1, int x2, int y2\n");
    }
    Section(const Section& t) : Pstart(new Point(*t.Pstart)), Pend(new Point(*t.Pend)) {
        printf("Section(const Section &t)\n");
    }
    ~Section() {      
        printf("~Section()\n");
        delete Pstart;
        delete Pend;
    }
};

int main()
{
    //Динамическое создание и вызов методов
    /*NamedPoint* p = new NamedPoint(1, 2, 'C');
    p->reset();
    p->shift(10, 10);
    delete p;*/

    //Помещение объектов в переменные различных типов
    /*Point* p1 = new NamedPoint(3,3,'A');
    NamedPoint* p2 = new NamedPoint(1, 1, 'B');
    delete p1;
    delete p2;*/

    return 0;
}

