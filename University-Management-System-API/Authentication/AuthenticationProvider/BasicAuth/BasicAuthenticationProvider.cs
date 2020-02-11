using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using University_Management_System_API.Business.Processor.User;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Processor.ApiSession;
using University_Management_System_API.Business.Processor.UserUserGroup;
using University_Management_System_API.Authentication.AuthenticationProvider.BasicAuth;

namespace University_Management_System_API.Authentication.AuthenticationProvider
{
    public class BasicAuthenticationProvider : BaseAuthenticationProvider, IBasicAuthenticationProvider
    {
        private IApiSessionProcessor _apiSessionProcessor;
        public IApiSessionProcessor ApiSessionProcessor
        {
            get { return this._apiSessionProcessor; }
            set { this._apiSessionProcessor = value; }
        }

        public BasicAuthenticationProvider(
            IUserProcessor processorUser,
            IUserUserGroupProcessor processorUserUserGroup,
            IApiSessionProcessor apiSessionProcessor)

            : base(processorUser, processorUserUserGroup)
        {
            this.ApiSessionProcessor = apiSessionProcessor;
        }

        public async override Task<UserResult> AuthenticateAsync(HttpRequest request)
        {
            var authHeader = AuthenticationHeaderValue.Parse(request.Headers["Authorization"]);
            var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
            var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);

            UserParam param = new UserParam
            {
                Username = credentials[0],
                Password = credentials[1]
            };

            UserResult result = await ProcessorUser.AuthenticateAsync(param);

            return result;
        }
    }
}
