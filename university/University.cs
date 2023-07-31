namespace Reggy;

public class University:Base_Model
{
    public string Location { get; set; }
    public List<School> List_Schools{ get; set; } = new List<School>();
}