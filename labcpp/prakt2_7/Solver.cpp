#include "Solver.h"

Solver::Solver(double a, double c, double d)
{
    this->a = a;
    this->c = c;
    this->d = d;
    result = CalculateExpression();
}

void Solver::SetValues(double a, double c, double d)
{
    this->a = a;
    this->c = c;
    this->d = d;
    result = CalculateExpression();
}

double Solver::CalculateExpression() const
{
    try {
        if (2 * c - a <= 0) {
            throw std::invalid_argument("Logarifm cannot be calculated");
        }
        if ((a / 4 + c) == 0) {
            throw std::runtime_error("Division by zero");
        }
        double result = (log10(2 * c - a) + d - 152) / (a / 4 + c);
        return result;
    }
    catch (const std::exception& ex) {
        std::cout << "Error : " << ex.what() << std::endl;
        return NAN; 
    }
}

double Solver::GetValue() const
{
    return result;
}
