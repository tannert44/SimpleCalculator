using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Parser
    {
        public string GetFirst(string input)
        {
            string string_result = "";
            int letter_count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input.StartsWith("-"))
                {
                    string_result += input[i];
                    continue;
                }
                if (Char.IsLetter(input[i]))
                {
                    letter_count++;
                }
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/' || input[i] == '%' || input[i] == '='|| letter_count >= 2)
                {
                    break;
                }
                string_result += input[i];
            }
            if (letter_count >= 2)
            {
                throw new FormatException();
            }
            return string_result.TrimEnd(' ');
        }

        public Char GetOperator(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input.StartsWith("-"))
                {
                    continue;
                }
                else
                {
                    if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/' || input[i] == '%' || input[i] == '=')
                    {
                        return input[i];
                    }
                }
            }
            throw new FormatException();
        }

        public string GetSecond(string input)
        {
            string string_result = "";
            int letter_count = 0;
            int operator_index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input.StartsWith("-"))
                {
                    continue;
                }
                else if (input[i] > operator_index && operator_index != 0)
                {
                    if (Char.IsLetter(input[i]))
                    {
                        letter_count++;
                    }
                    string_result += input[i];
                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/' || input[i] == '%' || input[i] == '=')
                {
                    if (operator_index == 0)
                    {
                        operator_index = i;
                    }
                }
                
            }
            if (letter_count >= 2)
            {
                throw new FormatException();
            }
            return string_result.TrimStart(' ');
        }
    }
}
