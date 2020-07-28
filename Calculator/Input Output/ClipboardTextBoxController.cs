using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class ClipboardTextBoxController : TextBoxController
    {
        // Controls the textbox that display messages about the clipboard.

        public ClipboardTextBoxController(TextBox newTextBox) : base(newTextBox)
        {
            NumberEvents.OnCopiedToClipboard += OnCopiedToClipBoard;
            InputEvents.OnClipboardTextPasted += OnPastedFromClipboard;
        }

        void OnPastedFromClipboard(string number)
        {
            string clipboardMessage = String.Format(DisplayText.PasteFromClipboard,
                number);
            textBox.Text = clipboardMessage;
        }

        void OnCopiedToClipBoard(string number)
        {
            // If there is nothing copied to the clipboard, instead reset the textbox to empty.
            string clipboardMessage;
            if (number.Equals(string.Empty))
                clipboardMessage = string.Empty;
            else
                clipboardMessage = String.Format(DisplayText.CopyToClipboard,
                number);

            textBox.Text = clipboardMessage;
        }
    }
}
