namespace CalculadoraApp.Logic
{
    public class CalculLogic
    {
        public double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public double Subtract(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        public double Multiply(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        public double Divide(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                throw new System.ArgumentException("No se puede dividir por cero.");
            }
            return operand1 / operand2;
        }
    }
}
