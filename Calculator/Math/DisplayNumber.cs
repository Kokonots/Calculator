using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DisplayedNumber : Singleton<DisplayedNumber>
    {
        // This class handles the number that is displayed on the calculator.

        // The number is saved as a string because this makes it easier to add digits.
        // It's also possible to be not a number in the case of division by zero.
        private string _number;
        public string Number
        {
            private set
            {
                _number = value;
                NumberEvents.DisplayNumberChanged(Number);
            }
            get
            {
                return _number;
            }
        }

        private bool startNewNumber = true;

        public DisplayedNumber()
        {
            InputEvents.OnClipboardTextPasted += SetNumber;
            InputEvents.OnCharacterEntered += AddCharacter;
            InputEvents.OnClear += ResetNumber;
            InputEvents.OnRoundingEntered += RoundNumber;
            InputEvents.OnUndo += RemoveCharacter;
            InputEvents.OnNegativeEntered += AddNegative;
            InputEvents.OnSeparatorEntered += AddDecimalSeparator;

            NumberEvents.OnEquationCalculated += EquationCalculated;
            NumberEvents.OnEquationStarted += StartNewNumber;
        }

        // Invoked when:
        // - A calculation is performed
        // - A number is pasted from the clipboard
        // - The number is reset to 0
        public void SetNumber(string newNumber)
        {
            // Overwrites any earlier value.
            Number = newNumber;

            // Pressing a numeric button after this would start a new number, not add a digit to this.
            startNewNumber = true;
        }

        void EquationCalculated(EquationAnswer answer, double number)
        {
            // If the outcome is a division by 0, use an error text.
            // Otherwise use the answer.
            switch (answer)
            {
                case EquationAnswer.DivideBy0:
                    SetNumber(DisplayText.DividedByZero);
                    break;
                default:
                    SetNumber(number.ToString());
                    break;
            }
        }

        // Invoked by numerical input.
        void AddCharacter(char newCharacter)
        {
            // If the currently displayed number should be overwritten, start a new number.
            if (startNewNumber)
            {
                Number = newCharacter.ToString();

                startNewNumber = false;
            }
            // Otherwise add the digit on the end.
            else
            {
                Number += newCharacter.ToString();
            }
        }

        //Invoked by dot. 
        void AddDecimalSeparator()
        {
            // If the currently displayed number should be overwritten, start a new number.
            if (startNewNumber)
            {
                // The new number should be "0.", not "."
                Number = DisplayText.Zero + DisplayText.DecimalSeparator.ToString();

                startNewNumber = false;
            }
            // If it should be added to the current number.
            else
            {
                // If there already is a . in the number, do nothing.
                if (Number.Contains(DisplayText.DecimalSeparator))
                    return;

                // If the current number is "-" that should become "-0." not "-."
                if (Number.Equals(DisplayText.Negative.ToString()))
                    Number += DisplayText.Zero;

                // Add the separator on the end.
                Number += DisplayText.DecimalSeparator.ToString();
            }
        }

        // Invoked by -.
        void AddNegative()
        {
            // This method toggles the number between positive and negative.
            // Notably this never resets the number and always alters the current number.

            bool setToPositive = false;

            // If the number is already negative, then make it positive.
            // But we can only check that if displayNumber has at least 1 character.
            if (Number.Length > 0)
            {
                if (char.Parse(Number.Substring(0, 1)) == DisplayText.Negative)
                {
                    setToPositive = true;

                    Number = Number.Remove(0, 1);

                    // If "-" was the only character on the display,
                    // or if all that's left is a 0, 
                    // reset the displayed number to 0.
                    if (Number.Length < 1 ||
                        Number.Equals(DisplayText.Zero))
                    {
                        ResetNumber();
                    }
                }
            }

            // If it wasn't negative made positive, it needs to be made negative
            if (!setToPositive)
            {
                // A "0" should become "-" not "-0"
                if (Number.Equals(DisplayText.Zero))
                    AddCharacter(DisplayText.Negative);
                else
                    Number = DisplayText.Negative.ToString() + Number;
            }
        }

        void StartNewNumber()
        {
            startNewNumber = true;
        }

        // Called when one of the rounding buttons is pressed.
        void RoundNumber(int decimalPlaces)
        {
            // Only round if there is a number to round
            if (double.TryParse(DisplayedNumber.Instance.Number, out double currentNumber))
            {
                double newNumber = Math.Round(currentNumber, decimalPlaces);

                string correctedDecimalNumber = newNumber.ToString();
            
                // TODO: add decimals if there aren't enough decimals

                //int decimalCount = 0;
                //bool startCount = false;
                //foreach (char character in correctedDecimalNumber)
                //{
                //    if (character == DisplayText.DecimalSeparator)
                //        startCount = true;
                //    else if (startCount)
                //        decimalCount++;
                //}
                //Console.WriteLine(decimalCount);
                //Console.WriteLine(decimalPlaces);
                //while (decimalCount < decimalPlaces)
                //{
                //    correctedDecimalNumber += DisplayText.Zero;
                //    decimalCount++;
                //}

                SetNumber(correctedDecimalNumber);

                // Let those interested know a number has been rounded
                NumberEvents.OnNumberRounded(newNumber);
            }
        }

        void RemoveCharacter()
        {
            //No need to remove the characters from "Division by 0" one by one
            if (Number.Equals(DisplayText.DividedByZero))
            {
                ResetNumber();
                return;
            }

            // Remove the last character.
            Number = Number.Remove(Number.Length - 1);

            // If the number is now empty or just a 0, reset the displayed number.
            if (Number.Length < 1 ||
                Number.Equals(DisplayText.Zero))
            {
                ResetNumber();
            }
            // Otherwise if there is anything left, make sure that gets now added to, not overwritten.
            else
            {
                startNewNumber = false;
            }
        }

        // Resets to 0.
        void ResetNumber()
        {
            SetNumber(DisplayText.Zero);
        }
    }
}
