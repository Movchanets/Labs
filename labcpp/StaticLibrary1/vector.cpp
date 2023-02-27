#include "vector.h"


Point::Point() {
    x = 0;
    y = 0;
}

Point::Point(int x, int y) {
    this->x = x;
    this->y = y;
}

int Point::getX() const {
    return x;
}

void Point::setX(int x) {
    this->x = x;
}

int Point::getY() const {
    return y;
}

void Point::setY(int y) {
    this->y = y;
}

std::ostream& operator<<(std::ostream& os, const Point& point) {
    os << "x: " << point.getX() << ", y: " << point.getY() << "\n";
    return os;
}

PolarCoordinates::PolarCoordinates(double r, double q) {
    this->r = r;
    this->q = q;
}

double PolarCoordinates::getR() const {
    return r;
}

void PolarCoordinates::setR(double r) {
    this->r = r;
}

double PolarCoordinates::getQ() const {
    return q;
}

void PolarCoordinates::setQ(double q) {
    this->q = q;
}

Vector::Vector() {
    a = Point();
    b = Point();
}

Vector::Vector(Point a, Point b) {
    this->a = a;
    this->b = b;
}

Point Vector::getA() const {
    return a;
}

void Vector::setA(Point a) {
    this->a = a;
}

Point Vector::getB() const {
    return b;
}

void Vector::setB(Point b) {
    this->b = b;
}

Point Vector::getCords() const {
    return Point(b.getX() - a.getX(), b.getY() - a.getY());
}

PolarCoordinates Vector::getPolarCoordinates() const {
    double r = sqrt(pow(getCords().getX(), 2) + pow(getCords().getY(), 2));
    double q = atan2(getCords().getY(), getCords().getX());
    return PolarCoordinates(r, q);
}

std::ostream& operator<<(std::ostream& os, const Vector& vector)
{
    os << "Point A: " << vector.getA() << "Point B: " << vector.getB() << "Coords: " << vector.getCords() << "Polar: r= "
         << vector.getPolarCoordinates().getR() << " q= " << vector.getPolarCoordinates().getQ() << "\n";
return os;
}