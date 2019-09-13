using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDependency
{
    public class Class1
    {
        public string ClearMessage()
        {
            string lText = "This is a simple calculator.@Designed for additon, subtraction, multiplication & division";
            lText = lText.Replace("@", System.Environment.NewLine);
            return lText;
        }

        public string ErrorMessage()
        {
            string lText = "Error:@This program has encountered an error!";
            lText = lText.Replace("@", System.Environment.NewLine);
            return lText;
        }
    }
}
