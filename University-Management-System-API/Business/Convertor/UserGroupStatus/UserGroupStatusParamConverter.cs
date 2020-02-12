﻿using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.UserGroupStatus
{
    public class UserGroupStatusParamConverter
           : BaseParamConverter<UserGroupStatusParam, Model.UserGroupStatus>,  IUserGroupStatusParamConverter
    {
        public override Model.UserGroupStatus GetEntity(UserGroupStatusParam param)
        {
            return new Model.UserGroupStatus
            {
                Id = param.Id,
            };
        }

        public override void ConvertSpecific(UserGroupStatusParam param, Model.UserGroupStatus entity)
        {
        }
    }
}
