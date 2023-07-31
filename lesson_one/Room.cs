namespace lesson_one{
public class Room
{
    public int No_Of_Rooms {get; set;}
    public int No_Of_bathrooms {get; set;}
    public string[] Room_Names {get; set;}
    public int Len_Rooms()
    {
        return Room_Names.Length;
    }

}
}