#pragma once

#include <iostream>
#include <cmath>

class Point {
private:
    double x;
    double y;
public:
    Point();
    Point(double x, double y) : x(x), y(y) {}
    double getX() const;
    void setX(double x);
    double getY() const;
    void setY(double y);
    bool operator!() const;
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
    Vector operator/(double number) const ;

    friend Vector operator/(double number,  Vector& vector) ;

    Vector operator+(const Vector& other) const ;

    bool operator>(const Vector& other) const ;

    bool operator<(const Vector& other) const;
    double Length() const ;
    bool operator!() const ;
    Vector operator--(int);
    Vector();
    Vector(Vector& vector);
    Vector(const Vector& vector);
    Vector(Point a, Point b);
    Point getA() const;
    void setA(Point a);
    Point getB() const;
    void setB(Point b);
    Point getCords() const;
    PolarCoordinates getPolarCoordinates() const;
    friend std::ostream& operator<<(std::ostream& os, const Vector& vector);
};


