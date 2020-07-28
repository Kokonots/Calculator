using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{

    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            // Link up the Textbox Controllers with the Textbox Controls.
            this.equationTextBoxController = new EquationTextBoxController(EquationTextBox);
            this.clipboardTextBoxController = new ClipboardTextBoxController(ClipboardTextBox);
            this.numberTextBoxController = new NumberTextBoxController(NumberTextBox);

            IsEqualToButton.Focus();
        }

        #region Button Click Events
        // Click Events for all the buttons.

        // For the numerical buttons, the numeral is passed along.
        private void NumericButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            char character = char.Parse(clickedButton.Text);

            InputEvents.CharacterEntered(character);
            SetControl();
        }

        // For the − + ÷ × buttons, the operation class is passed along.
        // Experiment with what I can put in the tag field.
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Operation operation = (Operation)clickedButton.Tag;

            InputEvents.OperationEntered(operation);
            SetControl();
        }

        // For the rounding buttons, the amount of decimals is passed along.
        private void RoundingButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int decimalPlaces = Convert.ToInt32(clickedButton.Tag);

            InputEvents.RoundingEntered(decimalPlaces);
            SetControl();
        }

        // The . button.
        private void SeparatorButton_Click(object sender, EventArgs e)
        {
            InputEvents.SeparatorEntered();
            SetControl();
        }

        // The ± button.
        private void NegativeButton_Click(object sender, EventArgs e)
        {
            InputEvents.NegativeEntered();
            SetControl();
        }

        // The = button.
        private void IsEqualToButton_Click(object sender, EventArgs e)
        {
            InputEvents.Calculate();
            SetControl();
        }

        // The C button.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputEvents.Clear();
            SetControl();
        }

        // The ← button.
        private void BackButton_Click(object sender, EventArgs e)
        {
            InputEvents.Undo();
            SetControl();
        }

        // So an enter press always performs =.
        private void SetControl()
        {
            this.ActiveControl = IsEqualToButton;
        }
        #endregion

        #region Key Press Events

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputEvents.Calculate();
                e.Handled = true;
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                InputEvents.CharacterEntered(e.KeyChar);
            }
            // . and ,
            else if (e.KeyChar == 44 || e.KeyChar == 46)
            {
                InputEvents.CharacterEntered(DisplayText.DecimalSeparator);
            }
            // * and x and X
            else if (e.KeyChar == 42 || e.KeyChar == 88 || e.KeyChar == 120)
            {
                InputEvents.OperationEntered((Operation)new Multiplication());
            }
            else if (e.KeyChar == 43)
            {
                InputEvents.OperationEntered((Operation)new Addition());
            }
            else if (e.KeyChar == 45)
            {
                InputEvents.OperationEntered((Operation)new Subtraction());
            }
            else if (e.KeyChar == 47)
            {
                InputEvents.OperationEntered((Operation)new Division());
            }
            else if (e.KeyChar == 61)
            {
                InputEvents.Calculate();
            }
            // Backspace
            else if (e.KeyChar == 08)
            {
                InputEvents.Undo();
            }
        }
        #endregion

        #region Other Events
        // Each time the application window enters focus we check the clipboard.
        private void Main_EnterFocus(object sender, System.EventArgs e)
        {
            InputEvents.ClipboardTextDetected();
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
