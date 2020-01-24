using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.TrainingType
{
    public class TrainingTypeResultConverter
        : BaseResultConverter<Model.TrainingType, TrainingTypeResult>, ITrainingTypeResultConverter
    {
        public override void ConvertSpecific(Model.TrainingType param, TrainingTypeResult result) { }

        public override TrainingTypeResult GetResult()
        {
            return new TrainingTypeResult();
        }
    }
}
