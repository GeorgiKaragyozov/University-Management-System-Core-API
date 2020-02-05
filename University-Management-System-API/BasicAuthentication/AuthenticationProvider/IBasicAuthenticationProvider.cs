using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using University_Management_System_API.Business.Convertor.User;

namespace University_Management_System_API.BasicAuthentication.AuthenticationProvider
{
    public interface IBasicAuthenticationProvider
    {
        Task<UserResult> AuthenticateAsync(HttpRequest request);

        Task<List<string>> GetUserGroupsAsync(UserResult result);
    }
}
