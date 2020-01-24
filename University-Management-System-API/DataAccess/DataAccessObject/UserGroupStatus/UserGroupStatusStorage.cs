using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus
{
    public class UserGroupStatusStorage : BaseStorage<Model.UserGroupStatus, long>, IUserGroupStatusStorage
    {
        private readonly string _jsonFile = @"";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.UserGroupStatus entity)
        {
            return entity.Id;
        }
    }
}
