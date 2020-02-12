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

        /// <summary>
        /// Create new session for user and return token
        /// </summary>
        /// <returns>User's token</returns>
        public string GetAuthToken()
        {
            UserResult result;
            ApiSessionParam param;

            try
            {
                //Get user's id with claim type 
                var userId = HttpContextAccessor
                    .HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                //Get user result with function find by field
                result = UserProcessor.Find("Id", userId).SingleOrDefault();
                
                //return random token for user
                string randomToken = GenerateRandomToken.GenerateToken();

                param = new ApiSessionParam()
                {
                    AuthToken = randomToken,
                    UserId = result.Id,
                    Name = result.StatusName,
                    Code = result.Username,
                    Description = $"This is {result.Username} with session created on {System.DateTime.Now}",
                    Active = result.Active
                };

                //creta new session for user
                ApiSessionProcessor.Create(param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return param.AuthToken;
        }

        /// <summary>
        /// Remove User's Session
        /// </summary>
        public void RemoveApiSession()
        {
            try
            {
                ApiSessionResult result = new ApiSessionResult();

                var authHeader = HttpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

                result = ApiSessionProcessor.Find("token", authHeader).SingleOrDefault();

                ApiSessionProcessor.Erase(result.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }     
        }
    }
}
