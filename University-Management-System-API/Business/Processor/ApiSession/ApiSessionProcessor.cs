using University_Management_System_API.Business.Convertor.ApiSession;
using University_Management_System_API.Business.Processor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.ApiSession;

namespace University_Management_System_API.Business.Processor.ApiSession
{
    public class ApiSessionProcessor
         : BaseProcessor<IApiSessionParamConverter, IApiSessionResultConverter, ApiSessionParam, ApiSessionResult,
            IApiSessionDao, long, Model.ApiSession>, IApiSessionProcessor
    {
        protected override long GetTPK(ApiSessionParam param)
        {
            return param.Id;
        }

        public ApiSessionProcessor(IApiSessionDao dao,
           IApiSessionParamConverter paramConverter,
           IApiSessionResultConverter resultConverter)

           : base(dao, paramConverter, resultConverter)
        {

        }
    }
}
