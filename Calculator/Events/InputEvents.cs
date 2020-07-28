using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class InputEvents
    {
        // This is a mediator that handles input, from buttons, keys and clipboard
        // and passed that on to the logic classes.

        // 2 events for the Clipboard, one when text is detected and a second one when the text is a number and should be processed.
        public static Action OnClipboardTextDetected;
        public static void ClipboardTextDetected() => OnClipboardTextDetected?.Invoke();

        public static Action<string> OnClipboardTextPasted;
        public static void ClipboardTextPasted(string number) => OnClipboardTextPasted?.Invoke(number);

        // Events for pressing the buttons on the calculator.
        public static Action<char> OnCharacterEntered;
        public static void CharacterEntered(char character) => OnCharacterEntered?.Invoke(character);

        public static Action<Operation> OnOperationEntered;
        public static void OperationEntered(Operation operation) => OnOperationEntered?.Invoke(operation);

        public static Action<int> OnRoundingEntered;
        public static void RoundingEntered(int places) => OnRoundingEntered?.Invoke(places);

        public static Action OnClear;
        public static void Clear() => OnClear?.Invoke();

        public static Action OnCalculate;
        public static void Calculate() => OnCalculate?.Invoke();

        public static Action OnUndo;
        public static void Undo() => OnUndo?.Invoke();

        public static Action OnNegativeEntered;
        public static void NegativeEntered() => OnNegativeEntered?.Invoke();

        public static Action OnSeparatorEntered;
        public static void SeparatorEntered() => OnSeparatorEntered?.Invoke();
    }
}
