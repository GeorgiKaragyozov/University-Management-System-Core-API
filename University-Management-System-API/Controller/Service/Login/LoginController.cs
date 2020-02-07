using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using University_Management_System_API.Business.Processor.Login;

namespace University_Management_System_API.Controller.Service.Login
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class LoginController : ControllerBase
    {
        private ILoginProcessor _processor;

        public ILoginProcessor Processor
        {
            get { return this._processor; }
            set { this._processor = value; }
        }

        public LoginController(ILoginProcessor processor)
        {
            this.Processor = processor;
        }

        [HttpPost("Login")]
        public ActionResult Login()
        {
            string authTokenUser = Processor.GetAuthToken();

            return Ok(authTokenUser);
        }
    }
}
