using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.AccountType
{
    public class AccountTypeResultConverter
        : BaseResultConverter<Model.AccountType, AccountTypeResult>, IAccountTypeResultConverter
    {
        public override void ConvertSpecific(Model.AccountType param, AccountTypeResult result) {}

        public override AccountTypeResult GetResult()
        {
            return new AccountTypeResult();
        }
    }
}
