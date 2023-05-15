using ConsoleTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromExistingDBCOdeFirst
{
    public class InsertStudent
    {
        public static void Insert()
        {
            using (Model1 context = new Model1())
            {
                var student = new tblStudent
                {
                    Name = "Jimit",
                    Email = "jimit@gmail.com",
                    GenderId = 1,
                };
                context.tblStudents.Add(student);
                context.SaveChanges();
                Display();
            }
        }
        public static void Display()
        {
            using (Model1 context = new Model1())
            {
               List<tblStudent> students = context.tblStudents.ToList();
                var table = new ConsoleTable("Id", "StudentName", "Email", "GenderId");
                foreach (tblStudent stud in students)
                {
                    table.AddRow(stud.Id, stud.Name, stud.Email, stud.GenderId);
                }
                //table.Options.EnableCount = false;
                table.Write();
            }
        }
        public static void Delete()
        {
            using (Model1 context = new Model1())
            {
                var student = context.tblStudents.FirstOrDefault(stud => stud.Id == 0);
                if (student != null)
                {
                    context.tblStudents.Remove(student);
                }
                context.SaveChanges();
                Display();
            }
        }

    }
}
