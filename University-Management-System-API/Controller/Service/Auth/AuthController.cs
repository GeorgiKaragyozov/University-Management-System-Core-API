using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using University_Management_System_API.Business.Processor.Auth;

namespace University_Management_System_API.Controller.Service.Auth
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthProcessor _processor;
        public IAuthProcessor Processor
        {
            get { return this._processor; }
            set { this._processor = value; }
        }

        public AuthController(IAuthProcessor processor)
        {
            this.Processor = processor;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <returns>new param</returns>
        /// <response code="200">Login Successfully</response>
        /// <response code="400"></response> 
        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Login()
        {
            string authTokenUser = Processor.GetAuthToken();

            return Ok(authTokenUser);
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <returns>new param</returns>
        /// <response code="200">Logout Successfully</response>
        /// <response code="400"></response> 
        [HttpPost("Logout")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Logout()
        {
            Processor.RemoveApiSession();

            return Ok("Session was successfully delete.");
        }
    }
}
