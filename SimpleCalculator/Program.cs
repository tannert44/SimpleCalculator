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
            Char result1;
            Char result2;
            int result3;
            int result4;
            
            while (true)
            {
                Console.Write("[{0}]", count);
                string input = Console.ReadLine();
                if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    break;
                }
                bool testIfFirstIsChar = Char.TryParse(parse.GetFirst(input), out result1);
                bool testIfSecondIsChar = Char.TryParse(parse.GetSecond(input), out result2);
                bool testIfFirstIsNum = int.TryParse(parse.GetFirst(input), out result3);
                bool testIfSecondIsNum = int.TryParse(parse.GetSecond(input), out result4);
                if (input.Length == 1)
                {
                    Console.WriteLine(" = {0} is {1}", input, constant.GetConstant(char.Parse(input)));
                }
                else if (testIfFirstIsChar && !testIfFirstIsNum && parse.GetOperator(input) == '=')
                {
                    constant.AddConstant(result1, result4);
                    Console.WriteLine("= '{0}' is '{1}' ", result1, result4);
                }
                else if (testIfFirstIsChar && !testIfFirstIsNum && testIfSecondIsNum || testIfSecondIsChar && !testIfSecondIsNum && testIfFirstIsNum || !testIfFirstIsNum && !testIfSecondIsNum)
                {
                    Console.WriteLine("= {0}", evaluate_input.EvaluateInput(input, constant));
                }
                else if (testIfFirstIsNum && testIfSecondIsNum)
                {
                    Console.WriteLine("= {0}", evaluate_input.EvaluateInput(input));
                }
                count++;
            }
        }
    }
}
