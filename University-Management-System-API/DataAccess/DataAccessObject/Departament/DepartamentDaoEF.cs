using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Departament
{
    public class DepartamentDaoEF : BaseDaoEF<Model.Departament, long>,  IDepartamentDao
    {
        public DepartamentDaoEF(UniversityManagementSystemContext context)
         : base(context)
        {

        }
    }
}
