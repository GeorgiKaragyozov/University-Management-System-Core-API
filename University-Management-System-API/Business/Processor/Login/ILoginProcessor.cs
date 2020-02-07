namespace University_Management_System_API.Business.Processor.Login
{
    public interface ILoginProcessor
    {
        string GetAuthToken();

        string ComputeSha512Hash(string token); 

        string RandomAuthTokenGenerator();
    }
}
