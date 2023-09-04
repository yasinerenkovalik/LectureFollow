namespace Domain;

public class Lecture:BaseEntity
{
    public string Name { get; set; }
    public int FacultyId { get; set; }
    public string Semester { get; set; }
    public float Credit { get; set; }
}