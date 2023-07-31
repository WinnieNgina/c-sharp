namespace Reggy;
public class Courses:Base_Model
{
    public List<Students> List_Students { get; set; } = new List<Students>();
}