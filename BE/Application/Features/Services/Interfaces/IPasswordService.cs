namespace Application.Features.Services.Interfaces
{
    public interface IPasswordService
    {
        string EncrytpPassword(string password);
        bool VerifyPasswrord(string password, string passwordHash);
    }
}
