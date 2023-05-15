using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst.UserInputFiles
{
    public static class UserInput
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine("Enter " + message);
            return Console.ReadLine();
        }
    }
}
