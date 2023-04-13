namespace CVBlazor.Models
{
    public class Data
    {
        private List<Education> educations = new();
        private List<Experience> experiences = new();

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string MaritalStatus { get; set; } = string.Empty;
        public string DriverLicense { get; set; } = string.Empty;
        public string Profile { get; set; } = string.Empty;
        public List<Language> Languages { get; set; } = new();
        public List<Education> Educations { get => educations.OrderByDescending(x=>x.From).ThenByDescending(x=>x.To).ToList(); set => educations = value; }
        public List<Experience> Experiences { get => experiences.OrderByDescending(x => x.From).ThenByDescending(x => x.To).ToList(); set => experiences=value; }
        public List<Skill> Skills { get; set; } = new();
        public List<Course> Courses { get; set; } = new();


    }
    public class Language
    {
        public string   Name        { get; set; } = string.Empty;
        public int      Percentage  { get; set; } 
    }

    public class Education
    {
        public string   University  { get; set; } = string.Empty;
        public DateTime From        { get; set; }
        public DateTime To          { get; set; }
        public string   Discreption { get; set; } = string.Empty;

    }
    public class Experience
    {
        public string Company { get; set; } = string.Empty;
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Title { get; set; } = string.Empty;
    }
    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public int Percentage { get; set; } 
    }
    public class Course
    {
        public string   Name { get; set; } = string.Empty;
        public DateTime From { get; set; }
        public DateTime To      { get; set; }
    }

}
