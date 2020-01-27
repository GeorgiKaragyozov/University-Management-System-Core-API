﻿using System;
using University_Management_System_API.Business.Convertor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.AccountStatus;
using University_Management_System_API.DataAccess.DataAccessObject.AccountType;
using University_Management_System_API.DataAccess.DataAccessObject.Departament;
using University_Management_System_API.DataAccess.DataAccessObject.Speciality;
using University_Management_System_API.DataAccess.DataAccessObject.User;

namespace University_Management_System_API.Business.Convertor.Account
{
    public class AccountParamConverter 
        : BaseParamConverter<AccountParam, Model.Account>, IAccountParamConverter
    {
        private IUserDao _userDao;
        public IUserDao UserDao
        {
            get 
            {
                return this._userDao;
            }
            set 
            { 
                this._userDao = value; 
            }
        }


        private IAccountStatusDao _statusDao;
        public IAccountStatusDao StatusDao
        {
            get
            {
                return this._statusDao;
            }
            set 
            {
                this._statusDao = value; 
            }
        }


        private ISpecialityDao _specialityDao;
        public ISpecialityDao SpecialityDao
        {
            get
            {
                return this._specialityDao;
            }
            set
            {
                this._specialityDao = value;
            }
        }


        private IDepartamentDao _departamentDao;
        public IDepartamentDao DepartamentDao
        {
            get
            {
                return this._departamentDao;
            }
            set
            {
                this._departamentDao = value;
            }
        }


        private IAccountTypeDao _accountTypeDao;
        public IAccountTypeDao AccountTypeDao
        {
            get { return this._accountTypeDao; }
            set { this._accountTypeDao = value; }
        }

        public AccountParamConverter(
            IUserDao userDao,
            IAccountStatusDao accountStatusDao,
            ISpecialityDao specialityDao,
            IDepartamentDao departamentDao,
            IAccountTypeDao accountTypeDao)
        {
            this.UserDao = userDao;
            this.AccountTypeDao = accountTypeDao;
            this.SpecialityDao = specialityDao;
            this.DepartamentDao = departamentDao;
            this.AccountTypeDao = accountTypeDao;
        }

        public override void ConvertSpecific(AccountParam param, Model.Account entity)
        {
            entity.User = UserDao.Find(param.UserId);
            entity.Status = StatusDao.Find(param.StatusId);
            entity.Speciality = SpecialityDao.Find(param.SpecialityId);
            entity.TypeAccount = AccountTypeDao.Find(param.TypeId);

            //
            if (entity.TypeAccount.Name != "Student")
            {
                entity.Departament = DepartamentDao.Find(param.DepartamentId);
            }      

            if (entity.Status == null || entity.User == null)
            {
                throw new Exception();
            }
        }    

        public override Model.Account GetEntity(AccountParam param)
        {
            return new Model.Account
            {
                Id = param.Id,
                Code = param.Code
            };
        }       
    }
}