using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Calculator.Calc;
using Calculator.IO;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Instantiate singletons.
            DisplayedNumber display = DisplayedNumber.Instance;
            Equation equation = Equation.Instance;

            // Instantiate other classes.
            // TODO: Research where is the best place to instantiate these in Windows Forms.
            ClipboardManager clipboardCopyPaster = new ClipboardManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
