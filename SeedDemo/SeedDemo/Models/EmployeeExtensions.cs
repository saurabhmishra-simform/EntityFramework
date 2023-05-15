using System.IO;
namespace SeedDemo.Models
{
    public class EmployeeExtensions
    {
        public static string path = @"C:\Users\saurabh\Desktop\Saurabh\EntityFramework\SeedData.txt";
        public static void Seed() 
        {
            if (File.Exists(path))
            {

            }
            else
            {

            }
        }
            
    }
}
