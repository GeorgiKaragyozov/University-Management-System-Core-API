using System.Threading.Tasks;
using University_Management_System_API.Business.Convertor.User;

namespace University_Management_System_API.BasicAuthentication.AuthenticationProvider
{
    public interface IAuthenticationProvider 
    {
        Task<UserResult> Authenticate(UserParam param);
    }
}
