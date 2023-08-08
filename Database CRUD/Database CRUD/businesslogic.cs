using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_CRUD
{
    public class BusinessLogic
        // This class add data to the database
    {
        private SchoolDBContext _dbContext;
        //Stores all our db tables- instance of db
        public BusinessLogic()
        { 
            _dbContext = new SchoolDBContext();// intialize db context
        }
        public void AddStudent(string Name, DateTime DateOfBirth, int TeacherId ) //Instance of class student 
        {
            Student student = new Student();
            student.Name = Name;
            student.DateOfBirth = DateOfBirth;
            student.TeacherId = TeacherId;
            _dbContext.Students.Add(student);// Inserting student details to the student table
            _dbContext.SaveChanges();//Persist the data
        }
        public List <Student> GetStudents() //Retrieve data the database
        {
            return _dbContext.Students.ToList();
        }
        public void AddTeacher (string Name, DateTime DateOfBirth, int TscNo) 
        {
            Teacher teacher = new Teacher();
            teacher.Name = Name;
            teacher.TscNo = TscNo;
            teacher.DateOfBirth = DateOfBirth;
            _dbContext.Teachers.Add(teacher);
            _dbContext.SaveChanges();
        }
        public List <Teacher> GetTeachers() 
        {
            return _dbContext.Teachers.ToList();
        }

    }
}
