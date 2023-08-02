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
        private void GetStudents()//method for getting the data
        {
            Console.WriteLine("Enter your name?");
            string Students_Name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth yyyy-mm-dd?");
            DateTime Date_Of_Birth = DateTime.Parse(Console.ReadLine());
            businessLogic.AddStudent(Students_Name, Date_Of_Birth);//Adding the data received to the database
        }
        public void NumberOfStudents()
        {
            Console.WriteLine("Please enter number of students");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                GetStudents();
            }
        }
        public void printData()
        {
            List <Student> students = businessLogic.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                Student S = students[i];
                Console.WriteLine($"Students name is {S.Name} and age is {S.DateOfBirth}");
            }
        }
    }
}
