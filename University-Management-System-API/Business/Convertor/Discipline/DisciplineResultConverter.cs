using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Discipline
{
    public class DisciplineResultConverter 
        : BaseResultConverter<Model.Discipline, DisciplineResult>, IDisciplineResultConverter
    {
        public override void ConvertSpecific(Model.Discipline param, DisciplineResult result)
        {
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override DisciplineResult GetResult()
        {
            return new DisciplineResult();
        }
    }
}
