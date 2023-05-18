using ConsoleTables;
using OneToManyDemoDBFirst.Delegates;
using OneToManyDemoDBFirst.UI;
using OneToManyDemoDBFirst.UserInputFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst
{
    public class CodeWithStudent
    {
        static readonly StudentProjectEntities context = new StudentProjectEntities();
        public static int Id;
        static TypeConvertDelegate<int> IntegerConvert = new TypeConvertDelegate<int>(ConvertValue.ConvertInt);
        public static void InsertStudentDetails()
        {
            using(context)
            {
                var student = new Student()
                {
                    StudentName = UserInput.GetUserInput("Student name:"),
                    StudentAddress = UserInput.GetUserInput("Student address:"),
                    Email = UserInput.GetUserInput("Student email:"),
                    ProjectId = IntegerConvert(UserInput.GetUserInput("Project Id:")),
                };
                context.Students.Add(student);
                context.SaveChanges();
                ShowStudentDetails();
            }
        }
        public static void ShowStudentDetails()
        {
            using(context)
            {
                var students = context.Students.ToList();
                var consoleTable = new ConsoleTable("StudentID", "StudentName", "StudentAddress", "StudentEmail", "ProjectID");
                foreach(var student in students)
                {
                    consoleTable.AddRow(student.StudentId,student.StudentName,student.StudentAddress,student.Email,student.ProjectId);
                }
                consoleTable.Write();
            }
        }
        public static void UpdateStudentDetails()
        {
            Id = IntegerConvert(UserInput.GetUserInput("Enter project Id:"));
            using (context)
            {
                var student = context.Students.FirstOrDefault(stud => stud.StudentId == Id);
                student.StudentName = UserInput.GetUserInput("Student name:");
                student.StudentAddress = UserInput.GetUserInput("Student address:");
                student.Email = UserInput.GetUserInput("Student email:");
                student.ProjectId = IntegerConvert(UserInput.GetUserInput("Project Id:"));
                context.SaveChanges();
                ShowStudentDetails();
            }
        }
        public static void DeleteStudentDetails()

        {
            Id = IntegerConvert(UserInput.GetUserInput("Enter project Id:"));
            using (context)
            {
                var student = context.Students.FirstOrDefault(stud => stud.StudentId == Id);
                context.Students.Remove(student);
                context.SaveChanges();
                ShowStudentDetails();
            }
        }
    }
}
