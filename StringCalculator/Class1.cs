using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {
            if(input.Length == 0)
                return 0;
            string[] components;
            List<string> delimiters = new List<string>();
            delimiters.Add(Convert.ToString('\n'));
            delimiters.Add(Convert.ToString(','));
            if (input[0] == '/' & input[1] == '/')
            {
                if (input[2] == '[')
                {
                    string[] delimitersCutter = input.Split('[');
                    for(int i = 1; i<delimitersCutter.Length;i++)
                        delimiters.Add(delimitersCutter[i].Split(']')[0]);
                }
                else
                    delimiters.Add(Convert.ToString(input[2]));
                input = input.Split("\n")[1];
            }
            components = input.Split(delimiters.ToArray(), StringSplitOptions.None);
            int sum = 0;
            for (int i = 0; i < components.Length; i++)
            {
                int component = int.Parse(components[i]);
                if (component < 0)
                    throw new Exception();
                sum += component > 1000 ? 0 : component;
            }    
            return sum;

        }
    }
}
