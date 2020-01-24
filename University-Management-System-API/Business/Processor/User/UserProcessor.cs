using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Processor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.User;

namespace University_Management_System_API.Business.Processor.User
{
    public class UserProcessor
        : BaseProcessor<IUserParamConverter, IUserResultConverter, UserParam, UserResult, IUserDao, long,
            Model.User>, IUserProcessor
    {
        protected override long GetTPK(UserParam param)
        {
            return param.Id;
        }

        public UserProcessor(IUserDao dao,
            IUserParamConverter paramConverter,
            IUserResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {

        }
    }
}
