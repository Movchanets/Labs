#include <iostream>
#include "Figure.h"
#include "Triangle.h"
#include "Circle.h"

int main()
{
    Figure* figure = nullptr;

    while (true)
    {
        std::cout << "Select a figure:\n";
        std::cout << "1 - Triangle\n";
        std::cout << "2 - Circle\n";
        std::cout << "3 - Exit\n";

        int choice;
        std::cin >> choice;

        switch (choice)
        {
        case 1:
            {
                std::cout << "Enter the coordinates of the triangle vertices (x1 y1 x2 y2 x3 y3): ";
                double x1, y1, x2, y2, x3, y3;
                std::cin >> x1 >> y1 >> x2 >> y2 >> x3 >> y3;

                figure = new Triangle(x1, y1, x2, y2, x3, y3);
                break;
            }
        case 2:
            {
                std::cout << "Enter the radius of the circle: ";
                double radius;
                std::cin >> radius;

                figure = new Circle(radius);
                break;
            }
        case 3:
            return 0;
        default:
            std::cout << "Invalid choice\n";
            break;
        }

        if (figure != nullptr)
        {
            bool exit = false;
            while (!exit)
            {
                std::cout << "Select a function:\n";
                std::cout << "1 - Area\n";
                std::cout << "2 - Perimeter\n";
                std::cout << "3 - Exit\n";

                int function;
                std::cin >> function;

                switch (function)
                {
                case 1:
                    std::cout << "Area of the figure: " << figure->Area() << std::endl;
                    break;
                case 2:
                    std::cout << "Perimeter of the figure: " << figure->Perimeter() << std::endl;
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    std::cout << "Invalid choice\n";
                    break;
                }
            }
            delete figure; // звільнення пам'яті
            figure = nullptr;
        }
    }
    return 0;
}
