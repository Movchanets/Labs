#include "vector.h"


Point::Point() {
    x = 0;
    y = 0;
}



double Point::getX() const {
    return x;
}

void Point::setX(double x) {
    this->x = x;
}

double Point::getY() const {
    return y;
}

void Point::setY(double y) {
    this->y = y;
}

bool Point::operator!() const
{ 
        return this->x == 0 && this->y == 0;
}

std::ostream& operator<<(std::ostream& os, const Point& point) {
    os << "x: " << point.getX() << ", y: " << point.getY() << "\n";
    return os;
}

Vector operator/(double number, Vector& vector)
{
    Vector result(vector);
    result.b.setX(result.b.getX() / number);
    result.b.setY(result.b.getY() / number);
    return result;
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


Vector Vector::operator/(double number) const
{
    Vector result(*this);
    result.b.setX(result.b.getX() / number);
    result.b.setY(result.b.getY() / number);
    return result;
}

Vector Vector::operator+(const Vector& other) const
{
    Vector result(*this);
    result.a.setX(result.a.getX() + other.a.getX());
    result.a.setY(result.a.getY() + other.a.getY());
    result.b.setX(result.b.getX() + other.b.getX());
    result.b.setY(result.b.getY() + other.b.getY());
    return result;
}

bool Vector::operator>(const Vector& other) const
{
    return this->Length() > other.Length();
}

bool Vector::operator<(const Vector& other) const
{
    return this->Length() < other.Length();
}

double Vector::Length() const
{
    return sqrt(pow(getCords().getX(), 2) + pow(getCords().getY(), 2));
}



bool Vector::operator!() const
{
    return !this->a || !this->b;
}

Vector Vector::operator--(int)
{
    Vector result(*this);
    b.setX(b.getX() - 1);
    b.setY(b.getY() - 1);
    return result;
}

Vector::Vector() {
    a = Point();
    b = Point();
}

Vector::Vector(Vector& vector)
{
    this->a = vector.getA();
    this->b = vector.getB();
}

Vector::Vector(const Vector& vector)
{
    this->a = vector.getA();
    this->b = vector.getB();
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