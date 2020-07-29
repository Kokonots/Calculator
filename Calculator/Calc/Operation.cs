using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Calculator.Text;

namespace Calculator.Calc
{
    abstract class Operation
    {
        // Each mathematical operation has a symbol and a method that performs that operation.
        // The method can't just return a number because in the case of a division by 0 there is no valid answer.
        protected char symbol;
        public char Symbol { get { return symbol; } }

        public abstract (EquationAnswer, double) Calculate(double firstNumber, double secondNumber);
    }

    class Division : Operation
    {
        public Division()
        {
            symbol = Constants.DividedBy;
        }

        public override (EquationAnswer, double) Calculate(double firstNumber, double secondNumber)
        {
            // If it would be a division by 0, return a different EquationAnswer.
            if (secondNumber != 0)
            {
                double outcome = firstNumber / secondNumber;
                return (EquationAnswer.Number, outcome);
            }
            else
            {
                return (EquationAnswer.DivideBy0, 0);
            }
        }
    }

    class Addition : Operation
    {
        public Addition()
        {
            symbol = Constants.Plus;
        }

        public override (EquationAnswer, double) Calculate(double firstNumber, double secondNumber)
        {
            double outcome = firstNumber + secondNumber;
            return (EquationAnswer.Number, outcome);
        }
    }

    class Subtraction : Operation
    {
        public Subtraction()
        {
            symbol = Constants.Minus;
        }

        public override (EquationAnswer, double) Calculate(double firstNumber, double secondNumber)
        {
            double outcome = firstNumber - secondNumber;
            return (EquationAnswer.Number, outcome);
        }
    }

    class Multiplication : Operation
    {
        public Multiplication()
        {
            symbol = Constants.Times;
        }

        public override (EquationAnswer, double) Calculate(double firstNumber, double secondNumber)
        {
            double outcome = firstNumber * secondNumber;
            return (EquationAnswer.Number, outcome);
        }
    }
}
