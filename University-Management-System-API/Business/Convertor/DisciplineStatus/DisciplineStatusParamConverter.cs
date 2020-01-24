using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusParamConverter 
        : BaseParamConverter<DisciplineStatusParam, Model.DisciplineStatus>, IDisciplineStatusParamConverter
    {
        public override Model.DisciplineStatus GetEntity(DisciplineStatusParam param)
        {
            return new Model.DisciplineStatus();
        }

        public override void ConvertSpecific(DisciplineStatusParam param,
            Model.DisciplineStatus entity)
        { }
    }
}
