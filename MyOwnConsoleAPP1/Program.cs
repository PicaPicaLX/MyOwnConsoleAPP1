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
            bool displayMainMenu = true;
            while (displayMainMenu)
            {
                displayMainMenu = MainMenu();
            }
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
            Console.WriteLine("7) Experement of Genetics");
            Console.WriteLine("8) Experement of MicroBiology");
            Console.WriteLine("E) Exit --->");

            string select = Console.ReadLine();
            if (select =="1")
            {
                Biochemistry();
                return true;
            }
            if (select =="2")
            {
                Genetics();
                return true;
            }
            if (select =="3")
            {
                MicroBiology();
                return true;
            }
            if (select == "4")
            {
                MKS_Original();
                return true;
            }
            if (select == "5")
            {
                Physcial_Educationl();
                return true;
            }
            if (select == "6")
            {
                Experement_of_Biochemistry();
                return true;
            }
            if (select == "7")
            {
                Experement_of_Genetics();
                return true;
            }
            if (select == "8")
            {
                Experement_of_MicroBiology();
                return true;
            }
            else if (select=="E")
            {
                return false;
            }
            else if (select=="e")
            {
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please type the number above!\n---Press ENTER to back to MainMenu---");
                Console.ReadLine();
                return true;
            }

        }
        private static bool Biochemistry()
        {
            Console.Clear();
            Mark Biochemistry = new Mark() { Marks = 75, Grade = "B2", Pass = "Yes" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}", 
                Biochemistry.Marks, 
                Biochemistry.Grade, 
                Biochemistry.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");

            string value=Console.ReadLine();
            if (value=="E")
            {
                return false;
            }
            else if (value=="e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool Genetics()
        {
            Console.Clear();
            Mark Genetics = new Mark() { Marks = 50, Grade = "B2", Pass = "No" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}",
                Genetics.Marks,
                Genetics.Grade,
                Genetics.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");
            string value = Console.ReadLine();
            if (value=="E")
            {
                return false;
            }
            else if (value=="e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool MicroBiology()
        {
            Console.Clear();
            Mark MicroBiology = new Mark() { Marks = 68, Grade = "B2", Pass = "Yes" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}",
                MicroBiology.Marks,
                MicroBiology.Grade,
                MicroBiology.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");
            string value = Console.ReadLine();
            if (value == "E")
            {
                return false;
            }
            else if (value == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool MKS_Original()
        {
            Console.Clear();
            Mark MKS_Original = new Mark() { Marks = 79, Grade = "B2", Pass = "Yes" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}",
                MKS_Original.Marks,
                MKS_Original.Grade,
                MKS_Original.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");
            string value = Console.ReadLine();
            if (value == "E")
            {
                return false;
            }
            else if (value == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool Physcial_Educationl()
        {
            Console.Clear();
            Mark Physcial_Educationl = new Mark() { Marks = 66, Grade = "B2", Pass = "Yes" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}",
                Physcial_Educationl.Marks,
                Physcial_Educationl.Grade,
                Physcial_Educationl.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");
            string value = Console.ReadLine();
            if (value == "E")
            {
                return false;
            }
            else if (value == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool Experement_of_Biochemistry()
        {
            Console.Clear();
            Mark Experement_of_Biochemistry = new Mark() { Marks = 90, Grade = "B2", Pass = "Yes" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}",
                Experement_of_Biochemistry.Marks,
                Experement_of_Biochemistry.Grade,
                Experement_of_Biochemistry.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");
            string value = Console.ReadLine();
            if (value == "E")
            {
                return false;
            }
            else if (value == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool Experement_of_Genetics()
        {
            Console.Clear();
            Mark Experement_of_Genetics = new Mark() { Marks = 85, Grade = "B2", Pass = "Yes" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}",
                Experement_of_Genetics.Marks,
                Experement_of_Genetics.Grade,
                Experement_of_Genetics.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");
            string value = Console.ReadLine();
            if (value == "E")
            {
                return false;
            }
            else if (value == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool Experement_of_MicroBiology()
        {
            Console.Clear();
            Mark Physcial_Educationl = new Mark() { Marks = 95, Grade = "B2", Pass = "Yes" };
            Console.WriteLine("Marks: {0}\nGrade: {1}\nPass: {2}",
                Physcial_Educationl.Marks,
                Physcial_Educationl.Grade,
                Physcial_Educationl.Pass);
            Console.WriteLine("\n---Press ENTER to continue---");
            Console.WriteLine("\nPress ANY key to back to Main Menu");
            Console.WriteLine("E) Exit");
            string value = Console.ReadLine();
            if (value == "E")
            {
                return false;
            }
            else if (value == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }



    }
    class Mark
    {
        public string Grade { get; set; }
        public int Marks { get; set; }
        public string Pass { get; set; }      
    }
}
