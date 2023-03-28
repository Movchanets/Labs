#include "vector.h"


void Input(Vector& vector) {
    bool isInt = false;
    int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
    std::cout << "Enter the first point\n";

    std::cout << "Enter x:\n";
    while (!isInt) {
        isInt = static_cast<bool>(std::cin >> x1);
        if (!isInt) {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            std::cout << "Invalid input. Enter an integer value.\n";
        }
    }

    isInt = false;
    std::cout << "Enter y:\n";
    while (!isInt) {
        isInt = static_cast<bool>(std::cin >> y1);
        if (!isInt) {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            std::cout << "Invalid input. Enter an integer value.\n";
        }
    }

    std::cout << "Enter the second point\n";
    std::cout << "Enter x:\n";
    isInt = false;
    while (!isInt) {
        isInt = static_cast<bool>(std::cin >> x2);
        if (!isInt) {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            std::cout << "Invalid input. Enter an integer value.\n";
        }
    }

    std::cout << "Enter y:\n";
    isInt = false;
    while (!isInt) {
        isInt = static_cast<bool>(std::cin >> y2);
        if (!isInt) {
            std::cin.clear();
            std::cout << "Invalid input. Enter an integer value.\n";
        }
    }

    vector.setA(Point(x1, y1));
    vector.setB(Point(x2, y2));
}



class MyClass
{
public:
    void Print (std::string str)
    {
        std::cout << str <<std::endl;
    }
    int o1;
    MyClass() { Print("Standart");  }
    MyClass(int o1) { Print("o1");this->o1 = o1;  }
    MyClass(const MyClass& other) {Print("const");  this->o1 = other.o1;  }
//    MyClass(MyClass obj) {Print("obj"); this->o1 = obj.o1;  }
};
int main(int argc, char* argv[])
{
    MyClass myObj();
  //  MyClass myObj3 = new MyClass();	


    
    // Vector vector;
    // while (true)
    // {
    //     Input(vector);
    //     std::cout << vector << std::endl;
    //     std::cout << "Press any key to continue | Press Enter to exit\n";
    //     std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
    //     if (std::cin.get() == '\n')
    //     {
    //         system("cls"); // clear the console
    //         break;
    //     }
    //     system("cls");
    // }
    // Vector vector1(Point(1, 1), Point(2, 2));
    // std::cout << "vector1 / double" << std::endl;
    // vector1 = vector1 / 2.5;
    // std::cout << vector1 << std::endl;
    // std::cout << "double / vector" << std::endl;
    // vector1 = 1.5 / vector1;
    // std::cout << vector1 << std::endl;
    // Vector vector2(Point(1, 1), Point(2, 2));
    // std::cout << "vector1 + vector2" << std::endl;
    // vector1 = vector1 + vector2;
    // std::cout << vector1 << std::endl;
    // std::cout << "vector>vector2: " << (vector1 > vector2) << std::endl;
    // std::cout << "vector--" << std::endl;
    // std::cout << vector2 << std::endl;
    // std::cout << (vector2--)<< " : returned old value" << std::endl;
    // std::cout << vector2 << " : new value" << std::endl;
    // std::cout << "!vector :" <<std::boolalpha<< !vector2 << std::endl;
    return 0;
}
