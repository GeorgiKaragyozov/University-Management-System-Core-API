using University_Management_System_API.DataAccess.DataAccessObject.Discipline;
using University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus;
using University_Management_System_API.Business.Convertor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.Account;

namespace University_Management_System_API.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineParamConverter 
        : BaseParamConverter<TeacherDisciplineParam, Model.TeacherDiscipline>,
          ITeacherDisciplineParamConverter
    {
        private IAccountDao _accountDao;
        public IAccountDao AccountDao
        {
            get { return this._accountDao; }
            set { this._accountDao = value; }
        }


        private IDisciplineDao _disciplineDao;
        public IDisciplineDao DisciplineDao
        {
            get { return this._disciplineDao; }
            set { this._disciplineDao = value; }
        }


        private ITeacherDisciplineStatusDao _statusDao;
        public ITeacherDisciplineStatusDao StatusDao
        {
            get { return this._statusDao; }
            set { this._statusDao = value; }
        }

        public TeacherDisciplineParamConverter(
            IAccountDao accountDao,
            IDisciplineDao disciplineDao,
            ITeacherDisciplineStatusDao statusDao)
        {
            this.AccountDao = accountDao;
            this.DisciplineDao = disciplineDao;
            this.StatusDao = statusDao;
        }

        public override Model.TeacherDiscipline GetEntity(TeacherDisciplineParam param)
        {
            return new Model.TeacherDiscipline
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(TeacherDisciplineParam param,
            Model.TeacherDiscipline entity)
        {
            entity.Account = AccountDao.Find(param.TeacherId);
            entity.Discipline = DisciplineDao.Find(param.DisciplineId);
            entity.Status = StatusDao.Find(param.StatusId);
        }
    }
}
