#pragma once
#include <complex>
#include "Point.h"
template <typename T>
class Triangular
{
public:
    Triangular(Point<T> p1, Point<T> p2, Point<T> p3) : p1_(p1), p2_(p2), p3_(p3)
    {
        // перевірка, чи утворюють точки трикутник
        if (!IsTriangle())
        {
            throw std::invalid_argument("Invalid triangle coordinates.");
        }
        // ініціалізація довжин сторін трикутника
        a_ = Distance(p1_, p2_);
        b_ = Distance(p2_, p3_);
        c_ = Distance(p3_, p1_);
    }

    // методи-властивості
    double GetA() const { return a_; }
    double GetB() const { return b_; }
    double GetC() const { return c_; }

    // методи для обчислення периметру та площі
    double Perimeter() const
    {
        return a_ + b_ + c_;
    }

    double Area() const
    {
        double p = Perimeter() / 2;
        return sqrt(p * (p - a_) * (p - b_) * (p - c_));
    }

    // метод для визначення типу трикутника
    std::string TypeOfTriangle() const
    {
        if (a_ == b_ && b_ == c_)
        {
            return "Рівносторонній";
        }
        else if (a_ * a_ == b_ * b_ + c_ * c_ || b_ * b_ == a_ * a_ + c_ * c_ || c_ * c_ == a_ * a_ + b_ * b_)
        {
            return "Прямокутний";
        }
        else if (a_ == b_ || b_ == c_ || a_ == c_)
        {
            return "Рівнобедрений";
        }

        else
        {
            return "Різносторонній";
        }
    }

    // методи для зміни точок трикутника
    void SetP1(Point<T> p)
    {
        p1_ = p;
        a_ = Distance(p1_, p2_);
        c_ = Distance(p3_, p1_);
    }

    void SetP2(Point<T> p)
    {
        p2_ = p;
        a_ = Distance(p1_, p2_);
        b_ = Distance(p2_, p3_);
    }

    void SetP3(Point<T> p)
    {
        p3_ = p;
        b_ = Distance(p2_, p3_);
        c_ = Distance(p3_, p1_);
    }
    std::string toString() const {
        std::ostringstream oss;
        oss << "Triangle vertices: (" << p1_.getX() << ", " << p1_.getY() << "), "
            << "(" << p2_.getX() << ", " << p2_.getY() << "), "
            << "(" << p3_.getX() << ", " << p3_.getY() << ")" << std::endl
            << "Side lengths: " << a_ << ", " << b_ << ", " << c_ << std::endl
            << "Perimeter: " << Perimeter() << std::endl
            << "Area: " << Area() << std::endl
            << "Triangle type: " << TypeOfTriangle() << std::endl;
        return oss.str();
    }

private:
    Point<T> p1_, p2_, p3_; // вершини трикутника
    double a_, b_, c_; // довжини сторін

    // визначення довжини відрізка між двома точками
    double Distance(Point<T> p1, Point<T> p2) const
    {
        double dx = p2.getX() - p1.getX();
        double dy = p2.getY() - p1.getY();
        return sqrt(dx * dx + dy * dy);
    }

    // перевірка, чи утворюють точки трикутник
    bool IsTriangle() const
    {
        double a = Distance(p1_, p2_);
        double b = Distance(p2_, p3_);
        double c = Distance(p3_, p1_);
        return a + b > c && a + c > b && b + c > a;
    }
};
