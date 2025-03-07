namespace MyCourses.Models;

public class Course(int id, string title, string desc, string img)
{
    public int Id { get; set; } = id;
    public string Title { get; set; } = title;
    public string Description { get; set; } = desc;
    public string ImagePath { get; set; } = img;

    public override string ToString()
    {
        return $"{Id} - {Title} ({Description})";
    }
}
