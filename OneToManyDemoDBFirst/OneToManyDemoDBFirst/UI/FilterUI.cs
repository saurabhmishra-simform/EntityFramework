using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst.UI
{
    public class FilterUI
    {
        public static void FilterUIMenu()
        {
            int option;
            while (true)
            {
                Console.WriteLine("\n\t\t************Filter Menu************");
                Console.WriteLine("\t\t1.Find");
                Console.WriteLine("\t\t2.GroupBy");
                Console.WriteLine("\t\t3.OrderBy");
                Console.WriteLine("\t\t4.JoinQuery");
                Console.WriteLine("\t\t5.GroupJoinQuery");
                Console.WriteLine("\t\t6.CountProjectWise");
                Console.WriteLine("\t\t0.Exit");
                UserData:
                Console.Write("Select option:");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            FilterInStudent.FindStudentName();
                            break;
                        case 2:
                            FilterInStudent.GroupProjectName();
                            break;
                        case 3:
                            FilterInStudent.OrderByProjectId();
                            break;
                        case 4:
                            FilterInStudent.JoinQuery();
                            break;
                        case 5:
                            FilterInStudent.GroupJoinQuery();
                            break;
                        case 6:
                            FilterInStudent.CountProjectWise();
                            break;
                        case 0:
                            MainClass.MainUIClass();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format!");
                    goto UserData;
                }
                catch (Exception)
                {
                    Console.WriteLine("Some exception found!");
                    goto UserData;
                }
            }
        }
    }
}
