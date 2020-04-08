﻿namespace University_Management_System_API.Business.Processor.Auth
{
    using University_Management_System_API.Business.Convertor.User;

    public interface IAuthProcessor
    {
        string GetAuthToken();
        UserResult GetUser();
        void EraseApiSession();
        bool IsActiveUser(UserResult result);
    }
}
