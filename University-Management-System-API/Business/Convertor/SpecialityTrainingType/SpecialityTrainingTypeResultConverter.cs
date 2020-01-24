using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.SpecialityTrainingType
{
    public class SpecialityTrainingTypeResultConverter
         : BaseResultConverter<Model.SpecialityTrainingType, SpecialityTrainingTypeResult>,
           ISpecialityTrainingTypeResultConverter
    {
        public override void ConvertSpecific(Model.SpecialityTrainingType param,
            SpecialityTrainingTypeResult result)
        {
            result.SpecialityId = param.Speciality.Id;
            result.SpecialityName = param.Speciality.Name;
            result.TrainingTypeId = param.TrainingType.Id;
            result.TrainingTypeName = param.TrainingType.Name;
        }

        public override SpecialityTrainingTypeResult GetResult()
        {
            return new SpecialityTrainingTypeResult();
        }
    }
}
