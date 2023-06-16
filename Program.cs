using System;

class Program
{
    static void Main()
    {
        double x = GetDouble("Podaj wartość x: ");
        int n = GetNumber("Podaj liczbę wyrazów do uwzględnienia w szeregu Taylora: ");

        double result = CalculateExponential(x, n);

        Console.WriteLine($"Szacowana wartość funkcji e^{x} wynosi: {result}");

        Console.ReadKey();
    }

    static double CalculateExponential(double x, int n)
    {
        double sum = 0.0;

        for (int i = 0; i <= n; i++)
        {
            double term = Math.Pow(x, i) / Factorial(i);
            sum += term;
        }

        return sum;
    }

    static double Factorial(int number)
    {
        double factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static double GetDouble(string message)
    {
        double number;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                break;
            }
            Console.WriteLine("Błędne dane. Podaj poprawną liczbę.");
        }

        return number;
    }

    static int GetNumber(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
            {
                break;
            }
            Console.WriteLine("Błędne dane. Podaj liczbę naturalną.");
        }

        return number;
    }
}
