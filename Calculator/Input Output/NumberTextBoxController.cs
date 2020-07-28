using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class NumberTextBoxController : TextBoxController
    {
        // Controls the textbox that displays the number.

        public NumberTextBoxController(TextBox newTextBox) : base(newTextBox)
        {
            NumberEvents.OnDisplayNumberChanged += OnDisplayNumberChanged;
        }

        // This textbox always displays a 0 rather than nothing on reset.
        protected override void ClearText()
        {
            textBox.Text = DisplayText.Zero;
        }

        // Can be not a number in the case of division by 0.
        void OnDisplayNumberChanged(string number)
        {
            textBox.Text = number;
        }
    }
}
