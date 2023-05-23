
#include <string>
#include <vector>
#include "Solver.h"

int main(int argc, char* argv[])
{
   
        std::vector<Solver> solvers;

        bool exit = false;
        while (!exit) {
            std::cout << "Enter values  (or 'exit'):" << std::endl;

            std::cout << "a = ";
            std::string inputA;
            std::cin >> inputA;

            if (inputA == "exit") {
                exit = true;
                continue;
            }

            std::cout << "c = ";
            std::string inputC;
            std::cin >> inputC;

            if (inputC == "exit") {
                exit = true;
                continue;
            }

            std::cout << "d = ";
            std::string inputD;
            std::cin >> inputD;

            if (inputD == "exit") {
                exit = true;
                continue;
            }

            double a, c, d;

            try {
                a = std::stod(inputA);
                c = std::stod(inputC);
                d = std::stod(inputD);
            }
            catch (const std::exception& e) {
                std::cout << "Invalid number format. No input will be added." << std::endl;
                continue;
            }

            try {
                Solver performer(a, c, d);
                solvers.push_back(performer);
            }
            catch (const std::exception& e) {
                std::cout << e.what() << std::endl;
            }
        }

        std::cout << "\nResults:" << std::endl;

        for (size_t i = 0; i < solvers.size(); i++) {
            double result = solvers[i].GetValue();
            std::cout << "Result : " << i + 1 << ": " << result << std::endl;
        }

        return 0;
    
}
