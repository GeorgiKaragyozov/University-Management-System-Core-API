using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using University_Management_System_API.Authentication.Common;
using University_Management_System_API.Business.Processor.User;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Convertor.ApiSession;
using University_Management_System_API.Business.Processor.ApiSession;

namespace University_Management_System_API.Business.Processor.Auth
{
    public class AuthProcessor : IAuthProcessor
    {
        private IHttpContextAccessor _httpContextAccessor;
        public IHttpContextAccessor HttpContextAccessor
        {
            get { return this._httpContextAccessor; }
            set { this._httpContextAccessor = value; }
        }


        private IApiSessionProcessor _apiSessionProcessor;
        public IApiSessionProcessor ApiSessionProcessor
        {
            get { return this._apiSessionProcessor; }
            set { this._apiSessionProcessor = value; }
        }


        private IUserProcessor _userProcessor;
        public IUserProcessor UserProcessor
        {
            get { return this._userProcessor; }
            set { this._userProcessor = value; }
        }

        public AuthProcessor(
            IHttpContextAccessor httpContextAccessor,
            IApiSessionProcessor apiSessionProcessor,
            IUserProcessor userProcessor)
        {
            this.HttpContextAccessor = httpContextAccessor;
            this.ApiSessionProcessor = apiSessionProcessor;
            this.UserProcessor = userProcessor;
        }

        public string GetAuthToken()
        {
            UserResult result;
            ApiSessionParam param;

            try
            {
                var userId = HttpContextAccessor
                    .HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                result = UserProcessor.Find("Id", userId).SingleOrDefault();

                string randomToken = GenerateRandomToken.GenerateToken();

                param = new ApiSessionParam()
                {
                    AuthToken = randomToken,
                    UserId = result.Id,
                    Name = result.StatusName,
                    Active = result.Active
                };

                ApiSessionProcessor.Create(param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return param.AuthToken;
        }

        public void RemoveApiSession()
        {
            try
            {
                ApiSessionResult result = new ApiSessionResult();

                var authHeader = HttpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

                result = ApiSessionProcessor.Find("token", authHeader).SingleOrDefault();

                ApiSessionProcessor.Delete(result.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }     
        }
    }
}
