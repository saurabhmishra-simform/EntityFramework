﻿using System;
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
                Console.WriteLine("\t\t3.Operation on Filter");
                Console.WriteLine("\t\t0.Exit");
                UserData:
                Console.Write("Select option:");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            ProjectUI.ProjectUIMenu();
                            break;
                        case 2:
                            StudentUI.StudentUIMenu();
                            break;
                        case 3:
                            FilterUI.FilterUIMenu();
                            break;
                        case 0:
                            Environment.Exit(0);
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
