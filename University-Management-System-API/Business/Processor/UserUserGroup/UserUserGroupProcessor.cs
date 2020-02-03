using System.Collections.Generic;
using System.Threading.Tasks;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Convertor.UserGroup;
using University_Management_System_API.Business.Convertor.UserUserGroup;
using University_Management_System_API.Business.Processor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup;

namespace University_Management_System_API.Business.Processor.UserUserGroup
{
    public class UserUserGroupProcessor
         : BaseProcessor<IUserUserGroupParamConverter, IUserUserGroupResultConverter, UserUserGroupParam,
             UserUserGroupResult, IUserUserGroupDao, long, Model.UserUserGroup>, IUserUserGroupProcessor
    {
        protected override long GetTPK(UserUserGroupParam param)
        {
            return param.Id;
        }

        public UserUserGroupProcessor(IUserUserGroupDao dao,
            IUserUserGroupParamConverter paramConverter,
            IUserUserGroupResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {

        }

        public async Task<List<string>> GetUserGroupsAsync(UserUserGroupParam param)
        {
            Model.UserUserGroup entity = new Model.UserUserGroup();

            entity = ParamConverter.Convert(param, entity);

            return await Dao.GetUserGroupsAsync(entity);
        }
    }
}
