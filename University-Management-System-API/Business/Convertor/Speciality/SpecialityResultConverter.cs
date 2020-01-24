using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Speciality
{
    public class SpecialityResultConverter 
        : BaseResultConverter<Model.Speciality, SpecialityResult>, ISpecialityResultConverter
    {
        public override void ConvertSpecific(Model.Speciality param, SpecialityResult result)
        {
            //result.EducationalDegrees = param.EducationalDegrees;
            //result.TrainingType = param.TrainingType;

            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
            result.FacultyId = param.Faculty.Id;
            result.FacultyName = param.Faculty.Name;
            result.EducationalDegreeId = param.EducationalDegree.Id;
            result.EducationalDegreeName = param.EducationalDegree.Name;
        }

        public override SpecialityResult GetResult()
        {
            return new SpecialityResult();
        }
    }
}
