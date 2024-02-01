using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorWinForms
{
    public class ViewModel
    {
        ArithmeticParser parser;
        Evaluator evaluator;

        public ViewModel()
        {
            parser = new ArithmeticParser();
            evaluator = new Evaluator();
        }

        public string Evaluate(string equation)
        {
            // Проверить на скобочную последовательность
            // Проверить порядок знаков ++++

            List<string> postfix = parser.Parse(equation.Split(' '));
            return Convert.ToString(evaluator.Evaluate(postfix.ToArray()));

        }
    }
}
