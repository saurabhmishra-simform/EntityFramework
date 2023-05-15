using ConsoleTables;
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
        public static int Id;
        public static void InsertStudentDetails()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var student = new Student()
                {
                    StudentName = UserInput.GetUserInput("Student name:"),
                    StudentAddress = UserInput.GetUserInput("Student address:"),
                    Email = UserInput.GetUserInput("Student email:"),
                    ProjectId = Convert.ToInt32(UserInput.GetUserInput("Project Id:")),
                };
                context.Students.Add(student);
                context.SaveChanges();
                ShowStudentDetails();
            }
        }
        public static void ShowStudentDetails()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
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
            Id = Convert.ToInt32(UserInput.GetUserInput("Enter project Id:"));
            using (StudentProjectEntities context = new StudentProjectEntities())
            {
                var student = context.Students.FirstOrDefault(stud => stud.StudentId == Id);
                student.StudentName = UserInput.GetUserInput("Student name:");
                student.StudentAddress = UserInput.GetUserInput("Student address:");
                student.Email = UserInput.GetUserInput("Student email:");
                student.ProjectId = Convert.ToInt32(UserInput.GetUserInput("Project Id:"));
                context.SaveChanges();
                ShowStudentDetails();
            }
        }
        public static void DeleteStudentDetails()
        {
            Id = Convert.ToInt32(UserInput.GetUserInput("Enter project Id:"));
            using (StudentProjectEntities context = new StudentProjectEntities())
            {
                var student = context.Students.FirstOrDefault(stud => stud.StudentId == Id);
                context.Students.Remove(student);
                context.SaveChanges();
                ShowStudentDetails();
            }
        }
    }
}
