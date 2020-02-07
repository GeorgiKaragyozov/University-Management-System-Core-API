using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Processor.User;
using University_Management_System_API.Business.Processor.UserUserGroup;

namespace University_Management_System_API.BasicAuthentication.AuthenticationProvider
{
    public class BasicAuthenticationProvider : IBasicAuthenticationProvider
    {
        private IUserProcessor _processorUser;
        public IUserProcessor ProcessorUser
        {
            get { return _processorUser; }
            set { _processorUser = value; }
        }

        private IUserUserGroupProcessor _processorUserUserGroup;

        public IUserUserGroupProcessor ProcessorUserUserGroup
        {
            get { return _processorUserUserGroup; }
            set { _processorUserUserGroup = value; }
        }

        public BasicAuthenticationProvider(
            IUserProcessor processorUser,
            IUserUserGroupProcessor processorUserUserGroup)
        {
            this.ProcessorUser = processorUser;
            this.ProcessorUserUserGroup = processorUserUserGroup;
        }

        public async Task<UserResult> AuthenticateAsync(HttpRequest request)
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

        public async Task<List<string>> GetUserGroupsAsync(UserResult result)
        {
            return await Task.Run(() => 
                ProcessorUserUserGroup.Find("UserId", result.Id.ToString())
                .Select(x => x.UserGroupName)
                .ToList());
        }
    }
}
