using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.ApiSession
{
    public class ApiSessionResultConverter
         : BaseResultConverter<Model.ApiSession, ApiSessionResult>, IApiSessionResultConverter
    {
        public override void ConvertSpecific(Model.ApiSession param, ApiSessionResult result)
        {

        }

        public override ApiSessionResult GetResult()
        {
            return new ApiSessionResult();
        }
    }
}
