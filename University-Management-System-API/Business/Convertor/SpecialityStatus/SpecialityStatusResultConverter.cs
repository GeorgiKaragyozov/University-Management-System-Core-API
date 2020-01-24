using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusResultConverter 
        : BaseResultConverter<Model.SpecialityStatus, SpecialityStatusResult>, ISpecialityStatusResultConverter
    {
        public override void ConvertSpecific(Model.SpecialityStatus param, 
            SpecialityStatusResult result)
        { }

        public override SpecialityStatusResult GetResult()
        {
            return new SpecialityStatusResult();
        }
    }
}
