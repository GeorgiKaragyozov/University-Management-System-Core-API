﻿using University_Management_System_API.Business.Convertor.AccountStatus;
using University_Management_System_API.Business.Processor.AccountStatus;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.AccountStatus
{
    public class AccountStatusController 
        : BaseController<AccountStatusParam, AccountStatusResult, long, IAccountStatusProcessor>
    {
        public AccountStatusController(IAccountStatusProcessor processor)
            : base(processor)
        {

        }
    }
}
