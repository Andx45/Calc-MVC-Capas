using System;

namespace CalculadoraApp.Views
{
    public class CalculView
    {
        public void ShowResult(double result)
        {
            Console.WriteLine($"Resultado: {result}");
        }

        public double GetOperand(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
