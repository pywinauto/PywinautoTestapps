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
        /// The main entry point for the application.
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
                uint colCount = uint.Parse(args[2]);
                int seed;
                try 
                {
                    seed = int.Parse(args[3]);
                }
                catch (Exception)
                {
                    seed = 0;
                }

                if (mode <= 0 || mode >= 4)
                {
                    System.Console.WriteLine("Please enter a correct mode(in range 1-3).");

                    return 1;
                }

                if (itemsCount <= 0)
                {
                    System.Console.WriteLine("Please enter a positive numeric items count.");

                    return 1;
                }

                if (colCount <= 0)
                {
                    System.Console.WriteLine("Please enter a positive numeric columns count.");

                    return 1;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(mode, itemsCount, colCount, seed));

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
