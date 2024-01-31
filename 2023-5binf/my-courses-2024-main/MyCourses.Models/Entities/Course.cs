namespace MyCourses.Models.Entities
{
    public class Course(int id, string title, string description, string imagePath)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
        public string Description { get; set; } = description;
        public string ImagePath { get; set; } = imagePath;

        public override string ToString()
        {
            return $"{Id} - Titolo: {Title} - {Description}";
        }
    }
}