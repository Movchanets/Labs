#include <iostream>
#include "Triangle.h"

int main(int argc, char* argv[]) {
    std::cout << "Welcome to the Triangle creator!" << std::endl;
    setlocale(LC_ALL, "Ukrainian");
    while (true) {
        std::cout << "Enter the type of data for the points (int/double) or exit: ";
        std::string dataType;
        std::cin >> dataType;

        if (dataType == "int") {
            int x1, y1, x2, y2, x3, y3;
            std::cout << "Enter the coordinates of the first point (x,y): ";
            std::cin >> x1 >> y1;
            std::cout << "Enter the coordinates of the second point (x,y): ";
            std::cin >> x2 >> y2;
            std::cout << "Enter the coordinates of the third point (x,y): ";
            std::cin >> x3 >> y3;
            
            Point<int> p1(x1, y1);
            Point<int> p2(x2, y2);
            Point<int> p3(x3, y3);

            try {
                Triangular<int> triangle(p1, p2, p3);
                std::cout << "Triangle created:" << std::endl;
                std::cout << triangle.toString() << std::endl;
            }
            catch (std::exception& e) {
                std::cout << e.what() << std::endl;
            }
         
            
         
        }
        else if (dataType == "double") {
            double x1, y1, x2, y2, x3, y3;
            std::cout << "Enter the coordinates of the first point (x,y): ";
            std::cin >> x1 >> y1;
            std::cout << "Enter the coordinates of the second point (x,y): ";
            std::cin >> x2 >> y2;
            std::cout << "Enter the coordinates of the third point (x,y): ";
            std::cin >> x3 >> y3;
            
            Point<double> p1(x1, y1);
            Point<double> p2(x2, y2);
            Point<double> p3(x3, y3);
            
            try {
                Triangular<double> triangle(p1, p2, p3);
                std::cout << "Triangle created:" << std::endl;
                std::cout << triangle.toString() << std::endl;
            }
            catch (std::exception& e) {
                std::cout << e.what() << std::endl;
            }
        }
        else if (dataType == "exit") {
            std::cout << "Exiting Triangle creator." << std::endl;
            break;
        }
        else {
            std::cout << "Invalid input, please enter 'int', 'double', or 'exit'." << std::endl;
        }
    }

    return 0;
}
