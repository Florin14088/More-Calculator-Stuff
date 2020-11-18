using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Classes
{
    class Operator
    {

        private char op;
        public Operator(char op)
        {
            this.op = op;
        }


        public double apply(double before, double after)
        {
            double b = before;
            switch (op)
            {
                case '-':
                    b -= after;
                    break;

                case '+':
                    b += after;
                    break;

                case '*':
                    b *= after;
                    break;

                case '/':
                    b /= after;
                    break;

                default:
                    break;
            }

            return b;

        }


    }


}
