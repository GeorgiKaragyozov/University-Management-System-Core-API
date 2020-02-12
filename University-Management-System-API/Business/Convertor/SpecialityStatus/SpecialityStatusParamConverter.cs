using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusParamConverter 
        : BaseParamConverter<SpecialityStatusParam, Model.SpecialityStatus>, ISpecialityStatusParamConverter
    {
        public override Model.SpecialityStatus GetEntity(SpecialityStatusParam param)
        {
            return new Model.SpecialityStatus();
        }

        public override void ConvertSpecific(SpecialityStatusParam param,
            Model.SpecialityStatus entity)
        {
        }
    }
}
