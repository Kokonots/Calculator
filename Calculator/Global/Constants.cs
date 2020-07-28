using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DisplayText
    {
        // All the text that is used in the textboxes.

        // TODO: move these to an external text file.

        // TODO: functionality to swap between cultures. Right now it's always the dot as separator.
        public const char DecimalSeparator = '.';
        public const char Comma = ',';

        // The minus sign does not count as the negative sign.
        // A string with a minus sign is not parsed as a number.
        public const char Negative = '-';
        public const char Minus = '−';

        public const char DividedBy = '÷';
        public const char Times = '×';
        public const char Plus = '+';
        public const char EqualsSign = '=';

        public const string Zero = "0";
        public const string Null = "null";
        public const string DividedByZero = "DIVISION BY 0";

        // The messages for copying and pasting include a variable number. 
        public const string CopyToClipboard = "{0} copied to clipboard ";
        public const string PasteFromClipboard = "{0} pasted from clipboard ";
    }
}
