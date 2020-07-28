using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NumberEvents
    {
        // This is a mediator that facilitates communication between logic classes,
        // and from logic classes to the TextBox Controllers that show text on the screen.

        public static Action<EquationAnswer, double> OnEquationCalculated;
        public static void EquationCalculated(EquationAnswer answer, double number) => OnEquationCalculated?.Invoke(answer, number);

        public static Action OnEquationStarted;
        public static void EquationStarted() => OnEquationStarted?.Invoke();

        public static Action<double> OnNumberRounded;
        public static void NumberRounded(double outcome) => OnNumberRounded?.Invoke(outcome);

        public static Action<string> OnDisplayNumberChanged;
        public static void DisplayNumberChanged(string number) => OnDisplayNumberChanged?.Invoke(number);

        public static Action<string> OnCopiedToClipboard;
        public static void CopiedToClipboard(string number) => OnCopiedToClipboard?.Invoke(number);
    }
}
