using Microsoft.AspNetCore.Authorization;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Processor.User;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.User
{
    [Authorize]
    public class UserController
        : BaseController<UserParam, UserResult, long, IUserProcessor>
    {
        public UserController(IUserProcessor processor)
            : base(processor)
        {

        }
    }
}
