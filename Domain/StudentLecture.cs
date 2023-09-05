namespace Domain;

public class StudentLecture:BaseEntity
{
    public int StudetId { get; set; }
    public int LectureId { get; set; }
    public bool Succesful { get; set; }
}