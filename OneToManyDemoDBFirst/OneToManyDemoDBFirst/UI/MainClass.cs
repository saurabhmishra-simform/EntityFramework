using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst.UI
{
    public class MainClass
    {
        public static void MainUIClass()
        {
            int option;
            while (true)
            {
                Console.WriteLine("\n\t\t************Main Menu************");
                Console.WriteLine("\t\t1.Operation on Project");
                Console.WriteLine("\t\t2.Operation on Student");
                Console.WriteLine("\t\t0.Exit");
                Console.Write("Select option:");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        ProjectUI.ProjectUIMenu();
                        break;
                    case 2:
                        StudentUI.StudentUIMenu();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
