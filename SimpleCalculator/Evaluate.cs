using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public int EvaluateInput(string input)
        {
            Parser parse = new Parser();
            Add add_input = new Add();
            Subtract subtract_input = new Subtract();
            Multiply multiply_input = new Multiply();
            Divide divide_input = new Divide();
            Modulo modulo_input = new Modulo();
            if (parse.GetOperator(input) == '+')
            {
               return add_input.AddItems(input);
            }
            if (parse.GetOperator(input) == '-')
            {
                return subtract_input.SubtractItems(input);
            }
            if (parse.GetOperator(input) == '*')
            {
                return multiply_input.MultiplyItems(input);
            }
            if (parse.GetOperator(input) == '/')
            {
                return divide_input.DivideItems(input);
            }
            if (parse.GetOperator(input) == '%')
            {
                return modulo_input.ModuloItems(input);
            }
            throw new FormatException();         
        }

        public int EvaluateInput(string input, Constant constant)
        {
            Parser parse = new Parser();
            Add add_input = new Add();
            Subtract subtract_input = new Subtract();
            Multiply multiply_input = new Multiply();
            Divide divide_input = new Divide();
            Modulo modulo_input = new Modulo();
            if (parse.GetOperator(input) == '+')
            {
                return add_input.AddConstants(input, constant);
            }
            if (parse.GetOperator(input) == '-')
            {
                return subtract_input.SubtractConstants(input, constant);
            }
            if (parse.GetOperator(input) == '*')
            {
                return multiply_input.MultiplyConstants(input, constant);
            }
            if (parse.GetOperator(input) == '/')
            {
                return divide_input.DivideConstants(input, constant);
            }
            if (parse.GetOperator(input) == '%')
            {
                return modulo_input.ModuloConstants(input, constant);
            }
            throw new FormatException();
        }
    }
}
