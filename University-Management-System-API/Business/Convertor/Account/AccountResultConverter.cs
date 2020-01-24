using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Account
{
    public class AccountResultConverter
        : BaseResultConverter<Model.Account, AccountResult>, IAccountResultConverter
    {
        public override void ConvertSpecific(Model.Account param, AccountResult result)
        {
            result.UserId = param.User.Id;
            result.UserName = param.User.Username;
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
            result.SpecialityId = param.Speciality.Id;
            result.SpecialityName = param.Speciality.Name;
            if(param.Departament != null)
            {
                result.DepartamentId = param.Departament.Id;
                result.DepartamentName = param.Departament.Name;
            }      
            result.TypeId = param.TypeAccount.Id;
            result.TypeName = param.TypeAccount.Name;
        }

        public override AccountResult GetResult()
        {
            return new AccountResult();
        }
    }
}
