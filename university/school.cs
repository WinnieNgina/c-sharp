namespace Reggy;
public class School:Base_Model
{
    public List<Department> List_Departments { get; set; } = new List<Department>();
}