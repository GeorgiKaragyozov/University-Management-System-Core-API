using System;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using University_Management_System_API.Business.Convertor.ApiSession;
using University_Management_System_API.Business.Processor.ApiSession;

namespace University_Management_System_API.Business.Processor.Login
{
    public class LoginProcessor : ILoginProcessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private IApiSessionProcessor _apiSessionProcessor;

        public IApiSessionProcessor ApiSessionProcessor
        {
            get { return this._apiSessionProcessor; }
            set { this._apiSessionProcessor = value; }
        }

        public LoginProcessor(
            IHttpContextAccessor httpContextAccessor,
            IApiSessionProcessor apiSessionProcessor)
        {
            this._httpContextAccessor = httpContextAccessor;
            this.ApiSessionProcessor = apiSessionProcessor;
        }

        public string GetAuthToken()
        {
            //token user
            //var authHeader = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

            ApiSessionParam param;

            try
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                param = new ApiSessionParam()
                {
                    AuthToken = RandomAuthTokenGenerator(),
                    UserId = Convert.ToUInt32(userId)
                };

                ApiSessionProcessor.Create(param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return param.AuthToken;
        }

        public string RandomAuthTokenGenerator()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[20];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string authToken = new String(stringChars);

            authToken = ComputeSha512Hash(authToken);

            return authToken;
        }

        public string ComputeSha512Hash(string token)
        {  
            using SHA512 sha512Hash = SHA512.Create();
            // ComputeHash - returns byte array  
            byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(token));

            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }     
    }
}
