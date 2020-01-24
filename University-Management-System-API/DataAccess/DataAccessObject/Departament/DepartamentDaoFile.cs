using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Departament
{
    public class DepartamentDaoFile : BaseDaoFile<Model.Departament, long, IDepartamentStorage>, IDepartamentDao
    {
        protected override long GetPK(Model.Departament entity)
        {
            return entity.Id;
        }

        public DepartamentDaoFile(IDepartamentStorage storage)
            : base(storage)
        {

        }
    }
}
