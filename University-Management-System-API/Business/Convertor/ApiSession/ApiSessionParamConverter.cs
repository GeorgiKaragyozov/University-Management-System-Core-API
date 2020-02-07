using System;
using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.ApiSession
{
    public class ApiSessionParamConverter
         : BaseParamConverter<ApiSessionParam, Model.ApiSession>, IApiSessionParamConverter
    {
        public override void ConvertSpecific(ApiSessionParam param, Model.ApiSession entity)
        {

        }

        public override Model.ApiSession GetEntity(ApiSessionParam param)
        {
            return new Model.ApiSession
            {
                Id = param.Id,
                Code = param.Code
            };
        }
    }
}
