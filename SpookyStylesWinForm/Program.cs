using System;
using System.Windows.Forms;

namespace SpookyStylesWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  Головна точка входу для застосунку.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ініціалізація конфігурації застосунку.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
