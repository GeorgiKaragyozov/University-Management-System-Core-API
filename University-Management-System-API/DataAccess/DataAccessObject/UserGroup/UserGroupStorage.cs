using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroup
{
    public class UserGroupStorage : BaseStorage<Model.UserGroup, long>, IUserGroupStorage
    {
        private readonly string _jsonFile = @"";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.UserGroup entity)
        {
            return entity.Id;
        }
    }
}
