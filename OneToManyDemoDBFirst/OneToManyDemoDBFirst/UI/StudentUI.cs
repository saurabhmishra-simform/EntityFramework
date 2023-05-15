using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst.UI
{
    public class StudentUI
    {
        public static void StudentUIMenu()
        {
            int option;
            while (true)
            {
                Console.WriteLine("\n\t\t************Student Menu************");
                Console.WriteLine("\t\t1.Insert");
                Console.WriteLine("\t\t2.Display");
                Console.WriteLine("\t\t3.Update");
                Console.WriteLine("\t\t4.Delete");
                Console.WriteLine("\t\t0.Exit");
                Console.Write("Select option:");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CodeWithStudent.InsertStudentDetails();
                        break;
                    case 2:
                        CodeWithStudent.ShowStudentDetails();
                        break;
                    case 3:
                        CodeWithStudent.UpdateStudentDetails();
                        break;
                    case 4:
                        CodeWithStudent.DeleteStudentDetails();
                        break;
                    case 0:
                        MainClass.MainUIClass();
                        break;
                }
            }
        }
    }
}
