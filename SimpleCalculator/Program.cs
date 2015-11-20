using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Parser parse = new Parser();
            Constant constant = new Constant();
            Evaluate evaluate_input = new Evaluate();
            while (true)
            {
                Console.Write("[{0}]", count);
                string input = Console.ReadLine();
                if (input.Length == 1)
                {
                    Console.WriteLine(" = {0} is {1}", input, constant.GetConstant(char.Parse(input)));
                }
                else if (Char.IsLetter(Char.Parse(parse.GetFirst(input))) && parse.GetOperator(input) == '=')
                {
                    constant.AddConstant(Char.Parse(parse.GetFirst(input)), int.Parse(parse.GetSecond(input)));
                    Console.WriteLine("= {0} is {1}", Char.Parse(parse.GetFirst(input)), int.Parse(parse.GetSecond(input)));
                }
                else if (Char.IsLetter(Char.Parse(parse.GetFirst(input))) || Char.IsLetter(Char.Parse(parse.GetSecond(input))))
                {
                    Console.WriteLine("= {0}", evaluate_input.EvaluateInput(input, constant));
                }
                else if (Char.IsDigit(Char.Parse(parse.GetFirst(input))) || Char.IsDigit(Char.Parse(parse.GetSecond(input))))
                {
                    Console.WriteLine("= {0}", evaluate_input.EvaluateInput(input));
                }
                else if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    break;
                }
                count++;
            }
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
