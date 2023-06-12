namespace Application.Features.Services.Interfaces
{
    public interface IPasswordService
    {
        string EncrtpyPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
    }
}
