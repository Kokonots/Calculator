using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Calculator
{
    enum EquationAnswer { Number, DivideBy0 }

    class Equation : Singleton<Equation>
    {
        // This class handles what happens when − + ÷ × or = are pressed.
        // It performs the chosen mathematical operation.

        public double? Operand1 { get; private set; }
        public double? Operand2 { get; private set; }
        public Operation Operation { get; private set; }
        bool newOperand;

        public Equation()
        {
            InputEvents.OnOperationEntered += AddOperation;
            InputEvents.OnClear += ClearOperands;
            InputEvents.OnCalculate += Calculate;
            NumberEvents.OnDisplayNumberChanged += DisplayUpdated;
        }


        // Invoked when an operation − + ÷ × is pressed.
        void AddOperation(Operation newOperation)
        {
            // If there is a previous operation that has to be calculated, first perform the calculation.
            // For example if the user inputs 8 + 3 x 2 without pressing =, we first need to calculate 8 + 3.
            // But only if a second operand has been entered, and not for example:
            // If the input is 8 + x, then we should correct 8 + to 8 x, not perform any calculation with +.
            if (Operation != null && newOperand == true)
                Calculate();

            // The operation and the first operand are saved, and we're waiting for a second operand.
            Operation = newOperation;
            Operand1 = GetDisplayedNumber();
            newOperand = false;

            // Let those interested know that the first half of the equation is complete.
            NumberEvents.EquationStarted();
        }

        // Invoked when = is pressed
        void Calculate()
        {
            // if the = is pressed but there's nothing to calculate, do nothing.
            if (Operation == null)
                return;

            Operand2 = GetDisplayedNumber();

            // Perform the operation.
            // The result could be not a valid number in the case of division by 0.
            (EquationAnswer answer, double number) = Operation.Calculate(Operand1.Value, Operand2.Value);

            // Let those interested know that a calculation has been completed.
            NumberEvents.EquationCalculated(answer, number);

            // Reset the equation. This should not be done before the event.
            ClearOperands();
        }

        double GetDisplayedNumber()
        {
            // The display could be not a number in the case of division by 0.
            if (double.TryParse(DisplayedNumber.Instance.Number, out double number))
                return number;
            else
                return 0;
        }

        // Invoked every time the number on display changes.
        // The parameter is required to match the Event.
        void DisplayUpdated(string newNumber)
        {
            // This signifies together with the operation variable whether there is a complete equation waiting to be calculated.
            newOperand = true;
        }

        // Reset the equation.
        void ClearOperands()
        {
            Operand1 = null;
            Operand2 = null;
            Operation = null;
            newOperand = false;
        }
    }
}
