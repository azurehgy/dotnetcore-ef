using EFDotnetcore.Models;
using System;
using System.Linq;

namespace EFDotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new SchoolContext())
            //{

            //    var std = new Student()
            //    {
            //        Name = "Bill"
            //    };

            //    context.Students.Add(std);
            //    context.SaveChanges();
            //}
            var context = new SchoolContext();
            var studentsWithSameName = context.Students
                                              .Where(s => s.Name == GetName())
                                              .ToList();
            Console.WriteLine(studentsWithSameName[0].StudentId.ToString());
        }

        public static string GetName()
        {
            return "Bill";
        }
    }
}
