using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Discipline
{
    public class DisciplineDaoFile : BaseDaoFile<Model.Discipline, long, IDisciplineStorage>, IDisciplineDao
    {
        protected override long GetPK(Model.Discipline entity)
        {
            return entity.Id;
        }

        public DisciplineDaoFile(IDisciplineStorage storage)
            : base(storage)
        {

        }
    }
}
