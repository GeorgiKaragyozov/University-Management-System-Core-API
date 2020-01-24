using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.RoomStatus
{
    public class RoomStatusDaoEF : BaseDaoEF<Model.RoomStatus, long>, IRoomStatusDao
    {
        public RoomStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
