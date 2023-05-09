using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<tblDepartment> listDepartments = DBEntities.tblDepartments.ToList();
                Console.WriteLine();
                foreach (tblDepartment dept in listDepartments)
                {
                    Console.WriteLine("  Department = {0}, Location = {1}", dept.DepartmentName, dept.Location);
                    foreach (tblEmployee emp in dept.tblEmployees)
                    {
                        Console.WriteLine("\t Name = {0}, Gender = {1}, salary = {2}",
                            emp.Name, emp.Gender, emp.Salary);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
