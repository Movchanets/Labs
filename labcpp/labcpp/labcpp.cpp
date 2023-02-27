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

int main(int argc, char* argv[])
{
    Vector vector;
    while (true)
    {
        Input(vector);
        std::cout << vector << std::endl;
        std::cout << "Press any key to continue | Press Enter to exit\n";
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
        if (std::cin.get() == '\n')
        {
            system("cls"); // clear the console
            break;
        }
        system("cls");
    }
    return 0;
}
