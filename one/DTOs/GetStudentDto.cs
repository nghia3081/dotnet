namespace one.DTOs
{
    public class GetStudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Description
        {
            get
            {
                string genderStr = Gender ? "Male" : "Female";
                return $"{Name}: {genderStr}";
            }
        } //= Name + ":" + "Gender"
    }
}
