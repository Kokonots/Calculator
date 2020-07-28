using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class EquationTextBoxController : TextBoxController
    {
        // Controls the textbox that displays the equation.

        public EquationTextBoxController(TextBox newButton) : base(newButton)
        {
            NumberEvents.OnEquationCalculated += OnCalculated;
            NumberEvents.OnEquationStarted += OnEquationStarted;
        }

        // Invoked when = is entered.
        void OnCalculated(EquationAnswer answer, double number)
        {
            string equationMessage = string.Format("{0} {1} {2} {3} ",
                Equation.Instance.Operand1, Equation.Instance.Operation.Symbol, Equation.Instance.Operand2, DisplayText.EqualsSign);
            textBox.Text = equationMessage;
        }

        // Invoked when − + ÷ × are entered.
        void OnEquationStarted()
        {
            string equationMessage = string.Format("{0} {1} ",
                Equation.Instance.Operand1, Equation.Instance.Operation.Symbol);
            textBox.Text = equationMessage;
        }
    }
}
