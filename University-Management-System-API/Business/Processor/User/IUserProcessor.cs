using System.Threading.Tasks;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Processor.Common;

namespace University_Management_System_API.Business.Processor.User
{
    public interface IUserProcessor : IBaseProcessor<UserParam, UserResult, long>
    {
        Task<UserResult> Authenticate(UserParam param);
    }
}
