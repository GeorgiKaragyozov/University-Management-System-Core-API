using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Room
{
    public class RoomDaoEF : BaseDaoEF<Model.Room, long>, IRoomDao
    {
        public RoomDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
