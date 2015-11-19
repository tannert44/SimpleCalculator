using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constant
    {
        public Dictionary<char, int> constant_dictionary = new Dictionary<char, int>();

        public Constant()
        {

        }

        public void AddConstant(char dic_key, int dic_value)
        {
            constant_dictionary.Add(dic_key, dic_value);
        }

        public int GetConstant(char key)
        {
            int result;
            if (constant_dictionary.TryGetValue(key, out result))
                return result;
            else
                throw new ArgumentException();
        }
    }
}
