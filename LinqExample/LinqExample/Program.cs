using LinqExample;

List<Student> students = new List<Student>();
Student student1 = new Student();
student1.Name = "Winnie";
student1.Age = 30;
students.Add(student1);

Student student2 = new Student();
student2.Name = "Jose";
student2.Age = 24;
students.Add(student2);

Student student3 = new Student();
student3.Name = "Cyril";
student3.Age = 22;
students.Add(student3);

Student student4 = new Student();
student4.Name = "Kilonzo";
student4.Age = 12;
students.Add(student4);

Student student5 = new Student();
student5.Name = "Effie";
student5.Age = 23;
students.Add(student5);

Student student6 = new Student();
student6.Name = "Joy";
student6.Age = 38;
students.Add(student6);

Student student7 = new Student();
student7.Name = "Betty";
student7.Age = 40;
students.Add(student7);

Student student8 = new Student();
student8.Name = "Mercy";
student8.Age = 42;
students.Add(student8);

Student student9 = new Student();
student9.Name = "Exodus";
student9.Age = 60;
students.Add(student9);

Student student10 = new Student();
student10.Name = "Daniel";
student10.Age = 65;
students.Add(student10);
// filter students whose age is above 30 years
var Student30 = students.Where(x => x.Age > 20 && x.Age <= 30).ToList();
foreach (var student in Student30) 
{
    Console.WriteLine($"The students name is {student.Name} and they are {student.Age}");
}
var SpecName = students.Where(x => x.Name == "Exodus");
foreach (var student in SpecName) 
{
    Console.WriteLine($"The students name is {student.Name}");
}
//where is the link in this case. It helps in manipulation of a list