using System;
using CalculadoraApp.Models;
using CalculadoraApp.Views;
using CalculadoraApp.Logic;

namespace CalculadoraApp.Controllers
{
    public class CalculController
    {
        private CalculModel model;
        private CalculView view;
        private CalculLogic logic;

        public CalculController(CalculModel model, CalculView view, CalculLogic logic)
        {
            this.model = model;
            this.view = view;
            this.logic = logic;
        }

        public void RunCalculator()
        {
            model.Operand1 = view.GetOperand("Ingrese el primer número: ");
            model.Operand2 = view.GetOperand("Ingrese el segundo número: ");

            Console.WriteLine("Operaciones disponibles:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.Write("Seleccione una operación (1/2/3/4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    model.Result = logic.Add(model.Operand1, model.Operand2);
                    break;
                case 2:
                    model.Result = logic.Subtract(model.Operand1, model.Operand2);
                    break;
                case 3:
                    model.Result = logic.Multiply(model.Operand1, model.Operand2);
                    break;
                case 4:
                    try
                    {
                        model.Result = logic.Divide(model.Operand1, model.Operand2);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    return;
            }

            view.ShowResult(model.Result);
        }
    }
}