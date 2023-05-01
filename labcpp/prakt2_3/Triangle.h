#pragma once

class Triangle : public Figure
{
private:
    double _x1, _y1, _x2, _y2, _x3, _y3;

public:
    Triangle(const double x1, const double y1, const double x2, const double y2, const double x3, const double y3)
    {
        this->_x1 = x1;
        this->_y1 = y1;
        this->_x2 = x2;
        this->_y2 = y2;
        this->_x3 = x3;
        this->_y3 = y3;
    }

    virtual double Area()
    {
        return std::abs((_x1 * (_y2 - _y3) + _x2 * (_y3 - _y1) + _x3 * (_y1 - _y2)) / 2);
    }

    virtual double Perimeter()
    {
        auto a = std::sqrt(std::pow(_x2 - _x1, 2) + std::pow(_y2 - _y1, 2));
        auto b = std::sqrt(std::pow(_x3 - _x2, 2) + std::pow(_y3 - _y2, 2));
        auto c = std::sqrt(std::pow(_x1 - _x3, 2) + std::pow(_y1 - _y3, 2));
        return a + b + c;
    }
};

