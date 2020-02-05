using System.Collections.Generic;
using System.Threading.Tasks;
using University_Management_System_API.Business.Convertor.UserUserGroup;
using University_Management_System_API.Business.Processor.Common;

namespace University_Management_System_API.Business.Processor.UserUserGroup
{
    public interface IUserUserGroupProcessor : IBaseProcessor<UserUserGroupParam, UserUserGroupResult, long>
    {

    }
}
