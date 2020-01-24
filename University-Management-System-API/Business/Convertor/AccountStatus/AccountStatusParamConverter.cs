using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter 
        : BaseParamConverter<AccountStatusParam, Model.AccountStatus>, IAccountStatusParamConverter
    {
        public override Model.AccountStatus GetEntity(AccountStatusParam param)
        {
            return new Model.AccountStatus();
        }

        public override void ConvertSpecific(AccountStatusParam param, Model.AccountStatus entity) { }
    }
}
