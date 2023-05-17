using ConsoleTables;
using OneToManyDemoDBFirst.Delegates;
using OneToManyDemoDBFirst.UserInputFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst
{
    public class CodeWithProject 
    {
        public static int Id;
        static TypeConvertDelegate<DateTime> DateTimeConvert = new TypeConvertDelegate<DateTime>(ConvertValue.ConvertDateTime);
        static TypeConvertDelegate<int> IntegerConvert = new TypeConvertDelegate<int>(ConvertValue.ConvertInt);
        public static void InsertProjectDetails()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var project = new Project()
                {
                    ProjectName = UserInput.GetUserInput("Project name:"),
                    StartDate = DateTimeConvert(UserInput.GetUserInput("Project start date:")),
                    EndDate = DateTimeConvert(UserInput.GetUserInput("Project end date:")),
                };
                context.Projects.Add(project);
                context.SaveChanges();
                ShowProjectDetails();
            }
        }
        public static void ShowProjectDetails()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var projects = context.Projects.ToList();
                var consoleTable = new ConsoleTable("ProjectId", "ProjectName", "StartDate", "EndDate");
                foreach(var project in projects)
                {
                    consoleTable.AddRow(project.ProjectId, project.ProjectName,project.StartDate,project.EndDate);
                }
                consoleTable.Write();
            }
        }
        public static void UpdateProjectDetails()
        {
            Id = IntegerConvert(UserInput.GetUserInput("Enter project Id:"));
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var project = context.Projects.FirstOrDefault(pro => pro.ProjectId == Id);
                project.ProjectName = UserInput.GetUserInput("Project name:");
                project.StartDate = DateTimeConvert(UserInput.GetUserInput("Project start date:"));
                project.EndDate = DateTimeConvert(UserInput.GetUserInput("Project end date:"));
                context.SaveChanges();
                ShowProjectDetails();
            }
        }
        public static void DeleteProjectDetails()
        {
            Id = IntegerConvert(UserInput.GetUserInput("Enter project Id:"));
            using (StudentProjectEntities context = new StudentProjectEntities())
            {
                var project = context.Projects.FirstOrDefault(pro => pro.ProjectId == Id);
                context.Projects.Remove(project);
                context.SaveChanges();
                ShowProjectDetails();
            }
        }
    }
}
