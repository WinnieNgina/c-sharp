namespace Reggy;

public class University_Data_Access_Layer
{
    private List<University> List_of_Universities = new List<University>();
    public Students Add_Student (string Name, int id, DateTime Date)
    {
        Students student = new Students ();
        student.Date_of_birth = Date;
        student.Name = Name;
        student.Id = id;       
        return student;
    }
    public Courses Add_Courses (string Name, int id)
    {
        Courses course = new Courses ();
        course.Id = id;
        course.Name = Name;
        return course;
    }
    public Courses Add_Student_To_Course (Courses course, Students student)
    {
        course.List_Students.Add(student);
        return course;
    }
    public Department Add_Departments (string Name, int id)
    {
        Department Departments = new Department ();
        Departments.Id = id;
        Departments.Name = Name;
        return Departments;
    }
    public Department Add_Course_To_Department (Department Departments, Courses course)
    {
        Departments.List_Courses.Add(course);
        return Departments;
    }
    public School Add_School (string Name, int id)
    {
        School schools = new School ();
        schools.Id = id;
        schools.Name = Name;
        return schools;
    }
    public School Add_Department_To_School (Department Departments, School schools)
    {
        schools.List_Departments.Add(Departments);
        return schools;
    }
    public University Add_University (string Name, int id)
    {
        University universities = new University ();
        universities.Id = id;
        universities.Name = Name;
        return universities;
    }
    public University Add_School_To_University (School schools, University universities)
    {
        universities.List_Schools.Add(schools);
        return universities;
    }
    public void Add_University_To_List(University universities)
    {
        List_of_Universities.Add(universities);
    }
    public List<University> GetUniversities()
    {
        return List_of_Universities;
    }
}
