using ConsoleTables;
using OneToManyDemoDBFirst.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst
{
    public class FilterInStudent
    {
        static readonly StudentProjectEntities context = new StudentProjectEntities();
        public static void FindStudentName()
        {
            using(context)
            {
                var student = context.Students.Find(1);
                Console.WriteLine(student.StudentName);
            }
        }
        public static void GroupProjectName()
        {
            using (context)
            {
                //var students = from s in context.Students
                //               group s by s.ProjectId into StudentByProject
                //               select StudentByProject;

                var students = context.Students.GroupBy(x => x.ProjectId);
                var consoleTable = new ConsoleTable("StudentId", "StudentName","ProjectId");
                foreach(var student in students)
                {
                    //Console.WriteLine(student.Key);
                    foreach(var stud in student)
                    {
                        consoleTable.AddRow(stud.StudentId, stud.StudentName,stud.ProjectId); 
                    }
                }
                consoleTable.Write();
            }
        }
        public static void OrderByProjectId()
        {
            using(context)
            {
                //var students = context.Students.OrderBy(x => x.ProjectId);
                var students = from student in context.Students
                               orderby student.StudentId
                               select student;
                var consoleTable = new ConsoleTable("StudentId", "StudentName", "ProjectId");
                foreach (var stud in students)
                {
                    consoleTable.AddRow(stud.StudentId, stud.StudentName, stud.ProjectId);
                }
                consoleTable.Write();
            }
        }
        public static void JoinQuery()
        {
            using(context)
            {
                var studentProject = context.Students.Join(context.Projects,
                                                           stud => stud.ProjectId,
                                                           pro => pro.ProjectId,
                                                           (stud, pro) => new
                                                           {
                                                               StudentName = stud.StudentName,
                                                               ProjectName = pro.ProjectName,
                                                           });
                var consoleTable = new ConsoleTable("StudentName", "ProjectName");
                foreach (var stud in studentProject)
                {
                    consoleTable.AddRow(stud.StudentName, stud.ProjectName);
                }
                consoleTable.Write();

            }
        }
        public static void GroupJoinQuery()
        {
            using(context)
            {
                var studentProject = context.Students.GroupJoin(context.Projects,
                                                                stud => stud.ProjectId,
                                                                pro => pro.ProjectId,
                                                                (stud, projectGroup) =>
                                                                new
                                                                {
                                                                    ProjectsList = projectGroup,
                                                                    StudName = stud.StudentName,
                                                                });
                var consoleTable = new ConsoleTable("ProjectName","StudentName");
                foreach (var student in studentProject)
                {
                    foreach (var stud in student.ProjectsList)
                    {
                        consoleTable.AddRow(stud.ProjectName,student.StudName);
                    } 
                }
                consoleTable.Write();
            }
        }
        public static void CountProjectWise()
        {
            using (context)
            {
                var query = context.Students.Join(context.Projects,
                                                   stud => stud.ProjectId,
                                                   pro => pro.ProjectId,
                                                   (stud, pro) => new
                                                   {
                                                       studName = stud.StudentName,
                                                       proName = pro.ProjectName,
                                                   }).GroupBy(x => new {x.proName}).ToList();

                var consoleTable = new ConsoleTable("StudentName","ProjectName","ProjectCount");
                foreach (var student in query)
                {
                    foreach (var stud in student)
                    {
                        consoleTable.AddRow(stud.studName,student.Key.proName, student.Count());
                    }
                }
                consoleTable.Write();
            }
        }
    }
}
