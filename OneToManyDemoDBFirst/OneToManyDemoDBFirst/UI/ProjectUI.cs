using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst.UI
{
    public class ProjectUI
    {
        public static void ProjectUIMenu()
        {
            int option;
            while (true)
            {
                Console.WriteLine("\n\t\t************Project Menu************");
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
                        CodeWithProject.InsertProjectDetails();
                        break;
                    case 2:
                        CodeWithProject.ShowProjectDetails();
                        break;
                    case 3:
                        CodeWithProject.UpdateProjectDetails();
                        break;
                    case 4:
                        CodeWithProject.DeleteProjectDetails();
                        break;
                    case 0:
                        MainClass.MainUIClass();
                        break;
                }
            }
        }
    }
}
