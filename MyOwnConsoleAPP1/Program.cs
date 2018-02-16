using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnConsoleAPP1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            Console.ReadLine();
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("----- Choose a mark you want to know -----\n");
            Console.WriteLine("1) Biochemistry");
            Console.WriteLine("2) Genetics");
            Console.WriteLine("3) MicroBiology");
            Console.WriteLine("4) MKS Original");
            Console.WriteLine("5) Physcial Education");
            Console.WriteLine("6) Experement of Biochemistry");
            Console.WriteLine("7) experement of Genetics");
            Console.WriteLine("8) Experement of MicroBiology");
            Console.WriteLine("E) Exit --->");
            string select = Console.ReadLine();
            while (select=="1")
            {
                Biochemistry();
                Console.WriteLine("\nM) Back to Main Menu");
                Console.WriteLine("E) Exit");
                Exit();
            }
            return true;

        }
        private static string Biochemistry()
        {

        }
        private static string Exit()
        {
            if ()
            {

            }
        }
    }
    class 
}
