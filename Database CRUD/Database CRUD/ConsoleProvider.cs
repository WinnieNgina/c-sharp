using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Database_CRUD
{
    public class ConsoleProvider// prompts the user to input data
    {
        BusinessLogic businessLogic = new BusinessLogic();//Instance of class BusinessLogic to add data to the db
        private void GetStudents(int TeacherId)//method for getting the data
        {
            Console.WriteLine("Enter your name?");
            string Students_Name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth yyyy-mm-dd?");
            DateTime Date_Of_Birth = DateTime.Parse(Console.ReadLine());
            businessLogic.AddStudent(Students_Name, Date_Of_Birth, TeacherId);//Adding the data received to the database
        }
        public void AddStudentWithTeacherId()
        {
            List<Teacher> teachers = businessLogic.GetTeachers();// Fetch data in the teacher's table
            for (int i = 0; i < teachers.Count; i++) 
            { 
                Teacher mwalimu = teachers[i];
                NumberOfStudents(mwalimu.Id); // Use id retrieved and call the number of students method to help in getting students details
            }
        }

        private void NumberOfStudents(int TeacherId)
        {
            Console.WriteLine("Please enter number of students");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                GetStudents(TeacherId);
            }
        }
        public void PrintStudentData()
        {
            List <Student> students = businessLogic.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                Student S = students[i];
                Console.WriteLine($"Students name is {S.Name} and age is {S.DateOfBirth} and the teacher Id is {S.TeacherId}");
            }
        }
        private void GetTeachers()
        {
            Console.WriteLine("Please enter teacher's name? ");
            string TeachersName = Console.ReadLine();
            Console.WriteLine("Please enter Tsc No ?");
            int TscNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your DOB in this format yyyy-mm-dd ");
            DateTime DOB = DateTime.Parse(Console.ReadLine());
            businessLogic.AddTeacher(TeachersName, DOB, TscNo);
        }
        public void NumTeachers()
        {
            Console.WriteLine("Please enter number of teachers?");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 0; i < Num; i++)
            {
                GetTeachers();
            }
        }
        public void PrintTeacherData()
        {
            List <Teacher> teachers = businessLogic.GetTeachers();
            for (int i = 0; i < teachers.Count; i++)
            {
                Teacher Q = teachers[i];
                Console.WriteLine($"The teacher's name is {Q.Name} and their Tsc no is {Q.TscNo} and they were born in {Q.DateOfBirth}");
            }
        }
    }
}
