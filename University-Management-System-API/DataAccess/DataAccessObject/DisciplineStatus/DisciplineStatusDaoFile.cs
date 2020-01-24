using University_Management_System_API.DataAccess.DataAccessObject.Common;
using University_Management_System_API.Model;

namespace University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus
{
    public class DisciplineStatusDaoFile
        : BaseDaoFile<Model.DisciplineStatus, long, IDisciplineStatusStorage>, IDisciplineStatusDao
    {
        protected override long GetPK(Model.DisciplineStatus entity)
        {
            return entity.Id;
        }

        public DisciplineStatusDaoFile(IDisciplineStatusStorage storage)
            : base(storage)
        {

        }
    }
}
