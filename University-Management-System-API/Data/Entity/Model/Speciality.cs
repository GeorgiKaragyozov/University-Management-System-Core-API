namespace University_Management_System_API.Model
{
    public class Speciality : NamedPersistent
    {
        public virtual SpecialityStatus Status { get; set; }

        public virtual EducationalDegree EducationalDegree { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
