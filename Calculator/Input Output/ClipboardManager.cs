using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class ClipboardManager
    {
        // The app checks for numbers on the clipboard and automatically pastes those into the calculator.
        // Any result is automatically copied to the clipboard.

        private string lastPastedValue;

        public ClipboardManager()
        {
            InputEvents.OnClipboardTextDetected += PasteFromClipboard;
            //OutputEvents.OnCopyToClipboard += CopyToClipboard;
            NumberEvents.OnEquationCalculated += CopyToClipboard;
            NumberEvents.OnNumberRounded += CopyRoundedNumber;
        }

        // Invoked every time the app receives focus.
        void PasteFromClipboard()
        {
            // Get text from the clipboard.
            // Replace , with . and − with - so the string can be properly read as a number.
            string latestText = Clipboard.GetText();
            latestText = latestText.Replace(DisplayText.Comma, DisplayText.DecimalSeparator);
            latestText = latestText.Replace(DisplayText.Minus, DisplayText.Negative);

            // If the clipboard text is a number, and it's a new number (not pasted just earlier).
            // Then pass the number to the display and show a message that a number has been pasted.
            if (double.TryParse(latestText, out double number)
                && !latestText.Equals(lastPastedValue))
            {
                InputEvents.ClipboardTextPasted(latestText);

                //InputEvents.NumberEntered(latestText);

                //OutputEvents.UpdateClipboardMessage(String.Format(DisplayText.PasteFromClipboard, latestText));
            }
        }

        // Invoked every time a calculation or rounding is performed.
        void CopyToClipboard(EquationAnswer answer, double number)
        {
            if (answer == EquationAnswer.DivideBy0)
            {
                // If it's a division by 0, do not copy anything to clipboard but reset the textbox.
                NumberEvents.CopiedToClipboard(string.Empty);
                return;
            }
                

            string validAnswer = number.ToString();

            // Copy the number to the clipboard and show a message that a number has been copied.
            Clipboard.SetText(validAnswer);
            NumberEvents.CopiedToClipboard(validAnswer);

            //OutputEvents.UpdateClipboardMessage(String.Format(DisplayText.CopyToClipboard, result));

            //Need to save the copied value so it won't be pasted back into the calculator.
            lastPastedValue = validAnswer;
        }

        // Detour to match the event signature.
        void CopyRoundedNumber(double number)
        {
            CopyToClipboard(EquationAnswer.Number, number);
        }
    }
}
