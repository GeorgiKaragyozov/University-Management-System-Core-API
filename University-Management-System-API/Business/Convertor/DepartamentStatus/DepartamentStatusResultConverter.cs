using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusResultConverter 
        : BaseResultConverter<Model.DepartamentStatus, DepartamentStatusResult>, IDepartamentStatusResultConverter
    {
        public override void ConvertSpecific(Model.DepartamentStatus param,
            DepartamentStatusResult result) 
        { }

        public override DepartamentStatusResult GetResult()
        {
            return new DepartamentStatusResult();
        }
    }
}
