#pragma once
#define _USE_MATH_DEFINES
#include <math.h>
#include <locale>
class Figure
{
public:
    virtual double Area()
    {
        return 0;
    }

    virtual double Perimeter()
    {
        return 0;
    }
};
