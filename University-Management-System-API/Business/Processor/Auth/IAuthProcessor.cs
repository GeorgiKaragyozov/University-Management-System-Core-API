namespace University_Management_System_API.Business.Processor.Auth
{
    public interface IAuthProcessor
    {
        string GetAuthToken();

        void EraseApiSession();
    }
}
