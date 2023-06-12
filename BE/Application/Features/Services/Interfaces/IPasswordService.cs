namespace Application.Features.Services.Interfaces
{
    public interface IPasswordService
    {
        string EncryptPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
    }
}
