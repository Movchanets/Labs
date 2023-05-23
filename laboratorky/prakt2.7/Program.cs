

class Program
{
    class Solver
    {
        private double a;
        private double c;
        private double d;  
        private double result;
        public Solver(double a, double c, double d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
            result = CalculateExpression();
        }

        public void SetValues(double a, double c, double d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
            result = CalculateExpression();
        }

        private double CalculateExpression()
        {
            try
            {   if(2*c -a <= 0) {throw new ArgumentException("Аргумент логарифма не може бути від'ємним");} 
                if((a / 4 + c) ==0) {throw new DivideByZeroException("Ділення на нуль");}
                double result = (Math.Log10(2 * c - a) + d - 152) / (a / 4 + c);
                return result;
            }
            catch (Exception ex)
            {
                // Обробка виняткових ситуацій
                Console.WriteLine("Помилка обчислення виразу: " + ex.Message);
                return double.NaN; // Повернення NaN у разі помилки
            }
        }

        public double GetValue()
        {
            return result;
        }
    }
    static void Main(string[] args)
    {
        List<Solver> Solvers = new List<Solver>();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Введіть значення для обчислення виразу (або 'exit' для виходу):");

            Console.Write("a = ");
            string inputA = Console.ReadLine();

            if (inputA.ToLower() == "exit")
            {
                exit = true;
                continue;
            }

            Console.Write("c = ");
            string inputC = Console.ReadLine();

            if (inputC.ToLower() == "exit")
            {
                exit = true;
                continue;
            }

            Console.Write("d = ");
            string inputD = Console.ReadLine();

            if (inputD.ToLower() == "exit")
            {
                exit = true;
                continue;
            }

            double a, c, d;

            if (!double.TryParse(inputA, out a) || !double.TryParse(inputC, out c) || !double.TryParse(inputD, out d))
            {
                Console.WriteLine("Невірний формат числа. Введення не буде додано.");
                continue;
            }

            try
            {
                Solver performer = new Solver(a, c, d);
                Solvers.Add(performer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        Console.WriteLine("\nРезультати обчислення виразу:");

        for (int i = 0; i < Solvers.Count; i++)
        {
            double result = Solvers[i].GetValue();
            Console.WriteLine($"Результат обчислення виразу {i + 1}: {result}");
        }
    }
    }

