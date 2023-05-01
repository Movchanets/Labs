#pragma once
#include "Figure.h"

class Circle : public Figure
{
private:
    double radius;

public:
    Circle(double radius)
    {
        this->radius = radius;
    }

    virtual double Area()
    {
        return M_PI * radius * radius;
    }

    virtual double Perimeter()
    {
        return 2 * M_PI * radius;
    }
}; 

