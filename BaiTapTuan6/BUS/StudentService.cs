using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            StudentModel context = new StudentModel();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p=>p.MajorID == null).ToList();
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }

        public Student FindById(string studentID)
        {
            StudentModel context = new StudentModel();
            return context.Students.FirstOrDefault(p => p.StudentID == studentID);
        }

        public void InsertUpdate(Student s)
        {
            StudentModel context = new StudentModel();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }

        public void Delete(string studentID)
        {
            StudentModel context = new StudentModel();

            Student student = context.Students
                                     .FirstOrDefault(s => s.StudentID == studentID);

            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
