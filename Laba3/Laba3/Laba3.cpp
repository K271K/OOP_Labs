#include <iostream>


class List {
public:
    List() {
        printf("List()\n");
    }
    ~List() {
        printf("~List()\n");
    }
private:

    template<typename T>
    struct Node {
    public:

        Node(T data = T(), Node pNext = nullptr) : data(data), pNext(pNext) {
             printf("Node(T data, Node pNext)\n")
        }

        Node* pNext;
        T data;
    };
};

int main()
{
    std::cout << "Hello World!\n";
}

