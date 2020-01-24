﻿using University_Management_System_API.DataAccess.DataAccessObject.FacultyStatus;
using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Faculty
{
    public class FacultyParamConverter 
        : BaseParamConverter<FacultyParam, Model.Faculty>, IFacultyParamConverter
    {
        private IFacultyStatusDao _statusDao;
        public IFacultyStatusDao StatusDao
        {
            get { return this._statusDao; }
            set { this._statusDao = value; }
        }

        public FacultyParamConverter(IFacultyStatusDao statusDao)
        {
            this.StatusDao = statusDao;
        }

        public override Model.Faculty GetEntity(FacultyParam param)
        {
            return new Model.Faculty
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(FacultyParam param, Model.Faculty entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);
        }
    }
}
