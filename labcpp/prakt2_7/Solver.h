#pragma once
#include <iostream>
#include <stdexcept>

class Solver {
private:
    double a;
    double c;
    double d;
    double result;

public:
    Solver(double a, double c, double d);

    void SetValues(double a, double c, double d);

    double CalculateExpression() const;

    double GetValue() const;
};
