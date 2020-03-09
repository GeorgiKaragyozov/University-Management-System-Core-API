using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University_Management_System_API.Business.Convertor.ApiSession;
using University_Management_System_API.Business.Processor.ApiSession;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.ApiSession
{
    public class ApiSessionController
        : BaseController<ApiSessionParam, ApiSessionResult, long, IApiSessionProcessor>
    {
        public ApiSessionController(IApiSessionProcessor processor)
            : base(processor)
        {

        }
    }
}
