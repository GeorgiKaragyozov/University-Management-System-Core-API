﻿using System.Threading.Tasks;
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

        public async Task<UserResult> AuthenticateAsync(UserParam param)
        {
            Model.User entity = new Model.User();

            entity = ParamConverter.ConvertStandart(param, entity);

            entity = await Dao.AuthenticateAsync(entity);

            UserResult result = new UserResult();
            result = ResultConverter.ConvertStandart(entity, result);

            return result;
        }           
    }
}
