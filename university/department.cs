namespace Reggy;

public class Department:Base_Model
{
    public List<Courses> List_Courses { get; set; } = new List<Courses>();    
}