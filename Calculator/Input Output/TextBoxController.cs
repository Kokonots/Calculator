using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class TextBoxController
    {
        // The base class for the TextBox Controllers.
        // TODO: Research where is the best place to instantiate these in Windows Forms.

        // Reference to a specific control on the form
        protected TextBox textBox;

        public TextBoxController(TextBox newTextBox)
        {
            textBox = newTextBox;
            ClearText();

            InputEvents.OnClear += ClearText;
        }

        protected virtual void ClearText()
        {
            textBox.Text = string.Empty;
        }
    }
}
