#pragma once

#include <iostream>
#include <cmath>

class Point {
private:
    int x;
    int y;
public:
    Point();
    Point(int x, int y);
    int getX() const;
    void setX(int x);
    int getY() const;
    void setY(int y);
    friend std::ostream& operator<<(std::ostream& os, const Point& point);
};

class PolarCoordinates {
private:
    double r;
    double q;
public:
    PolarCoordinates(double r, double q);
    double getR() const;
    void setR(double r);
    double getQ() const;
    void setQ(double q);
};

class Vector {
private:
    Point a;
    Point b;
public:
    Vector();
    Vector(Vector& vector);
    Vector(Point a, Point b);
    Point getA() const;
    void setA(Point a);
    Point getB() const;
    void setB(Point b);
    Point getCords() const;
    PolarCoordinates getPolarCoordinates() const;
    friend std::ostream& operator<<(std::ostream& os, const Vector& vector);
};


