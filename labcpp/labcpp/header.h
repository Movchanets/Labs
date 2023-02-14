#pragma once
#include <sstream>
#include <string>


class Point
{
public:
    int x;
    int y;
    int GetX() const;
    int GetY() const;

    Point(const int x, const int y): x(x), y(y){}
    Point() {  }
    ~Point() {  }
    std::string to_string() const;
};

class Vector
{
public:
    Point Cords;
    Point A;
    Point B;


    std::pair<double, double> PolarCoorditates() const;
    ~Vector() {  }

    Vector(const Point a, const Point b);

    std::string to_string() const;
};
