namespace StajProje.Shared.DTO
{
    public class Student
    {

        public int id { get; set; }
        public bool? active { get; set; }
        public String? Name { get; set; }
        public String? Surname { get; set; }
        public String? Email { get; set; }
        public String? Password { get; set; }
        public int? role { get; set; }

    }
}
