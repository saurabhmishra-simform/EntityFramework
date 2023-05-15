using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromExistingDBCOdeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Delete");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertStudent.Insert();
                        break;
                    case 2:
                        InsertStudent.Display();
                        break;
                    case 3:
                        InsertStudent.Delete();
                        break;
                }
            }
        }
    }
}
