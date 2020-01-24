namespace University_Management_System_API.Model
{
    public class SpecialityTrainingType : NamedPersistent
    {
        public virtual TrainingType TrainingType { get; set; }

        public virtual Speciality Speciality { get; set; }
    }
}
