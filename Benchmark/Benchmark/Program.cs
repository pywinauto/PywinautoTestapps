using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            // Test if input arguments were supplied:
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a numeric arguments.");

                return 1;
            }

            try
            {
                // Convert the input arguments to numbers:
                uint mode = uint.Parse(args[0]);
                uint itemsCount = uint.Parse(args[1]);
                uint rowCount = uint.Parse(args[2]);


                if (itemsCount <= 0)
                {
                    System.Console.WriteLine("Please enter a positive numeric arguments.");

                    return 1;
                }

                if (rowCount <= 0)
                {
                    System.Console.WriteLine("Please enter a positive numeric arguments.");

                    return 1;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(mode, itemsCount, rowCount));

                return 0;
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("Please enter a numeric arguments.");

                return 1;
            }
        }
    }
}
