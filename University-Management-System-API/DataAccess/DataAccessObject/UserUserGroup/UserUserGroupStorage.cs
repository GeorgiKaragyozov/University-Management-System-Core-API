using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup
{
    public class UserUserGroupStorage : BaseStorage<Model.UserUserGroup, long>, IUserUserGroupStorage
    {
        private readonly string _jsonFile = @"";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.UserUserGroup entity)
        {
            return entity.Id;
        }
    }
}
