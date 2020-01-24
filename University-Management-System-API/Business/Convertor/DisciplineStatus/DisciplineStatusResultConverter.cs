using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusResultConverter 
        : BaseResultConverter<Model.DisciplineStatus, DisciplineStatusResult>, IDisciplineStatusResultConverter
    {

        public override void ConvertSpecific(Model.DisciplineStatus param,
            DisciplineStatusResult result)
        { }

        public override DisciplineStatusResult GetResult()
        {
            return new DisciplineStatusResult();
        }
    }
}
