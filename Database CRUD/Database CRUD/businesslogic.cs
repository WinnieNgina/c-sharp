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
        public void AddStudent (string Name, DateTime DateOfBirth) //Instance of class student 
        {
            Student student = new Student();
            student.Name = Name;
            student.DateOfBirth = DateOfBirth;
            _dbContext.Students.Add(student);// Inserting student details to the student table
            _dbContext.SaveChanges();//Persist the data
        }
        public List<Student> GetStudents() //Retrieve data the database
        {
            return _dbContext.Students.ToList();
        }
    }
}
