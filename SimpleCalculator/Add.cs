using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Add
    {
        public int AddItems(string input)
        {
            Parser parse = new Parser();
            int firstItem = Int32.Parse(parse.GetFirst(input));
            int secondItem = Int32.Parse(parse.GetSecond(input));
            return firstItem + secondItem;
        }

        public int AddConstants(string input, Constant constant)
        {
            Parser parse = new Parser();
            int constant_value;
            int number_value;
            Char result1;
            Char result2;
            int result3;
            int result4;
            bool test1 = Char.TryParse(parse.GetFirst(input), out result1);
            bool test2 = Char.TryParse(parse.GetSecond(input), out result2);
            bool test3 = int.TryParse(parse.GetFirst(input), out result3);
            bool test4 = int.TryParse(parse.GetSecond(input), out result4);
            if (test1 && !test3 && test4)
            {
                constant_value = constant.GetConstant(result1);
                number_value = result4;
            }
            else if (test2 && !test4 && test3)
            {
                constant_value = constant.GetConstant(result2);
                number_value = result3;
            }
            else if (test1 && test2 && !test3 && !test4)
            {
                constant_value = constant.GetConstant(result1);
                number_value = constant.GetConstant(result2);
            }
            else
            {
                throw new FormatException();
            }
            return constant_value + number_value;    
        }
    }
}
