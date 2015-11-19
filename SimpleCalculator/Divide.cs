using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Divide
    {
        public int DivideItems(string input)
        {
            Parser parse = new Parser();
            int firstItem = Int32.Parse(parse.GetFirst(input));
            int secondItem = Int32.Parse(parse.GetSecond(input));
            return firstItem / secondItem;
        }

        public int DivideConstants(string input, Constant constant)
        {
            Parser parse = new Parser();
            int constant_value;
            int number_value;
            if (Char.IsLetter(Char.Parse(parse.GetFirst(input))) && !Char.IsLetter(Char.Parse(parse.GetSecond(input))))
            {
                Char firstItem = Char.Parse(parse.GetFirst(input));
                int secondItem = int.Parse(parse.GetSecond(input));
                constant_value = constant.GetConstant(firstItem);
                number_value = secondItem;
            }
            else if (Char.IsLetter(Char.Parse(parse.GetSecond(input))) && !Char.IsLetter(Char.Parse(parse.GetFirst(input))))
            {
                Char secondItem = Char.Parse(parse.GetSecond(input));
                int firstItem = int.Parse(parse.GetFirst(input));
                constant_value = constant.GetConstant(secondItem);
                number_value = secondItem;
            }
            else
            {
                Char secondItem = Char.Parse(parse.GetSecond(input));
                Char firstItem = Char.Parse(parse.GetFirst(input));
                constant_value = constant.GetConstant(secondItem);
                number_value = constant.GetConstant(firstItem);
            }
            return constant_value / number_value;
        }
    }
}
