using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.AccountStatus
{
    public class AccountStatusResultConverter 
        : BaseResultConverter<Model.AccountStatus, AccountStatusResult>, IAccountStatusResultConverter
    {
        public override void ConvertSpecific(Model.AccountStatus param, AccountStatusResult result) { }

        public override AccountStatusResult GetResult()
        {
            return new AccountStatusResult();
        }
    }
}
