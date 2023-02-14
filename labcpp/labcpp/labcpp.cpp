#include <iostream>

#include "header.h";
 int Point::GetX() const
{
    return x;
}
 int Point::GetY() const
{
    return y;
}
Vector::Vector(const Point a, const Point b): A(a), B(b)
 {
     Cords = Point(b.x - a.x, b.y - a.y);
 }
std::pair<double, double> Vector::PolarCoorditates() const
 {
     double r = sqrt((pow(Cords.x, 2)) + pow(Cords.y, 2));
     double q = atan2(Cords.y, Cords.x);

     return {q, r};
 }

std::string Point::to_string() const
 {
     std::ostringstream s ;
     s << "X: " << x <<" ,Y: " <<y<<std::endl;
     return s.str();
 };

std::string Vector::to_string() const
{   auto t = PolarCoorditates();
    std::ostringstream s ;
    s << "Point A: " << A.to_string() <<"Point B: " << B.to_string()<< "Coords: " << Cords.to_string()
    <<"Polar: r=" << t.first <<" q=" << t.second << std::endl;
    return s.str();
};
int main(int argc, char* argv[])
{
    auto* v = new Vector(Point(1,5),Point(3,7));
    std::cout << v->to_string()<<std::endl;
    delete v;
    return 0;
}
