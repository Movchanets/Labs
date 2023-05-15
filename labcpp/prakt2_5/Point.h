#pragma once
template <typename T>
class Point
{
private:
    T x;
    T y;

public:
    Point() : x(0), y(0)
    {
    }

    Point(T x, T y) : x(x), y(y)
    {
    }


    T getX() const { return x; }
    T getY() const { return y; }


    void setX(T x) { this->x = x; }
    void setY(T y) { this->y = y; }
};