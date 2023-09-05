using System;
using CalculadoraApp.Controllers;
using CalculadoraApp.Logic;
using CalculadoraApp.Models;
using CalculadoraApp.Views;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculModel model = new CalculModel();
            CalculView view = new CalculView();
            CalculLogic logic = new CalculLogic();
            CalculController controller = new CalculController(model, view, logic);

            controller.RunCalculator();

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
